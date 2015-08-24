/* 
Create a function that:
*   Takes an array of students
    *   Each student has:
        *   `firstName`, `lastName` and `age` properties
        *   Array of decimal numbers representing the marks         
*   **finds** the student with highest average mark (there will be only one)
*   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve() {
    return function (students) {
        var studentWithHighestMarks = _.max(students, function (student) {
            student.fullName = student.firstName + ' ' + student.lastName;

            return _.reduce(student.marks, function(sum, mark) {
                return sum + mark;
            }, 0);
        });

        var highestMark = _.reduce(studentWithHighestMarks.marks, function (sum, mark) {
            return sum + mark;
        });

        var result = [];
        result.push(studentWithHighestMarks.fullName + ' has an average score of ' + (highestMark / studentWithHighestMarks.marks.length));

        console.log(result);
    };
}

module.exports = solve;
