/* ----------- Problem 6 ----------- */
console.log('----------- Problem 6 -----------');

function extractText(html){
    var startPos = html.indexOf('>'),
        endPos = html.indexOf('<', 1),
        text = '',
        i;

    while(startPos != -1){
        for(i = startPos + 1; i < endPos; i += 1){
            text += html[i];
        }

        startPos = html.indexOf('>', startPos + 1);
        endPos = html.indexOf('<', endPos + 1);
    }

    return text;
}

var html = '<html><head><title>Sample site</title> </head> <body><div>text <div>more text</div> and more... </div>in body </body> </html>';

console.log(html);
console.log(extractText(html));