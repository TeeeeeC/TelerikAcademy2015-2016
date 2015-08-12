//var person = (function () {
//    var person = {
//        init: function (name, age) {
//            this.name = name;
//            this.age = age;

//            return this;
//        },
//        introduce: function () {
//            return 'My name is ' + this.name + ' and I am ' + this.age + ' years old.';
//        }
//    };

//    return person;
//}());

//var student = (function (parent) {
//    var student = Object.create(parent);

//    Object.defineProperty(student, 'init', {
//        value: function (name, age, grade) {
//            parent.init.call(this, name, age);
//            this.grade = grade;

//            return this;
//        }
//    });

//    Object.defineProperty(student, 'introduce', {
//        value: function () {
//            return parent.introduce.call(this) + ' Grade = ' + this.grade;
//        }
//    });

//    return student;
//}(person));




//var personObj = Object.create(person).init('Pesho', 23);
//var studentObj = Object.create(student).init('Gosho', 23, 3);
//console.log(personObj);
//console.log(studentObj);

//function solve() {
//    function validateTitle(title) {
//        if (title.length === 0 || title.match(/^\s|\s$/i) || title.match(/\s{2,}/i)) {
//            return true;
//        }

//        return false;
//    }

//    function validateName(name) {
//        var names = name.split(' ');
//        if (names.length !== 2 || !names[0].match(/^[A-Z][a-z]*$/) || !names[1].match(/^[A-Z][a-z]*$/)) {
//            return true
//        }
//        return false;
//    }

//    function validateID(ids, ID) {
//        var existID = ids.some(function (studentID) {
//            return ID === studentID;
//        });

//        return !existID;
//    }

//    function validateResults(results, studentIDs) {
//        for (var i = 0; i < results.length; i += 1) {
//            var result = results[i];
//            if (validateID(studentIDs, result.StudentID)) {
//                return true;
//            }

//            if (isNaN(result.score)) {
//                return true;
//            }

//            for (var j = i + 1; j < results.length; j += 1) {
//                if (result.StudentID === results[j].StudentID) {
//                    return true;
//                }
//            }
//        }

//        return false;
//    }

//    var Course = {
//        init: function (title, presentations) {
//            if (validateTitle(title) || presentations.length === 0) {
//                throw new Error();
//            }

//            for (var i = 0; i < presentations.length; i += 1) {
//                if (validateTitle(presentations[i])) {
//                    throw new Error();
//                }
//            }

//            this.title = title;
//            this.presentations = presentations;
//            this.ID = 0;
//            this.students = [];
//            this.ids = [];
//            this.homeworks = [];
//            return this;
//        },
//        addStudent: function (name) {
//            if (validateName(name)) {
//                throw new Error();
//            }

//            var names = name.split(' ');
//            var student = {
//                firstname: names[0],
//                lastname: names[1],
//                id: ++this.ID
//            };

//            this.students.push(student);
//            this.ids.push(this.ID);
//            return this.ID;
//        },
//        getAllStudents: function () {
//            return this.students;
//        },
//        submitHomework: function (studentID, homeworkID) {
//            if (validateID(this.ids, studentID) || homeworkID < 1
//								|| homeworkID > this.presentations.length) {
//                throw new Error();
//            }

//            if (!Array.isArray(this.homeworks[studentID])) {
//                this.homeworks[studentID] = [];
//                this.homeworks[studentID].push(homeworkID);
//            } else {
//                if (validateID(this.homeworks[studentID], homeworkID)) {
//                    this.homeworks[studentID].push(homeworkID);
//                }
//            }
//        },
//        pushExamResults: function (results) {
//            if (validateResults(results) || !Array.isArray(results)) {
//                throw new Error();
//            }
//        },
//        getTopStudents: function () {
//        }
//    };

//    return Course;
//}


//var jsoop = Object.create(solve())
//                .init('C#', ['C#']);
//jsoop.addStudent('Petar' + ' ' + 'Ivanov');
//jsoop.addStudent('Teodor' + ' ' + 'Nikolov');
//jsoop.pushExamResults([{ StudentID: 1, score: 4 }, { StudentID: 2, score: 5 }]);

//function solve() {
//    var module = (function () {
//        function validateStrings(str) {
//            if (typeof str !== 'string' || str.length < 3 || str.length > 25 || str === undefined) {
//                return true;
//            }
//            return false;
//        }

