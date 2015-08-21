/* ----------- Problem 9 ----------- */
console.log('----------- Problem 9 -----------');

function extractEmails(text){
    text = text.split(' ');

    var emails = [],
        len = text.length,
        i;

    for(i = 0 ; i < len; i += 1){
        if(text[i].indexOf('@') > -1){
            emails.push(text[i]);
        }
    }

    return emails;
}

var text = 'You can write us on support@email.com or question@company.com';

console.log(text + ' -> ' + extractEmails(text));