var people = (function () {
	var people = {
		init: function(name, age) {
			this.name = name;
			this.age = age;
			return this;
		},

		toString: function() {
			return this.name + ' ' + this.age;
		}
	};

	return people;
}());

var student = (function(parent) {
	var student = Object.create(parent);

	Object.defineProperties(student, {
		init: {
			value: function(name, age, study) {
				parent.init.call(this, name, age);
				this.study = study;
				return this;
			}
		},

		toString: {
			value: function() {
				var baseResult = parent.toString.call(this);
				return baseResult + ' ' + this.study;
			}
		},

		move: {
			value: function() {
				return 'I\'m moving!';
			}
		}
	});

	return student;
}(people));

var employee = (function(parent) {
	var employee = Object.create(parent);

	Object.defineProperties(employee, {
		init: {
			value: function(name, age, study, salary) {
				parent.init.call(this, name, age, study);
				this.salary = salary;
				return this;
			}
		},
		toString: {
			value: function() {
				var baseResult = parent.toString.call(this);
				return baseResult + ' ' + this.salary;
			}
		}
	});
	return employee;
}(student));



var person = Object.create(people).init('Gosho', 23);
var currStudent = Object.create(student).init('Pesho', 25, true);
var currEmployee = Object.create(employee).init('Tosho', 25, true, 2000);
console.log(person.toString());
console.log(currStudent.toString());
console.log(currEmployee.toString());
console.log(currEmployee.move());