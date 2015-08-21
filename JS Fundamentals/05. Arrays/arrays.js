/* --------- Problem 1 --------- */
console.log('--------- Problem 1 ---------');

var arr = new Array(20),
    i, j;

for(i = 0; i < arr.length; i += 1){
    arr[i] = i * 5;
}

console.log(arr);

/* --------- Problem 2 --------- */
console.log('--------- Problem 2 ---------');

arr = ['a','c','e'];
var arr2 = ['c', 'a', 'r'];

var firstWord  = arr.join('');
var secondWord = arr2.join('');

console.log(firstWord + '  <->  ' + secondWord);

if(firstWord < secondWord){
    console.log(firstWord + ' is lexicographically first');
} else {
    console.log(secondWord + ' is lexicographically first');
}


/* --------- Problem 3 --------- */
console.log('--------- Problem 3 ---------');

arr = [2, 1, 1, 2, 3, 3,2, 2, 2, 1];
console.log(arr);

var maxCount = 0,
    number,
    count;

for(i = 0; i < arr.length; i+= 1){
    count = 1;
    j = i;
    while(j+1 < arr.length &&  arr[j] == arr[j+1]){
        count++;
        j++;
    }
    if(count > maxCount){
        maxCount = count;
        number = arr[j-1];
    }
}

console.log(number + ' -> ' + maxCount + ' times');


/* --------- Problem 4 --------- */
console.log('--------- Problem 4 ---------');

arr = [3, 2, 3, 4, 2, 2, 4];
console.log(arr);

maxCount = 0;
number = 0;
count = 0;

for(i = 0; i < arr.length; i+= 1){
    count = 1;
    j = i;
    while(j+1 < arr.length &&  arr[j] + 1 == arr[j+1]){
        count++;
        j++;
    }
    if(count > maxCount){
        maxCount = count;
        number = arr[j-count+1];
    }
}

var output = '';

for(i = 0; i < maxCount ; i += 1){
    output += number + i + ' ';
}

console.log(output);

/* --------- Problem 5 --------- */
console.log('--------- Problem 5 ---------');

var temp;
arr = [6, 1, 5, 19, 3, 4, 8];
console.log(arr);

for(i = 0; i < arr.length - 1; i += 1){
    for(j = i+1; j < arr.length; j += 1){
        if(arr[j] < arr[i]){
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

console.log('Sorted -> ' + arr);

/* --------- Problem 6 --------- */
console.log('--------- Problem 6 ---------');

arr = [4, 1, 1, 4, 2, 3, 4 , 4 , 1, 2, 4 , 9, 3];
console.log(arr);

arr.sort(function (a,b) {
    return a-b;
});

maxCount = 0,
number = 0,
count = 0;

for(i = 0; i < arr.length; i+= 1){
    count = 1;
    j = i;
    while(j+1 < arr.length &&  arr[j] == arr[j+1]){
        count++;
        j++;
    }
    if(count > maxCount){
        maxCount = count;
        number = arr[j-1];
    }
}

console.log(number + ' -> ' + maxCount + ' times');


/* --------- Problem 7 --------- */
console.log('--------- Problem 7 ---------');

arr = [1 , 5, 18, 23, 44, 97, 150];
console.log(arr + '  -> Searched number : 44');

var left = 0,
    right = arr.length,
    searchedNum = 44,  // This is the number we are looking for
    mid = parseInt((left + right)/2);


while(left != right){
    if(arr[mid] == searchedNum){
        console.log('arr[' + mid + ']  ->  ' + arr[mid]);
        break;
    }
    else if(searchedNum < arr[mid]){
        right = mid;
    }
    else {
        left = mid;
    }
    mid = parseInt((left + right)/2);
}