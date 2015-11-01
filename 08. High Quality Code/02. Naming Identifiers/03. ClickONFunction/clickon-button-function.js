function clickONButton(event, parameters) {
    'use strict';
    var browserWindow = window,
        browserName = browserWindow.navigator.appCodeName,
        isMozilla = (browserName === "Mozilla");

    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}