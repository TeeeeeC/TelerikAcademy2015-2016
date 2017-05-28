﻿/* 
Create a function that:
*   **Takes** an array of animals
    *   Each animal has propeties `name`, `species` and `legsCount`
*   **groups** the animals by `species`
    *   the groups are sorted by `species` descending
*   **sorts** them ascending by `legsCount`
	*	if two animals have the same number of legs sort them by name
*   **prints** them to the console in the format:
```
    ----------- (number of dashes is equal to the length of the GROUP_1_NAME + 1)
    GROUP_1_NAME:
    ----------- (number of dashes is equal to the length of the GROUP_1_NAME + 1)
    NAME has LEGS_COUNT legs //for the first animal in group 1
    NAME has LEGS_COUNT legs //for the second animal in group 1
    ----------- (number of dashes is equal to the length of the GROUP_2_NAME + 1)
    GROUP_2_NAME:
    ----------- (number of dashes is equal to the length of the GROUP_2_NAME + 1)
    NAME has LEGS_COUNT legs //for the first animal in the group 2
    NAME has LEGS_COUNT legs //for the second animal in the group 2
    NAME has LEGS_COUNT legs //for the third animal in the group 2
    NAME has LEGS_COUNT legs //for the fourth animal in the group 2
```
*   **Use underscore.js for all operations**
*/

function solve() {
    return function (animals) {
        var groupBySpecies = _.groupBy(animals, 'species');
        var sortBySpeciesDes = _.sortBy(groupBySpecies, function(animal) {
             return animal.getPropertyValue;
        })
            .reverse();
        var sortedAnimals = [];
        _.each(sortBySpeciesDes, function (animalsByGroups) {
            sortedAnimals.push(_.sortBy(_.sortBy(animalsByGroups, function (animal) {
                return animal.name;
            }), 'legsCount'));
        });

        _.each(sortedAnimals, function (animal) {
            console.log(new Array(animal[0].species.length + 2).join('-'));
            console.log(animal[0].species + ':');
            console.log(new Array(animal[0].species.length + 2).join('-'));

            _.each(animal, function (someAnimal) {
                console.log(someAnimal.name + ' has ' + someAnimal.legsCount + ' legs');
            });
        });
    };
}

module.exports = solve;