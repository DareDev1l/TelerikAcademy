/* ------------ Problem 1 -------------- */
console.log('------------ Problem 1 --------------');

var firstPoint = {
    x: 2,
    y: 3
};

var secondPoint = {
    x: 5,
    y: 6
};

var firstLine = {
    x1: 1,
    y1: 2,
    x2: 3,
    y2: 4
};

var secondLine = {
    x1: 4,
    y1: 4,
    x2: 5,
    y2: 5
};

var thirdLine = {
    x1: 2,
    y1: 0,
    x2: 3,
    y2: 5
};

function distanceBetweenPoints(firstPoint, secondPoint){
    var x1 = firstPoint.x,
        y1 = firstPoint.y,
        x2 = secondPoint.x,
        y2 = secondPoint.y;

    return Math.abs(Math.sqrt(
        (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)
    ));
}

function checkExistingTriangle(firstLine, secondLine , thirdLine){
    var a = distanceBetweenPoints({x : firstLine.x1, y: firstLine.y1}, {x : firstLine.x2, y: firstLine.y2});
    var b = distanceBetweenPoints({x : secondLine.x1, y: secondLine.y1}, {x : secondLine.x2, y: secondLine.y2});
    var c = distanceBetweenPoints({x : thirdLine.x1, y: thirdLine.y1}, {x : thirdLine.x2, y: thirdLine.y2});

    return !(a + b < c || a + c < b || b + c < a);
}

var msg = checkExistingTriangle(firstLine,secondLine,thirdLine)?'can':'can\'t';
var a = distanceBetweenPoints({x : firstLine.x1, y: firstLine.y1}, {x : firstLine.x2, y: firstLine.y2});
var b = distanceBetweenPoints({x : secondLine.x1, y: secondLine.y1}, {x : secondLine.x2, y: secondLine.y2});
var c = distanceBetweenPoints({x : thirdLine.x1, y: thirdLine.y1}, {x : thirdLine.x2, y: thirdLine.y2});


console.log('Distance between points (' + firstPoint.x + ',' + firstPoint.y + ') , (' + secondPoint.x + ', ' + secondPoint.y + ' )' + ' -> ' + distanceBetweenPoints(firstPoint, secondPoint).toFixed(2));
console.log('a = ' + a.toFixed(2) + ' , b = ' + b.toFixed(2) + ' , c = ' + c.toFixed(2));
console.log('The lines ' + msg + ' form a triangle');


/* ------------ Problem 2 -------------- */
console.log('------------ Problem 2 --------------');

Array.prototype.remove = function(value){
    for(var element in this){
        if(this[element] === value){
            this.splice(element, 1);
        }
    }
};

arr = [1,2,3,2,5,2,6];

arr.remove(2);

console.log(arr);

/* ------------ Problem 3 -------------- */
console.log('------------ Problem 3 --------------');

function deepCopy(receivedObj){
    var obj = {};

    for(var prop in receivedObj){
        obj[prop] = receivedObj[prop];
    }

    return obj;
}

var obj = {
    firstName : 'Pesho',
    lastName : 'Ivanov'
};

var copiedObj = deepCopy(obj);

console.log(copiedObj);


/* ------------ Problem 4 -------------- */
console.log('------------ Problem 4 --------------');

function hasProp(obj, prop){
    for(var property in obj){
        if(property == prop){
            return true;
        }
    }
    return false;
}

var prop = 'firstName';

console.log('obj has property ' + prop + ' ? : ' + hasProp(obj, prop));

/* ------------ Problem 5 -------------- */
console.log('------------ Problem 5 --------------');

var people = [
    { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname : 'Bay', lastname: 'Ivan', age: 81}
];

function getYoungestPerson(people){
    var minAge = 1000,
        index;
    for(var person in people){
        if(people[person].age < minAge){
            index = person;
        }
    }
    return people[index];
}

var youngest = getYoungestPerson(people);

console.log(youngest);

/* ------------ Problem 6 -------------- */
console.log('------------ Problem 6 --------------');

function group(arr, prop) {
    var groupedArr = [];

    for(var i = 0, len = arr.length; i < len; i++){
        if(!groupedArr[arr[i][prop]]) {
            groupedArr[arr[i][prop]] = [];
        }
        groupedArr[arr[i][prop]].push(arr[i]);
    }

    return groupedArr;
}

people = [
    { firstname : 'Todor', lastname: 'Petrov', age: 32 },
    { firstname : 'Bay', lastname: 'Ivan', age: 81},
    { firstname : 'Gosho', lastname: 'Ivanov', age: 81},
    { firstname : 'Gosho', lastname: 'Iliev', age: 32},
    { firstname : 'Ivan', lastname: 'Petrov', age: 55},
    { firstname : 'Gosho', lastname: 'Stoqnov', age: 32}
];


var groupedByFname = group(people, 'firstname'),
    groupedByLname = group(people, 'lastname');

console.log('Grouped by first name:');
console.log(groupedByFname);
console.log('Grouped by last name:');
console.log(groupedByLname);