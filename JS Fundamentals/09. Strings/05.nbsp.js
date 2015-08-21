/* ----------- Problem 5 ----------- */
console.log('----------- Problem 5 -----------');

function removeWhiteSpaces(text){
    return text.split(' ').join('&nbsp');
}

var text = 'This is some text.';

console.log(text + ' -> ' + removeWhiteSpaces(text));