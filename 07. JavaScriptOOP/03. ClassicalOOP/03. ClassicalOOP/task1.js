//function solve() {
//    var Person = (function () {
//        function Person(firstname, lastname, age) {
//            if (isNaN(+age)) {
//                throw new Error();
//            }
//            if (firstname.length < 3 || firstname.length > 20 || lastname.length < 3
//				|| lastname.length > 20 || age < 0 || age > 150) {
//                throw new Error();
//            }

//            this.fullname = firstname + ' ' + lastname;
//            this.firstname = firstname;
//            this.lastname = lastname;
//            this.age = +age;

//            this.introduce = function () {
//                return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
//            }
//        }

//        Person.prototype.introduce = function () {
//            return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
//        }

//        Object.defineProperty(Person.prototype, 'firstname', {
//            get: function () {
//                return this._firstname;
//            },
//            set: function (value) {
//                if (value.length < 3 || value.length > 20) {
//                    throw new Error();
//                }
//                this._firstname = value;
//            }
//        });

//        Object.defineProperty(Person.prototype, 'lastname',
//        {
//            get: function () {
//                return this._lastname;
//            },
//            set: function (value) {
//                if (value.length < 3 || value.length > 20) {
//                    throw new Error();
//                }
//                this._lastname = value;
//            }
//        });

//        Object.defineProperty(Person.prototype, 'age',
//        {
//            get: function () {
//                return this._age;
//            },
//            set: function (value) {
//                if (value < 3 || value > 150) {
//                    throw new Error();
//                }
//                this._age = value;
//            }
//        });

//        Object.defineProperty(Person.prototype, 'fullname',
//        {
//            get: function () {
//                return this.firstname + ' ' + this.lastname;
//            },
//            set: function (value) {
//                var names = value.split(' ');
//                this.firstname = names[0];
//                this.lastname = names[1];
//            }
//        });

//        return Person;
//    }());
//    return Person;
//}

//var domElement = (function () {
//    function validType(type) {
//        if (type.length === 0 || typeof type !== 'string' || !type.match(/^[a-z0-9]+$/ig)) {
//            return false;
//        }
//        return true;
//    }

//    function validAttribute(type) {
//        if (type.length === 0 || typeof type !== 'string' || !type.match(/^[a-z0-9\-]+$/ig)) {
//            return false;
//        }
//        return true;
//    }

//    function findElem(arr, item) {
//        var elem;
//        for (elem in arr) {
//            if (elem === item) {
//                return true;
//                break;
//            }
//        };
//        return false;
//    }

//    function sortArr(arr) {
//        var keys = [],
//            key,
//            sortedArr = [],
//            i;
//        for (key in arr) {
//            keys.push(key);
//        }

//        keys.sort();

//        for (i = 0; i < keys.length; i += 1) {
//            for (key in arr) {
//                if (keys[i] === key) {
//                    sortedArr[key] = arr[key];
//                }
//            }
//        }
//        return sortedArr;
//    }

//    function renderHTML(domElement) {
//        var result = '',
//            attr,
//            arr = [],
//            sortedArr = [];


//        result += '<' + domElement.type;
//        if (domElement.attributes !== undefined) {
//            sortedArr = sortArr(domElement.attributes);

//            for (attr in sortedArr) {
//                result += ' ' + attr + '="' + sortedArr[attr] + '"';
//            }
//        }
//        result += '>';
//        if (domElement.children.length > 0) {
//            for (var i = 0; i < domElement.children.length; i += 1) {
//                var obj = domElement.children[i];
//                if (typeof obj === 'object') {
//                    obj.content = obj.content || '';
//                    result += '<' + obj.type; 
//                    sortedArr = sortArr(obj.attributes);
//                    for (attr in sortedArr) {
//                        result += ' ' + attr + '="' + sortedArr[attr] + '"';
//                    }
//                    result += '>' + obj.content + '</' + obj.type + '>';
//                }
//                else {
//                    result += obj;
//                }
//            }
//        }

