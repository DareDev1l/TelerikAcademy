/* ----------- Problem 1 ----------- */
console.log('----------- Problem 1 -----------');

function reverse(str) {
    var reversed = '',
        len = str.length,
        i;

    for(i = 0; i < len; i += 1){
        reversed = str[i] + reversed;
    }

    return reversed;
}

var str = 'sample';
var reversed = reverse(str);

console.log(str + ' -> ' + reversed);
