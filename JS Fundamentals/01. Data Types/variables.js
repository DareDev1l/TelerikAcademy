/* --------------- Task 1 ------------------ */
console.log(' --------------- Task 1 ------------------ ');
var number = 10,
    string = 'Some text',
    nullVar = null,
    obj = {
        firstName : 'Pesho',
        lastName : 'Goshov'
    },
    undefinedVar,
    NaNVar = 'Not a number';

console.log(number + ' -> ' + typeof (number));
console.log(string + ' -> ' + typeof (string));
console.log(nullVar + ' -> ' + typeof (nullVar));
console.log(obj + ' -> ' + typeof (obj));
console.log(undefinedVar + ' -> ' + typeof (undefinedVar));
console.log('is NaNVar NaN ? ' + ' -> ' + isNaN(NaNVar));

/* --------------- Task 2 ------------------ */
console.log(' --------------- Task 2 ------------------ ');

var quote =   '\'How you doin\'?\', Joey said.';
console.log(quote);


/* --------------- Task 3 ------------------ */
console.log(' --------------- Task 3 ------------------ ');
console.log(typeof(number));
console.log(typeof(string));
console.log(typeof(obj));
console.log(typeof(NaNVar));

/* --------------- Task 4 ------------------ */
console.log(' --------------- Task 4 ------------------ ');
console.log(typeof(undefinedVar));
console.log(typeof(nullVar));