//        if(domElement.content !== undefined && domElement.children[0] === undefined) {
//            result += domElement.content;
//        }

//        result += '</' + domElement.type + '>';
//        return domElement.children.length;
//    }

//    var domElement = {
//        init: function (type) {
//            this.type = type;
//            this.attributes = [];
//            this.children = [];
//            return this;
//        },
//        appendChild: function (child) {
//            this.children.push(child);

//            if (typeof child === 'object') {
//                child.parent = this;
//            }

//            return this;
//        },
//        addAttribute: function (name, value) {
//            if (!validAttribute(name)) {
//                throw new Error();
//            }
//            this.attributes[name] = value;
//            return this;
//        },
//        removeAttribute: function (attribute) {
//            if (findElem(this.attributes, attribute)) {
//                delete this.attributes[attribute];
//            }
//            else {
//                throw new Error();
//            }
//            return this;
//        },
//        get innerHTML() {
//            return renderHTML(this);
//        },
//        get type() {
//            return this._type;
//        },
//        set type(value) {
//            if (!validType(value)) {
//                throw new Error();
//            }
//            this._type = value;
//        },
//        get attributes() {
//            return this._attributes;
//        },
//        set attributes(value) {
//            this._attributes = value;
//        },
//        get children() {
//            return this._children;
//        },
//        set children(value) {
//            this._children = value;
//        },
//        get content() {
//            return this._content;
//        },
//        set content(value) {
//            this._content = value;
//        },
//        get parent() {
//            return this._parent;
//        },
//        set parent(value) {
//            this._parent = value;
//        }
//    };
//    return domElement;
//}());

//var child = Object.create(domElement).init('child'),
//				middle = Object.create(domElement)
//					.init('middleBlq')
//					.appendChild(child);
//parent = Object.create(domElement)
//    .init('parent')
//    .appendChild(middle);

//console.log(parent.innerHTML);

//function solve() {
//    function validateTitle(title) {
//        var i,
//			symbol = '';
//        if (title[0] === ' ' || title[title.length - 1] === ' ' || title === '') {
//            return true;
//        }

//        symbol = title[0];
//        for (i = 1, len = title.length; i < len; i += 1) {
//            if ((symbol === ' ' || title[i] === ' ') && symbol === title[i]) {
//                return true;
//            }

//            symbol = title[i];
//        }
//        return false;
//    }

//    function validateName(name) {
//        var words = name.split(' ');

//        if (words.length !== 2) {
//            return true;
//        }
//        if (!(words[0].match(/^[A-Z]\w*$/) && words[1].match(/^[A-Z]\w*$/))) {
//            return true
//        }

//        return false;
//    }

//    function existStudentID(ids, studentID) {
//        var existStudentID = ids.some(function (id) {
//            return studentID === id;
//        });

//        if (existStudentID) {
//            return true;
//        }
//        else {
//            return false;
//        }
//    }

//    function checkHomeworkID(countPresentations, homeworkID) {
//        if (homeworkID < 1 || homeworkID >= countPresentations) {
//            return true;
//        }

//        return false;
//    }

//    var Course = {
//        init: function (title, presentations) {
//            this.title = title;
//            this.presentations = presentations;
//            this.students = [];
//            this.ID = 0;
//            this.ids = []

//            return this;
//        },
//        addStudent: function (name) {
//            if (validateName(name)) {
//                throw new Error();
//            }

//            var names = name.split(' '),
//				student = {
//				    firstname: names[0],
//				    lastname: names[1],
//				    id: ++this.ID
//				};

//            this.students.push(student);
//            this.ids.push(this.ID);

//            return this.ID;
//        },
//        getAllStudents: function () {
//            return this.students;
//        },
//        submitHomework: function (studentID, homeworkID) {
//            if (!existStudentID(this.ids, studentID) || checkHomeworkID(this.presentations.length, homeworkID)) {
//                throw new Error();
//            }
//        },
//        pushExamResults: function (results) {
//        },
//        getTopStudents: function () {
//        },

