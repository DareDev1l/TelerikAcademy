/* ----------- Problem 8 ----------- */
console.log('----------- Problem 8 -----------');

function replaceTags(html){
    html = html.replace(/<a href/g, '[URL');
    html = html.replace(/<\/a>/g, '[/URL]');

    var pos = html.indexOf('[URL'),
        tempPos;

    while(pos != -1){
        tempPos = html.indexOf('>');
        html = html.substr(0, tempPos) + ']' + html.substr(tempPos + 1);

        pos = html.indexOf('[URL' , pos + 1);
    }

    return html;
}

var html = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

console.log(replaceTags(html));