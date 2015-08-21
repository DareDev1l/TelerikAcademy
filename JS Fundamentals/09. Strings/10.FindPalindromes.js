/* ----------- Problem 10 ----------- */
console.log('----------- Problem 10 -----------');

function findPalindromes(text){
    text = text.split(' ');

    var palindromes = [],
        len = text.length,
        isPalindrome = true,
        i, j;

    for(i = 0; i < len; i += 1){
        for (j = 0; j < text[i].length; j += 1) {
            if (text[i][j] != text[i][text[i].length - j - 1]) {
                isPalindrome = false;
                break;
            }
        }

        if(isPalindrome && text[i].length > 1){
            palindromes.push(text[i]);
        }

        isPalindrome = true;
    }

    return palindromes;
}

var text = 'ABBA is a palindrome. exe is short for executable. I do not know what lamal means';

console.log(text + ' -> ' + findPalindromes(text));