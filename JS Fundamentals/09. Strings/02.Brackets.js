/* ----------- Problem 2 ----------- */
console.log('----------- Problem 2 -----------');

function checkBrackets(expression){
    var counter = 0,
        len = expression.length,
        i;

    for(i = 0; i < len; i += 1){
        if(expression[i] == '('){
            counter += 1;
        }
        else if(expression[i] == ')'){
            counter -= 1;
        }
    }

    return !counter;
}

var expression = '(5+c) / (3 + a)',
    msg = expression
        ?'The expression has correct brackets'
        :'The expression doesn\'t have correct brackets';

console.log(expression + ' -> ' + msg);