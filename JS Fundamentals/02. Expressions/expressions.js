/* ------------------ Task 1 ------------------ */
console.log(' ------------------ Task 1 ------------------ ');

var integer = 19;
var oddOrEven = integer % 2 === 0;
var msg = oddOrEven? 'Even':'Odd';
console.log(integer + ' -> ' + msg);

/* ------------------ Task 2 ------------------ */
console.log(' ------------------ Task 2 ------------------ ');

integer = 35;
var dividableBy5And7 = (integer % 7 === 0) && (integer % 5 === 0),
    msg = dividableBy5And7? 'Dividable by 7 and 5':'Not Dividable by 7 and 5';

console.log(integer + ' -> ' + msg);

/* ------------------ Task 3 ------------------ */
console.log(' ------------------ Task 3 ------------------ ');

var width = 10,
    height = 5,
    area = width * height;

console.log(width + ' x ' + height + ' -> ' + area);

/* ------------------ Task 4 ------------------ */
console.log(' ------------------ Task 4 ------------------ ');

integer = 472791;
var isThirdDigit7 = parseInt(integer / 100) % 10 === 7;

console.log(integer + ' -> Is third digit 7: ' + isThirdDigit7);


/* ------------------ Task 5 ------------------ */
console.log(' ------------------ Task 5 ------------------ ');

var bitNumber = 7; // 0111
var mask = 1 << 2;
var result = bitNumber & mask;
var bit;

result = result >> 2;


if(result === 1){
    bit = 1;
}
else {
    bit = 0;
}

console.log(bitNumber.toString(2) + ' -> Third bit from right is ' + bit);


/* ------------------ Task 6 ------------------ */
console.log(' ------------------ Task 6 ------------------ ');

var x = 2;
var y = 2;

var isPointInCircle = x*x + y*y < 25;
    msg = isPointInCircle? 'Inside':'Outside';

console.log('(' + x + ' , ' + y + ') -> ' + msg + ' cirlce K(0,5)')


/* ------------------ Task 7 ------------------ */
console.log(' ------------------ Task 7 ------------------ ');

var primeNum = 37;
var isPrime = true;

for(var i = 2; i < primeNum ; i += 1){
    if(primeNum % i == 0){
        isPrime = false;
    }
}

msg = isPrime? 'Prime':'Not prime';

console.log(primeNum + ' -> ' + msg);


/* ------------------ Task 8 ------------------ */
console.log(' ------------------ Task 8 ------------------ ');

var a = 10;
var b = 5;
var h = 8;

    area = (a + b) * h / 2;

console.log('a = ' + a + ', b = ' + b + ', h = ' + h + ' ->' + ' Area is ' + area);


/* ------------------ Task 9 ------------------ */
console.log(' ------------------ Task 9 ------------------ ');

x = 2;
y = 2;

var insideCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) < 9;
var outsideRectangle = (y > 1 || y < -1) && (x < -1 || x > 5);

msg = insideCircle && outsideRectangle ? ' Point is inside circle and outside rectangle':' Point is NOT: inside circle and outside rectangle';

console.log('(' + x + ' , ' + y + ')' + ' ->' + msg);




