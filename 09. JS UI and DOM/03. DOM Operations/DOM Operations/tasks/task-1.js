module.exports = function () {
    return function (element, contents) {
        var elementAsString = document.getElementById(element),
            divELement = document.createElement('div'),
            dFrag = document.createDocumentFragment(),
            length = contents.length,
            result = '';

        if (typeof elementAsString != 'string' && element == undefined) {
            throw new Error('The element id must be string value!');
        }

        if (contents == undefined) {
            throw new Error('The contents id or tag doesn\'t exist!');
        }

        for (var i = 0; i < length; i += 1) {
            if (typeof contents[i] != 'string' && typeof contents[i] != 'number') {
                throw new Error('The contents must be string or number!');
            }
        }

        result = elementAsString != null ? elementAsString : element;
        result.innerHTML = '';
 
        for (var i = 0; i < length; i += 1) {
            var currDiv = divELement.cloneNode(true);
            currDiv.textContent = contents[i];
            dFrag.appendChild(currDiv);
        }

        result.appendChild(dFrag);

        return result;
    }
}
