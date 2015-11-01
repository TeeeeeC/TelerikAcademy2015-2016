function solve() {
    return function (selector, items) {
        var root = document.querySelector(selector);

        var imagePreviewer = document.createElement('div');
        imagePreviewer.style.width = '70%';
        imagePreviewer.style.cssFloat = 'left';
        imagePreviewer.style.display = 'inline-block';
        imagePreviewer.style.textAlign = 'center';

        var selectedParent = document.createElement('div');
        selectedParent.className = 'image-preview';
        var selectedImageHeader = document.createElement('h1');
        var selectedImage = document.createElement('img');

        selectedImageHeader.textContent = items[0].title;
        selectedImage.src = items[0].url;
        selectedImage.style.width = '70%';
        selectedImageHeader.parentNode = imagePreviewer;
        selectedImage.parentNode = imagePreviewer;
        selectedParent.appendChild(selectedImageHeader);
        selectedParent.appendChild(selectedImage);
        imagePreviewer.appendChild(selectedParent);

        var aside = document.createElement('div');
        aside.style.textAlign = 'center';
        aside.style.display = 'inline-block';
        aside.style.width = '25%';
        aside.style.height = '600px';
        aside.style.overflowY = 'scroll';

        var inputHeader = document.createElement('h3');
        var input = document.createElement('input');
        inputHeader.innerText = 'Filter';
        inputHeader.style.textAlign = 'center';
        input.style.textAlign = 'center';
        input.addEventListener('keyup', function (ev) {
            var target = ev.target.value;
            var liChildren = document.getElementsByTagName('li');
            for (var i = 0, len = items.length; i < len; i += 1) {
                var currLi = liChildren[i];
                var header = currLi.firstElementChild.innerText;
                if (header.toLowerCase().indexOf(target.toLowerCase()) < 0) {
                    currLi.style.display = 'none';
                }
                else {
                    currLi.style.display = '';
                }
            }
        }, false);

        var listOfItems = document.createElement('ul');
        listOfItems.style.listStyleType = 'none';
        var li = document.createElement('li');
        li.className = 'image-container';
        var imageHeader = document.createElement('h3');
        var image = document.createElement('img');
        imageHeader.parentNode = li;
        image.parentNode = li;
        image.style.width = '80%';
        for (var i = 0, len = items.length; i < len; i += 1) {
            var currItem = items[i];
            var currLi = li.cloneNode(true);
            var currImageHeader = imageHeader.cloneNode(true);
            var currImage = image.cloneNode(true);

            currImageHeader.textContent = currItem.title;
            currImage.src = currItem.url;

            currLi.appendChild(currImageHeader);
            currLi.appendChild(currImage);
            listOfItems.appendChild(currLi);
        }

        listOfItems.addEventListener('click', function (ev) {
            var target = ev.target;
            if (target.tagName === 'IMG') {
                selectedImageHeader.innerText = target.previousElementSibling.innerText;
                selectedImage.src = target.src;
            }
        }, false);

        listOfItems.addEventListener('mouseover', function (ev) {
            var target = ev.target;
            if (target.tagName === 'IMG') {
                target.parentElement.style.backgroundColor = 'gray';
            }
        }, false);

        listOfItems.addEventListener('mouseout', function (ev) {
            var target = ev.target;
            if (target.tagName === 'IMG') {
                target.parentElement.style.backgroundColor = '';
                target.parentElement.style.cursor = 'pointer';
            }
        }, false);

        aside.appendChild(inputHeader);
        aside.appendChild(input);
        aside.appendChild(listOfItems);

        root.appendChild(imagePreviewer);
        root.appendChild(aside);
    }
}

module.exports = solve;