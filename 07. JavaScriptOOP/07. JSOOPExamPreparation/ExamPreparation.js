var People = (function(){
	var Student = (function() {
		function Student(name, age) {
			this.name = name;
			this.age = age;				
		}

		Student.prototype = {
			introduce: function() {
				return 'I am ' + this.name + ' and I am ' + this.age + ' years old!';
			}
		};

		return Student;
	}());

	var Employee = (function() {
		function Employee(name, age, salary) {
			Student.call(this, name, age)
			this.salary = salary;
		}

		Employee.prototype = Object.create(Student); // new Student();

		Employee.prototype.introduce = function () {
			var result = Student.prototype.introduce.call(this);
			return result + ' My salary is ' + this.salary + 'BGN.';
		} 


		return Employee;
	}());

	var Cleaner = (function() {
		function Cleaner(name, age, salary, work) {
			Employee.call(this, name, age, salary);
			this.work = work;
		}

		Cleaner.prototype = new Employee();

		Cleaner.prototype.introduce = function () {
			var result = Employee.prototype.introduce.call(this);
			return result + ' I am ' + (this.work ? 'working' : 'not working') + ' at the moment.';
		}

		return Cleaner;
	}());

	return  {
		Student: Student,
		Employee: Employee,
		Cleaner: Cleaner
	};
}());

var student = Object.create(new People.Student('Pesho', 25)),
	employee = new People.Employee('Tosho Dundaviq', 26, 2000),
	cleaner = new People.Cleaner('Pepa Dashnata', 30, 500, false);
console.log(student.introduce());
console.log(employee.introduce());
console.log(cleaner.introduce());
