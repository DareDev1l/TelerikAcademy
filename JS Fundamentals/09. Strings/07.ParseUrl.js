/* ----------- Problem 6 ----------- */
console.log('----------- Problem 6 -----------');

function parseUrl(url){
    var obj = {};

    var serverStart = url.indexOf('/') + 2,
        serverEnd = url.indexOf('/', serverStart);

    obj.protocol = url.substr(0, url.indexOf(':'));
    obj.server = url.substring(serverStart, serverEnd);
    obj.resource = url.substr(serverEnd);

    return obj;
}

var url = 'http://telerikacademy.com/Courses/Courses/Details/239';

console.log(parseUrl(url));
