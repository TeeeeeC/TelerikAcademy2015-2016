function solve() {
    return function (selector) {
        var selectorAsString = document.getElementById(selector),
            resultSelector = '',
            i,
            length,
            buttonCollection;

        if (selector == undefined || selector == null || selectorAsString == null) {
            throw new Error('The selector is undefined or null!');
        }

        resultSelector = selectorAsString != null ? selectorAsString : selector;

        buttonCollection = document.getElementsByClassName('button');
        for (i = 0, length = buttonCollection.length; i < length; i += 1) {
            buttonCollection[i].innerHTML = 'hide';
        }

        resultSelector.addEventListener('click', function (element) {
            if (element.target.className == 'button') {
                var target = element.target,
                    next = target;

                while (next) {
                    if (next.className === 'content') {
                        break;
                    }

                    next = next.nextElementSibling;
                }

                if (next.style.display == '') {
                    target.innerHTML = 'show';
                    next.style.display = 'none';
                }
                else if (next.style.display == 'none') {
                    target.innerHTML = 'hide';
                    next.style.display = '';
                }
            }
        }, false);
    }
}

module.exports = solve;







