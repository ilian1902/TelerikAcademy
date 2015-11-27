/* globals $ */

/* 
Create a function that takes an id or DOM element and an array of contents
* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

function solve () {

    return function (element, contents) {
        var tag,
            count = contents.length;

        if (typeof element === 'string') {
            tag = document.getElementById(element);
        } else if (element instanceof HTMLElement) {
            tag = element;
        } else {
            throw Error("The provided first parameter is neither string or existing DOM element");
        }

        if (!contents || contents.some(function (item) {
                return (typeof (item) !== 'string' && typeof (item) !== 'number');
        })) {
            throw '';
        }

        while (tag.lastChild) {
            tag.removeChild(tag.lastChild);
        }

        var newDiv = document.createElement('div');
        var docFragment = document.createDocumentFragment();

        for (var i = 0; i < count; i += 1) {
            var currentDiv = newDiv.cloneNode(true);
            currentDiv.innerHTML = contents[i];
            docFragment.appendChild(currentDiv);
        }
        tag.appendChild(docFragment);
    };
};