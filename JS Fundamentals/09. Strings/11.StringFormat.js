/* ----------- Problem 11 ----------- */
console.log('----------- Problem 11 -----------');

    var result,
        str1 = format('{0}, {1}!', 'Hello', 'World');

    console.log('\'{0}, {1}!\', \'Hello\', \'World\'' + ' -> ' + str1);

function format(str) {

    var newArguments = arguments;
    return str.replace(/{(\d+)}/g, function(match, p1) {
        return newArguments[+p1 + 1];
    });
}
