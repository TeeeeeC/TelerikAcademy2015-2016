function createCalendar(selector, events) {
    var container = document.getElementById(selector),
        tableElement = document.createElement('table'),
        tableRowElementHeader = document.createElement('tr'),
        tableRowElementEvent = document.createElement('tr'),
        tableColumnElement = document.createElement('td'),
        daysCount = 1,
        row,
        column,
        ROWS = 10,
        COLUMNS = 7,
        DAY_OF_WEEK = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

    events.forEach(function (event) {
        if (typeof event.title != 'string') {
            throw new Error();
        }

        if (typeof event.date != 'number' || event.date < 1 || event.date > 30) {
            throw new Error();
        }

        if (typeof event.time != 'string') {
            throw new Error();
        }

        if (typeof event.duration != 'number' || event.duration < 1 || event.date > 1440) {
            throw new Error();
        }
    }) 

    tableColumnElement.style.border = '2px solid grey';
    tableRowElementHeader.setAttribute('align', 'center');
    tableRowElementHeader.style.background = '#cccccc';
    tableRowElementEvent.style.height = '120px';
    for (row = 0; row < ROWS; row += 1) {
        var tableRowElementHeaderCloned = tableRowElementHeader.cloneNode(true),
            tableRowElementEventCloned = tableRowElementEvent.cloneNode(true);
        for (column = 0; column < COLUMNS; column += 1) {
            var tableColumnElementCloned = tableColumnElement.cloneNode(true);
            if (row % 2 == 0) {
                tableColumnElementCloned.textContent = DAY_OF_WEEK[column] + ' ' + (daysCount++) + ' June 2014';
                tableRowElementHeaderCloned.appendChild(tableColumnElementCloned);
            }
            else {
                tableColumnElementCloned.textContent = '';
                tableRowElementEventCloned.appendChild(tableColumnElementCloned);
            }
            

            if (daysCount == 31 || (column == 1 && row == ROWS - 1)) {
                daysCount--;
                break;
            }
        }
        if (row % 2 == 0) {
            tableElement.appendChild(tableRowElementHeaderCloned);
        }
        else {
            tableElement.appendChild(tableRowElementEventCloned);
        }
    }
    var allRows = tableElement.getElementsByTagName('tr');
    
    for (var i = 0, length = allRows.length; i < length; i += 1) {
        if (i % 2 == 0) {
            allRows[i].setAttribute('class', 'headers');
        }
        else {
            allRows[i].setAttribute('class', 'events');
        }
    }

    tableElement.width = '1000px';
    tableElement.height = '800px';
    tableElement.cellPadding = '0px';
    tableElement.cellSpacing = '0px';
    tableElement.setAttribute('align', 'left');
    tableElement.style.marginLeft = '50px';
    container.appendChild(tableElement);
};

var events = [{
    title: '22 Exam',
    date: '22',
    hour: '10:00',
    duration: '60'
}, {
    title: '9 Exam',
    date: '9',
    hour: '10:00',
    duration: '60'
}];

createCalendar('calendar-container', events);