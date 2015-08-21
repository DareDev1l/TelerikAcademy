/* ----------- Problem 12 ----------- */
console.log('----------- Problem 12 -----------');

function generateList(people, template) {
    var prop,
        i,
        len,
        liContent,
        props = [],
        peopleList = [];

    peopleList.push('<ul><strong>-\{name\}-</strong><span>-\{age\}-</span >');

    for (prop in people[0]) {
        props.push(prop);
    }

    for (i = 0, len = people.length; i < len; i += 1) {
        peopleList.push('<li>');
        liContent = template;

        for (prop in people[0]) {
            liContent = liContent.replace(new RegExp(
                '\\-{' + prop + '\\}-', "g"), people[i][prop]);
        }

        peopleList.push(liContent);
        peopleList.push('</li>');
    }

    peopleList.push('</ul>');

    return peopleList.join('');
}

var people = [{
    name: 'Georgi',
    age: 35
}, {
    name: 'Ivan',
    age: 15
}, {
    name: 'Stoqn',
    age: 33
}],
    template = '<div data-type="template" id="list-item"><strong>-{name}-</strong><span>-{age}-</span></div>';
    peopleList = generateList(people, template);

console.log(peopleList);