//        get title() {
//            return this._title;
//        },
//        set title(value) {
//            if (validateTitle(value)) {
//                throw new Error();
//            }

//            this._title = value;
//        },
//        get presentations() {
//            return this._presentations;
//        },
//        set presentations(titles) {
//            if (titles.length === 0) {
//                throw new Error();
//            }

//            for (var i = 0; i < titles.length; i += 1) {
//                if (validateTitle(titles[i])) {
//                    throw new Error();
//                }
//            }

//            this._presentations = titles;
//        }
//    };

//    return Course;
//}

//var id, jsoop = Object.create(solve());
//jsoop.init('ggg', ['ggg']);
//id = jsoop.addStudent('Ggg' + ' ' + 'Fgg');
//jsoop.submitHomework(id, 1);


function solve() {
    var domElement = (function () {

        function isValidType(type) {
            if (typeof type !== 'string') {
                throw new Error('Invalid string argument.');
            }

            return /^[A-Z0-9]+$/i.test(type);
        }

        function isValidAttributeName(name) {
            if (typeof name !== 'string') {
                throw new Error('Invalid string argument.');
            }

            return /^[A-Z0-9\-]+$/i.test(name);
        }

        function getSortedAttributesString(attributes) {
            var attributesString = '';
            var keys = [];

            for (var key in attributes) {
                keys.push(key);
            }

            keys.sort();
            var currentKey;

            for (var ind = 0, len = keys.length; ind < len; ind += 1) {
                currentKey = keys[ind];
                attributesString += ' ' + currentKey + '="' + attributes[currentKey] + '"';
            }

            return attributesString;
        }

        var domElement = {
            init: function (type) {
                this.type = type;
                this.content = '';
                this.parent;
                this.children = [];
                this.attributes = [];

                return this;
            },
            appendChild: function (child) {
                this.children.push(child);

                if (typeof child === 'object') {
                    child.parent = this;
                }

                return this;
            },
            addAttribute: function (name, value) {
                if (!isValidAttributeName(name)) {
                    throw new Error('Invalid attribute name.');
                }

                this.attributes[name] = value;

                return this;
            },
            removeAttribute: function (attribute) {
                if (!this.attributes[attribute]) {
                    throw new Error('This attribute does not exist.');
                }

                delete this.attributes[attribute];

                return this;
            },
            get innerHTML() {
                var innerHtml = '<' + this.type;
                var attributesString = getSortedAttributesString(this.attributes);
                innerHtml += attributesString + '>';

                var child;
                for (var ind = 0, len = this.children.length; ind < len; ind += 1) {
                    child = this.children[ind];

                    if (typeof child === 'string') {
                        innerHtml += child;
                    } else {
                        innerHtml += child.innerHTML;
                    }
                }

                innerHtml += this.content;
                innerHtml += '</' + this.type + '>';

                return innerHtml;
            },
            get type() {
                return this._type;
            },
            set type(value) {
                if (!isValidType(value)) {
                    throw new Error('Invalid type.');
                }

                this._type = value;
            },
            get content() {
                if (this.children.length) {
                    return '';
                }

                return this._content;
            },
            set content(value) {
                this._content = value;
            },
            get attributes() {
                return this._attributes;
            },
            set attributes(value) {
                this._attributes = value;
            },
            get children() {
                return this._children;
            },
            set children(value) {
                this._children = value;
            },
            get parent() {
                return this._parent;
            },
            set parent(value) {
                this._parent = value;
            }

        };
        return domElement;
    }());
    return domElement;
}


var child = Object.create(solve()).init('child'),
				middle = Object.create(solve())
					.init('middleBlq')
					.appendChild(child),
				parent = Object.create(solve())
					.init('parent')
					.appendChild(middle);

console.log(parent.innerHTML);
