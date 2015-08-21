/* -------------- Problem 1 -------------- */
console.log('-------------- Problem 1 --------------');

var num = 418;

function LastDigitAsWord(number){
    number = +number;

    switch(number % 10){
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
        default: console.log('Invalid digit');
    }
}
console.log(num);
LastDigitAsWord(num);


/* -------------- Problem 2 -------------- */
console.log('-------------- Problem 2 --------------');

num = 2583;

function ReverseNumber(number){
    var numStr = '';

    while(number !== 0){
        numStr += number % 10;
        number = parseInt(number/10);
    }

    return numStr;
}

console.log(num + ' -> ' + ReverseNumber(num));

/* -------------- Problem 3 -------------- */
console.log('-------------- Problem 3 --------------');

function OccurancesOfWord(text, word){
    var count = 0;
    var pos = text.indexOf(word);

    while(pos !== -1){
        count += 1;
        pos = text.indexOf(word, pos + 1);
    }

    return count;
}

var text = 'I live in Bulgaria. Bulgaria is a nice country. I <3 Bulgaria !';
var word = 'Bulgaria';

console.log('\'' + text + '\'');
console.log(word + ' -> ' + OccurancesOfWord(text, word) + ' times');


/* -------------- Problem 4 -------------- */
console.log('-------------- Problem 4 --------------');

function countDivs(html){
    var count = 0;
    var pos = html.indexOf('<div>');

    while(pos !== -1){
        count += 1;
        pos = html.indexOf('<div>', pos + 1);
    }

    return count;
}

var html = '<div> Div 1 </div>  <div> Div 2 </div>'; // 2 div elements
console.log(html);
console.log('Divs -> ' + countDivs(html));


/* -------------- Problem 5 -------------- */
console.log('-------------- Problem 5 --------------');

function numberOccurancesInArr(arr, number){
    var count = 0,
        i;

    for(i = 0; i < arr.length; i += 1){
        if(arr[i] == number){
            count += 1;
        }
    }

    return count;
}

var arr = [1 , 1, 1, 2, 3, 4, 5];

console.log(arr);
console.log('1 -> ' + numberOccurancesInArr(arr, 1) + ' times');


/* -------------- Problem 6 -------------- */
console.log('-------------- Problem 6 --------------');

function biggerThanNeighbours(arr, pos){
    if(arr[pos] > arr[pos-1] && arr[pos] > arr[pos+1]){
        return true;
    }
    return false;
}

arr = [1, 2, 3 ,5 , 4, 8, 6];

console.log(arr);
console.log('arr[3] is bigger than neighbours : ' + biggerThanNeighbours(arr, 3));


/* -------------- Problem 7 -------------- */
console.log('-------------- Problem 7 --------------');

function firstBiggerThanNeighbours(arr){
    var i;

    for(i = 1; i < arr.length - 1; i += 1){
        if(biggerThanNeighbours(arr, i)){
            return i;
        }
    }

    return -1;
}

console.log(arr);
console.log('Index of first element bigger than its neighbours : ' + firstBiggerThanNeighbours(arr));