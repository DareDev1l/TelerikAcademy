/* --------------- Task 1 ---------------- */
console.log('------------- Task 1 -------------');

var a = 5;
var b = 3;

console.log('a = ' + a + ' , b = ' + b + '   ->  ');

if(a > b){
    a = a + b;
    b = a - b;
    a = a - b;
}

console.log('a = ' + a + ' , b = ' + b);

/* --------------- Task 2 ---------------- */
console.log('------------- Task 2 -------------');

var c = 10;
var d = -1;
var e = 19;

console.log('c = ' + c + ' , d = ' + d + ' , e = ' + e);

// I use brackets on new line for easier reading - it is only on this problem
if(c > 0)
{
    if(d > 0)
    {
        if(e > 0)
        {
            console.log('+');
        }
        else
        {
            console.log('-');
        }
    }
    else
    {
        if(e > 0)
        {
            console.log('-');
        }
        else
        {
            console.log('+');
        }
    }
}
else // c < 0
{
    if(d > 0)
    {
        if(e > 0)
        {
            console.log('-');
        }
        else // e < 0
        {
            console.log('+');
        }
    }
    else // d < 0
    {
        if(e > 0)
        {
            console.log('+');
        }
        else
        {
            console.log('-');
        }
    }
}

/* --------------- Task 3 ---------------- */
console.log('------------- Task 3 -------------');

a = 1;
b = 2;
c = 3;

console.log('a = ' + a + ' , b = ' + b + ' , c = ' + c);

if(a > b){
    if(a > c){
        console.log(a);
    }
    else {
        console.log(c);
    }
}
else {
    if(b > c){
        console.log(b);
    }
    else {
        console.log(c);
    }
}

/* --------------- Task 4 ---------------- */
console.log('------------- Task 4 -------------');

a = 4;
b = 11;
c = 7;

var max = a,
    mid = b,
    min = c;

console.log('a = ' + a + ' , b = ' + b + ' , c = ' + c);

if(a > b){
    if(a > c){
        if(b > c)
        {
            max = a;
            mid = b;
            min = c;
        }
        else {
            max = a;
            mid = c;
            min = b;
        }
    }
    else {
        max = c;
        mid = a;
        min = b;
    }
}
else {
    if(a > c){
        max = b;
        mid = a;
        min = c;
    }
    else {
        max = b;
        mid = c;
        min = a;
    }
}

console.log('max = ' + max + ' , mid = ' + mid + ' , min = ' + min);

/* --------------- Task 5 ---------------- */
console.log('------------- Task 5 -------------');

var digit = 7;

console.log(digit);

switch(digit){
    case 0: console.log('Zero'); break;
    case 1: console.log('One'); break;
    case 2: console.log('Two'); break;
    case 3: console.log('Three'); break;
    case 4: console.log('Four'); break;
    case 5: console.log('Five'); break;
    case 6: console.log('Six'); break;
    case 7: console.log('Seven'); break;
    case 8: console.log('Eight'); break;
    case 9: console.log('Nine'); break;
    default : console.log('Not a valid number'); break;
}

/* --------------- Task 6 ---------------- */
console.log('------------- Task 6 -------------');

a = 3;
b = 3;
c = -6;
var x1, x2, D;

console.log(a + 'x^2 + ' + b + 'x + ' + c + ' = 0');

if(a === 0){
    x = -c/b;
    console.log('x = ' + x);
}
else {
    D = b * b - 4 * a * c;

    x1 = (-b + Math.sqrt(D)) / (2 * a);
    x2 = (-b - Math.sqrt(D)) / (2 * a);

    console.log('x1 = ' + x1 + ' , x2 = ' + x2);
}

/* --------------- Task 7 ---------------- */
console.log('------------- Task 7 -------------');

a = 1;
b = 5;
c = 3;
d = 10;
e = 7;

console.log('a = ' + a + ' , b = ' + b + ' , c = ' + c + ' , d = ' + d + ' , e = ' + e);

if(a >= b && a >= c && a >= d && a >= e){
    console.log(a);
}
else if(b >= a && b >= c && b >= d && b >= e){
    console.log(b);
}
else if(c >= a && c >= b && c >= d && c >= e){
    console.log(c);
}
else if(d >= a && d >= b && d >= c && d >= e){
    console.log(d);
}
else if(e >= a && e >= b && e >= c && e >= d){
    console.log(e);
}


/* --------------- Task 8 ---------------- */
console.log('------------- Task 8 -------------');

var number = 167;

c = number % 10;
b = parseInt(number / 10) % 10;
a = parseInt(number / 100);

function printNumberAsWord(num1, num2, num3)
{
    var text = '';
    switch (num1)
    {
        case 0: text += ""; break;
        case 1: text += "One hundred "; break;
        case 2: text += "Two hundred "; break;
        case 3: text += "Three hundred "; break;
        case 4: text += "Four hundred "; break;
        case 5: text += "Five hundred "; break;
        case 6: text += "Six hundred )"; break;
        case 7: text += "Seven hundred "; break;
        case 8: text += "Eight hundred "; break;
        case 9: text += "Nine hundred "; break;
        default: console.log("Number should be in the range [0...999]"); break;
    }
    switch (num2)
    {
        case 0: text += "and "; break;
        case 2: text += "and  twenty "; break;
        case 3: text += "and thirty "; break;
        case 4: text += "and forty "; break;
        case 5: text += "and fifty "; break;
        case 6: text += "and sixty "; break;
        case 7: text += "and seventy "; break;
        case 8: text += "and eighty "; break;
        case 9: text += "and ninety "; break;
        default: console.log("Number should be in the range [0...999]"); break;
    }
    switch (num3)
    {
        case 0: text += ""; break;
        case 1: text += "one"; break;
        case 2: text += "two"; break;
        case 3: text += "three"; break;
        case 4: text += "four"; break;
        case 5: text += "five"; break;
        case 6: text += "six"; break;
        case 7: text += "seven"; break;
        case 8: text += "eight"; break;
        case 9: text += "nine"; break;
        case 10: text += "ten"; break;
        case 11: text += "eleven"; break;
        case 12: text += "twelve"; break;
        case 13: text += "thirteen"; break;
        case 14: text += "fourteen"; break;
        case 15: text += "fifteen"; break;
        case 16: text += "sixteen"; break;
        case 17: text += "seventeen"; break;
        case 18: text += "eighteen"; break;
        case 19: text += "nineteen"; break;
        default: console.log("Number should be in the range [0...999]"); break;
    }

    return text;
}
// if number's last numbers are not between 10 and 19 , use a,b,c as parameters
if (b != 1)
{
    console.log(printNumberAsWord(a, b, c));
}
// if number's last numbers are between 10 and 19 , use a , 0, c + 10 as parameters
// so we can print values properly
else
{
    console.log(printNumberAsWord(a, 0, c + 10));
}