//        function sortByTitleThenById(first, second) {
//            if (first.title < second.title) {
//                return -1;
//            }
//            else if (first.title > second.title) {
//                return 1;
//            }

//            if (first.id < second.id) {
//                return -1;
//            }
//            else if (first.id > second.id) {
//                return 1;
//            }
//            else {
//                return 0;
//            }
//        }

//        var player = (function () {
//            var idPlayer = 0;
//            var player = {
//                init: function (name) {
//                    this.name = name;
//                    this.playlists = [];
//                    this._id = ++idPlayer;
//                    return this;
//                },
//                addPlaylist: function (playlistToAdd) {
//                    if (playlistToAdd.hasOwnProperty('title') || playlistToAdd === undefined) {
//                        throw new Error();
//                    }
//                    this.playlists.push(playlistToAdd);

//                    return this;
//                },
//                getPlaylistById: function (id) {
//                    if (id === undefined) {
//                        throw new Error();
//                    }
//                    for (var i = 0; i < this.playlists.length; i += 1) {
//                        var currPlaylist = this.playlists[i];
//                        if (currPlaylist._id === id) {
//                            return currPlaylist;
//                        }
//                    }
//                    return null;
//                },
//                removePlaylist: function (id) {
//                    if (id === undefined) {
//                        throw new Error();
//                    }
//                    if (typeof id !== 'number') {
//                        id = id._id;
//                    }
//                    var isDeletedPlaylist = false;
//                    for (var i = 0; i < this.playlists.length; i += 1) {
//                        var currPlaylist = this.playlists[i];
//                        if (currPlaylist._id === id) {
//                            delete this.playlists[i];
//                            isDeletedPlaylist = true;
//                        }
//                    }

//                    if (!isDeletedPlaylist) {
//                        throw new Error();
//                    }
//                    return this;
//                },
//                listPlaylists: function (page, size) {
//                    if (page < 0 || size <= 0 || page * size > this.playlists.length) {
//                        throw new Error();
//                    }

//                    return this.playlists.slice(page * size, (page * size) + size - 1);
//                },
//                contains: function (playable, playlist) {
//                    var currPlaylist;
//                    for (var i = 0; i < this.playlists.length; i += 1) {
//                        currPlaylist = this.playlists[i];
//                        if (currPlaylist === playlist) {
//                            break;
//                        }
//                    }

//                    var playables = currPlaylist.playables;
//                    for (var i = 0; i < playables.length; i += 1) {
//                        var currPlayable = playables[i];
//                        if (currPlayable === playable) {
//                            return true;
//                        }
//                    }

//                    return false;
//                },
//                search: function (pattern) {
//                    if (pattern === undefined) {
//                        throw new Error();
//                    }
//                    var result = [],
//                        regex = new RegExp(pattern, "gi");;
//                    for (var i = 0; i < this.playlists.length; i += 1) {
//                        var currPlaylist = this.playlists[i];
//                        for (var j = 0; j < currPlaylist.playables.length; j += 1) {
//                            var currPlayable = currPlaylist.playables[j];
//                            if (currPlayable.title.match(regex)) {
//                                result.push({
//                                    name: currPlaylist.name,
//                                    id: currPlaylist.id
//                                });
//                                break;
//                            }
//                        }
//                    }

//                    return result;
//                },
//                get id() {
//                    return this._id;
//                },
//                get name() {
//                    return this._name;
//                },
//                set name(name) {
//                    if (validateStrings(name) || name === undefined) {
//                        throw new Error();
//                    }
//                    this._name = name;
//                }
//            };

//            return player;
//        }());


