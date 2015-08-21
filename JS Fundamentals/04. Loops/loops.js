/* --------------- Task 1 ---------------- */
console.log('------------- Task 1 -------------');

var n = 13,
    numbersToN = '',
    i;

console.log('n = ' + n);

for(i = 1; i <= n ; i += 1){
    numbersToN += i + ' ';
}

console.log(numbersToN);

/* --------------- Task 2 ---------------- */
console.log('------------- Task 2 -------------');

var numbersNotDivisibleBy3And7 = '';
n = 23;

console.log('n = ' + n);

for(i = 1; i <= n; i+=1){
    if((i % 21)){
        numbersNotDivisibleBy3And7 += i + ' ';
    }
}

console.log(numbersNotDivisibleBy3And7);

/* --------------- Task 3 ---------------- */
console.log('------------- Task 3 -------------');

var array = [5 , 7 ,1 ,3 ,11, 291, 4, 1, 41],
    sequence = '',
    max = array[0];

for(var num in array){
    sequence += array[num] + '   ';
    if(array[num] > max){
        max = array[num];
    }
}

console.log(sequence);
console.log('Max : ' + max);

/* --------------- Task 4 ---------------- */
console.log('------------- Task 4 -------------');

var smallest = 'zzzzzzzzzzzz',
    largest = '',
    prop;

for(prop in window) {
    if(prop < smallest){
        smallest = prop;
    }
    if(prop > largest){
        largest = prop;
    }
}

console.log('Window:');
console.log('Min: ' + smallest);
console.log('Max: ' + largest);

smallest = 'zzzzzzzzzzzz';
largest = '';

for(prop in navigator) {
    if(prop < smallest){
        smallest = prop;
    }
    if(prop > largest){
        largest = prop;
    }
}

console.log('Navigator:');
console.log('Min: ' + smallest);
console.log('Max: ' + largest);


smallest = 'zzzzzzzzzzzz';
largest = '';

for(prop in document) {
    if(prop < smallest){
        smallest = prop;
    }
    if(prop > largest){
        largest = prop;
    }
}

console.log('Document:');
console.log('Min: ' + smallest);
console.log('Max: ' + largest);