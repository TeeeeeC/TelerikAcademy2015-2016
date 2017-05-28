/// <reference path="C:\Telerik Academy\10. JS Applications\01. Underscore\Underscore\Scripts/underscore.js" />

/* 
Create a function that:
*   Takes an array of students
    *   Each student has a `firstName` and `lastName` properties
*   **Finds** all students whose `firstName` is before their `lastName` alphabetically
*   Then **sorts** them in descending order by fullname
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   Then **prints** the fullname of founded students to the console
*   **Use underscore.js for all operations**
*/

function solve() {
    return function (students) {
        var studentsFirstNameBeforLastName = _.filter(students, function(student) {
            student.fullName = student.firstName + ' ' + student.lastName;

            return student.firstName < student.lastName;
        });
        var sortedStudentsByFullName = _.sortBy(studentsFirstNameBeforLastName, 'fullName').reverse();

        _.each(sortedStudentsByFullName, function(student) {
            console.log(student.fullName);
        });
    }
}

module.exports = solve;
