function solve() {
    var module = (function () {
        function validateString(strValue) {
            if (strValue === undefined || typeof strValue !== 'string'
                || strValue.length < 3 || strValue.length > 25) {
                throw new Error();
            }
        }

        function validateNumberAndPositive(number) {
            if (number === undefined || isNaN(number) || number <= 0) {
                throw new Error();
            }
        }

        function validateImdbRating(number) {
            if (number === undefined || isNaN(number) || number < 1 || number > 5) {
                throw new Error();
            }
        }

        function validatePlayable(playable) {
            if (playable === undefined || typeof playable !== 'object' || playable.id === undefined) {
                throw new Error();
            }
        }

        function findIndexOfPlayable(playables, id) {
            var i,
                len;
            for (i = 0, len = playables.length; i < len; i += 1) {
                if (playables[i].id === id) {
                    return i;
                }
            }

            return -1;
        }

        function validateIdAndPlayable(idOrPlayable) {
            if (idOrPlayable === undefined) {
                throw new Error();
            }

            if (isNaN(+idOrPlayable) && typeof idOrPlayable === 'object') {
                if (idOrPlayable.id === undefined) {
                    throw new Error();
                }
                idOrPlayable = idOrPlayable.id;
                return idOrPlayable;
            }
            else if (Number(idOrPlayable)) {
                return idOrPlayable;
            }
        }

        function validatePageAndSize(page, size, maxElements) {
            if (page === undefined || typeof page !== 'number') {
                throw new Error();
            }

            if (size === undefined || typeof size !== 'number') {
                throw new Error();
            }

            if (page < 0) {
                throw new Error();
            }

            if (size <= 0) {
                throw new Error();
            }

            if (page * size > maxElements) {
                throw new Error();
            }
        }

        function getSortingFunction(firstParameter, secondParameter) {
            return function (first, second) {
                if (first[firstParameter] < second[firstParameter]) {
                    return -1;
                }
                else if (first[firstParameter] > second[firstParameter]) {
                    return 1;
                }

                if (first[secondParameter] < second[secondParameter]) {
                    return -1;
                }
                else if (first[secondParameter] > second[secondParameter]) {
                    return 1;
                }
                else {
                    return 0;
                }
            }
        }
        //--The end of validated data-------------------------------------------------------------------------------

        var player = (function () {
            var currIdPlayer = 0;
            player = Object.create({});

            Object.defineProperty(player, 'init', {
                value: function (name) {
                    this.name = name;
                    this._id = ++currIdPlayer;
                    this._playlists = [];
                    return this;
                }
            });

            Object.defineProperty(player, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (value) {
                    validateString(value);
                    this._name = value;
                }
            });

            Object.defineProperty(player, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(player, 'addPlaylist', {
                value: function (playlistToAdd) {
                    validatePlayable(playlistToAdd);

                    this._playlists.push(playlistToAdd);
                    return this;
                }
            });

            Object.defineProperty(player, 'getPlaylistById', {
                value: function (id) {
                    validateNumberAndPositive(id);
                    var index = findIndexOfPlayable(this._playlists, id);

                    return index >= 0 ? this._playlists[index] : null;
                }
            });

            Object.defineProperty(player, 'removePlaylist', {
                value: function (id) {
                    var validId = validateIdAndPlayable(id),
                        index = findIndexOfPlayable(this._playlists, validId);

                    if (index < 0) {
                        throw new Error();
                    }

                    this._playlists.splice(index, 1);

                    return this;
                }
            });

            Object.defineProperty(player, 'listPlaylists', {
                value: function (page, size) {
                    page = page || 0;
                    size = size || 9007199254740992;
                    validatePageAndSize(page, size, this._playlists.length);

                    return this
                        ._playlists
                        .slice()
                        .sort(getSortingFunction('title', 'id'))
                        .splice(page * size, size);
                }
            });

            Object.defineProperty(player, 'contains', {
                value: function (playable, playlist) {
                    validatePlayable(playable);
                    validatePlayable(playlist);
                    var currPlaylist,
                        foundPlaylist = false;
                    for (var i = 0; i < this._playlists.length; i += 1) {
                        currPlaylist = this._playlists[i];
                        if (currPlaylist === playlist) {
                            foundPlaylist = true;
                            break;
                        }
                    }

                    if (foundPlaylist) {
                        var playables = currPlaylist._playables;
                        for (var i = 0; i < playables.length; i += 1) {
                            var currPlayable = playables[i];
                            if (currPlayable === playable) {
                                return true;
                            }
                        }
                    }

                    return false;
                }
            });

            Object.defineProperty(player, 'search', {
                value: function (pattern) {
                    if (pattern === undefined) {
                        throw new Error();
                    }
                    var result = [],
                        regex = new RegExp(pattern, "gi");;
                    for (var i = 0; i < this._playlists.length; i += 1) {
                        var currPlaylist = this._playlists[i];
                        for (var j = 0; j < currPlaylist._playables.length; j += 1) {
                            var currPlayable = currPlaylist._playables[j];
                            if (currPlayable.title.match(regex)) {
                                result.push({
                                    name: currPlaylist.name,
                                    id: currPlaylist.id
                                });
                                break;
                            }
                        }
                    }

                    return result;
                }
            });

            return player;
        }());

        var playlist = (function () {
            var currIdPlaylist = 0,
                playlist = Object.create({});

            Object.defineProperty(playlist, 'init', {
                value: function (name) {
                    this.name = name;
                    this._id = ++currIdPlaylist;
                    this._playables = [];
                    return this;
                }
            });

            Object.defineProperty(playlist, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(playlist, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (value) {
                    validateString(value);
                    this._name = value;
                }
            });

            Object.defineProperty(playlist, 'addPlayable', {
                value: function (playable) {
                    validatePlayable(playable);

                    this._playables.push(playable);
                    return this;
                }
            });

            Object.defineProperty(playlist, 'getPlayableById', {
                value: function (id) {
                    validateNumberAndPositive(id);
                    var index = findIndexOfPlayable(this._playables, id);

                    return index >= 0 ? this._playables[index] : null;
                }
            });

            Object.defineProperty(playlist, 'removePlayable', {
                value: function (id) {
                    var validId = validateIdAndPlayable(id),
                        index = findIndexOfPlayable(this._playables, validId);

                    if (index < 0) {
                        throw new Error();
                    }

                    this._playables.splice(index, 1);

                    return this;
                }
            });

            Object.defineProperty(playlist, 'listPlayables', {
                value: function (page, size) {
                    page = page || 0;
                    size = size || 9007199254740992;
                    validatePageAndSize(page, size, this._playables.length);

                    return this
                        ._playables
                        .slice()
                        .sort(getSortingFunction('title', 'id'))
                        .splice(page * size, size);
                }
            });

            return playlist;
        }());

        var playable = (function () {
            var currIdPlayable = 0,
                playable = Object.create({});

            Object.defineProperty(playable, 'init', {
                value: function (title, author) {
                    this.title = title;
                    this.author = author;
                    this._id = ++currIdPlayable;
                    return this;
                }
            });

            Object.defineProperty(playable, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(playable, 'title', {
                get: function () {
                    return this._title;
                },
                set: function (value) {
                    validateString(value);
                    this._title = value;
                }
            });

            Object.defineProperty(playable, 'author', {
                get: function () {
                    return this._author;
                },
                set: function (value) {
                    this._author = value;
                }
            });

            Object.defineProperty(playable, 'play', {
                value: function () {
                    return this.id + '. ' + this.title + ' - ' + this.author;
                }
            });

            return playable;
        }());

        var audio = (function (parent) {
            var audio = Object.create(parent);

            Object.defineProperty(audio, 'init', {
                value: function (title, author, length) {
                    parent.init.call(this, title, author);
                    this.length = length;
                    return this;
                }
            });

            Object.defineProperty(audio, 'length', {
                get: function () {
                    return this._length;
                },
                set: function (value) {
                    validateNumberAndPositive(value);
                    this._length = value;
                }
            });

            Object.defineProperty(audio, 'play', {
                value: function () {
                    return parent.play.call(this) + ' - ' + this.length;
                }
            });

            return audio;
        }(playable));

        var video = (function (parent) {
            var video = Object.create(parent);

            Object.defineProperty(video, 'init', {
                value: function (title, author, imdbRating) {
                    parent.init.call(this, title, author);
                    this.imdbRating = imdbRating;
                    return this;
                }
            });

            Object.defineProperty(video, 'imdbRating', {
                get: function () {
                    return this._imdbRating;
                },
                set: function (value) {
                    validateImdbRating(value);
                    this._imdbRating = value;
                }
            });

            Object.defineProperty(video, 'play', {
                value: function () {
                    return parent.play.call(this) + ' - ' + this.imdbRating;
                }
            });

            return video;
        }(playable));

        return {
            getPlayer: function (name) {
                return Object.create(player).init(name);
            },
            getPlaylist: function (name) {
                return Object.create(playlist).init(name);
            },
            getAudio: function (title, author, length) {
                return Object.create(audio).init(title, author, length);
            },
            getVideo: function (title, author, imdbRating) {
                return Object.create(video).init(title, author, imdbRating);
            }
        };
    }());

    return module;
}

var module = solve();

var player = module.getPlayer('pesho');
var playlist = module.getPlaylist('gosho');
var playlist1 = module.getPlaylist('gosho');
player.addPlaylist(playlist);
var audio = module.getAudio('ivan', 'ivanov', 4);
var audio1 = module.getAudio('ivan', 'ivanov', 4);
playlist.addPlayable(audio);

console.log(player.contains(audio, playlist));

