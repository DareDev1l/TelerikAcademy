/* ----------- Problem 3 ----------- */
console.log('----------- Problem 3 -----------');

function wordInText(text, word){
    var count = 0,
        len = text.length,
        pos = text.indexOf(word),
        i;

    while(pos !== -1){
        count += 1;
        pos = text.indexOf(word, pos + 1);
    }

    return count;
}

var text =
    'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';

var word = 'in';

console.log(text + ' -> ' + word + ' : ' + wordInText(text,word));