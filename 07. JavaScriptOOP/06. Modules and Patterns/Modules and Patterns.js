function solve() {
	function validateTitle(title) {
		if(title.length === 0 || title.match(/^\s|\s$/i) || title.match(/\s{2,}/i)) {
			return true;
		}

		return false;
	}

	function validateName(name) {
		var names = name.split(' ');
		if(names.length !== 2 || !names[0].match(/^[A-Z][a-z]*$/) || !names[1].match(/^[A-Z][a-z]*$/)) {
			return true
		}
		return false;
	}

	function validateID(ids, ID) {
		var existID = ids.some(function(studentID) {
			return ID === studentID;
		});

		return !existID;
	}

	function validateResults(results, studentIDs) {
		for (var i = 0; i < results.length; i += 1) {
			var result = results[i];
			if (validateID(studentIDs, result.StudentID)) {
				return true;
			}

			if (isNaN(result.score)) {
				return true;
			}

			for (var j = i + 1; j < results.length; j += 1) {
				if (result.StudentID === results[j].StudentID) {
					return true;
				}
			}
		}

		return false;
	}

	var Course = {
		init: function(title, presentations) {
			if(validateTitle(title) || presentations.length === 0) {
				throw new Error();
			}

			for(var i = 0; i < presentations.length; i += 1) {
				if(validateTitle(presentations[i])) {
					throw new Error();
				}
			}

			this.title = title;
			this.presentations = presentations;
			this.ID = 0;
			this.students = [];
			this.ids = [];
			this.homeworks = [];
			this.examResults = [];
			return this;
		},
		addStudent: function(name) {
			if(validateName(name)) {
				throw new Error();
			}

			var names = name.split(' ');
			var student = {
				firstname: names[0],
				lastname: names[1],
				id: ++this.ID
			};

			this.students.push(student);
			this.ids.push(this.ID);
			return this.ID;
		},
		getAllStudents: function() {
			return this.students;
		},
		submitHomework: function(studentID, homeworkID) {
			if(validateID(this.ids, studentID) || homeworkID < 1 
								|| homeworkID > this.presentations.length) {
				throw new Error();
			}

			if(!Array.isArray(this.homeworks[studentID])) {
				this.homeworks[studentID] = [];
				this.homeworks[studentID].push(homeworkID);
			} else {
				if(validateID(this.homeworks[studentID], homeworkID)) {
					this.homeworks[studentID].push(homeworkID);
				}
			}
		},
		pushExamResults: function(results) {
			if(validateResults(results, this.ids) || !Array.isArray(results)) {
				throw new Error();
			}

			for (var i = 0, length = this.ids.length; i < length; i += 1) {
				this.examResults[i] = {
					StudentID: results[i] !== undefined ? results[i].StudentID : this.ids[i],
					score: results[i] !== undefined ? results[i].score : 0
				}
			}

			// Add results form homeworks
			for (var j = 0, length = this.examResults.length; j < length; j += 1) {
				var currentStudent = this.examResults[j],
					homeworkResult =  0;

				if (Array.isArray(this.homeworks[currentStudent.StudentID])) {
					homeworkResult = 25 * (this.homeworks[currentStudent.StudentID].length / this.presentations.length);
				}
				this.examResults[j].score += homeworkResult;
			}
		},
		getTopStudents: function() {
			var sortedResult = this.examResults.sort(function(a, b) {
				return b.score - a.score;
			});

			return sortedResult.slice(0, 10);
		}
	};

	return Course;
}

module.exports = solve;

var jsoop = Object.create(solve())
                .init('C#', ['C#', 'C#2']);
jsoop.addStudent('Petar' + ' ' + 'Ivanov');
jsoop.addStudent('Teodor' + ' ' + 'Nikolov');
jsoop.addStudent('Goodor' + ' ' + 'Nikolov');
jsoop.addStudent('Tetar' + ' ' + 'Ivanov');
jsoop.addStudent('Seodor' + ' ' + 'Nikolov');
jsoop.addStudent('Foodor' + ' ' + 'Nikolov');
jsoop.addStudent('Hetar' + ' ' + 'Ivanov');
jsoop.addStudent('Neodor' + ' ' + 'Nikolov');
jsoop.addStudent('Moodor' + ' ' + 'Nikolov');
jsoop.addStudent('Aetar' + ' ' + 'Ivanov');
jsoop.addStudent('Xeodor' + ' ' + 'Nikolov');
jsoop.addStudent('Coodor' + ' ' + 'Nikolov');
jsoop.submitHomework(1 , 1);
jsoop.submitHomework(2 , 1);
jsoop.submitHomework(3 , 1);
jsoop.pushExamResults([{StudentID: 1, score: 60}, {StudentID: 2, score: 30}, {StudentID: 3, score: 75}]);
console.log(jsoop.getTopStudents());