//        var playlist = (function () {
//            var idPlaylist = 0;
//            var playlist = {
//                init: function (name) {
//                    this.name = name;
//                    this.playables = [];
//                    this._id = ++idPlaylist;
//                    return this;
//                },
//                addPlayable: function (playable) {
//                    if (playable === undefined || typeof playable !== 'object' || playable._id === undefined) {
//                        throw new Error();
//                    }
//                    this.playables.push(playable);
//                    return this;
//                },
//                getPlayableById: function (id) {
//                    if (id === undefined) {
//                        throw new Error();
//                    }
//                    for (var i = 0; i < this.playables.length; i += 1) {
//                        var currPlayable = this.playables[i];
//                        if (currPlayable._id === id) {
//                            return currPlayable;
//                        }
//                    }
//                    return null;
//                },
//                removePlayable: function (id) {
//                    if (id === undefined) {
//                        throw new Error();
//                    }
//                    if (typeof id !== 'number') {
//                        id = id._id;
//                    }
//                    var isDeletedPlayable = false;
//                    for (var i = 0; i < this.playables.length; i += 1) {
//                        var currPlayable = this.playables[i];
//                        if (currPlayable._id === id) {
//                            delete this.playables[i];
//                            isDeletedPlayable = true;
//                        }
//                    }

//                    if (!isDeletedPlayable) {
//                        throw new Error();
//                    }
//                    return this;
//                },
//                listPlayables: function (page, size) {
//                    if (page < 0 || size <= 0 || page * size > this.playables.length) {
//                        throw new Error();
//                    }

//                    return this.playables
//                               .slice
//                               .sort(sortByTitleThenById)
//                               .splice(page * size, size);
//                },
//                get id() {
//                    return this._id;
//                },
//                get name() {
//                    return this._name;
//                },
//                set name(name) {
//                    if (validateStrings(name) || name === undefined) {
//                        throw new Error();
//                    }
//                    this._name = name;
//                }
//            };
//            return playlist;
//        }());


//        var playable = (function () {
//            var idPlayble = 0;
//            var playable = {
//                init: function (title, author) {
//                    this.title = title;
//                    this.author = author;
//                    this._id = ++idPlayble;
//                    return this;
//                },
//                play: function () {
//                    return this.id + '. ' + this.title + ' - ' + this.author;
//                },
//                get id() {
//                    return this._id;
//                },
//                get title() {
//                    return this._title;
//                },
//                set title(title) {
//                    if (validateStrings(title) || title === undefined) {
//                        throw new Error();
//                    }
//                    this._title = title;
//                },
//                get author() {
//                    return this._author;
//                },
//                set author(author) {
//                    if (validateStrings(author) || author === undefined) {
//                        throw new Error();
//                    }
//                    this._author = author;
//                }

//            };

//            return playable;
//        }());

//        var audio = (function (parent) {
//            var audio = {
//                init: function (title, author, length) {
//                    parent.init.call(this, title, author);
//                    this.length = length;
//                    return this;
//                },
//                play: function () {
//                    return parent.play.call(this) + ' - ' + this.length;
//                },
//                get length() {
//                    return this._length;
//                },
//                set length(length) {
//                    if (isNaN(+length) || length < 1) {
//                        throw new Error();
//                    }
//                    this._length = length;
//                }
//            };

//            return audio;
//        }(playable));

//        var video = (function (parent) {
//            var video = {
//                init: function (title, author, imdbRating) {
//                    parent.init.call(this, title, author);
//                    this.imdbRating = imdbRating;
//                    return this;
//                },
//                play: function () {
//                    return parent.play.call(this) + ' - ' + this.imdbRating;
//                },
//                get imdbRating() {
//                    return this._imdbRating;
//                },
//                set imdbRating(imdbRating) {
//                    if (isNaN(+imdbRating) || imdbRating < 1 || imdbRating > 5) {
//                        throw new Error();
//                    }
//                    this._imdbRating = imdbRating;
//                }
//            };

//            return video;
//        }(playable));

//        return {
//            getPlayer: function (name) {
//                return Object.create(player).init(name);
//                // returns a new player instance with the provided name
//            },
//            getPlaylist: function (name) {
//                return Object.create(playlist).init(name);
//                //returns a new playlist instance with the provided name
//            },
//            getAudio: function (title, author, length) {
//                return Object.create(audio).init(title, author, length);
//                //returns a new audio instance with the provided title, author and length
//            },
//            getVideo: function (title, author, imdbRating) {
//                return Object.create(video).init(title, author, imdbRating);
//                //returns a new video instance with the provided title, author and imdbRating
//            }
//        };
//    }());

//    return module;
//}

//var module = solve();

//player = module.getPlayer('pesho');
//playlist = module.getPlaylist('gosho');
//player.addPlaylist(playlist);
//var audio = module.getAudio('ivan', 'ivanov', 4);
//playlist.addPlayable(audio);

//console.log(player.search('van'));