// Write an expression that calculates rectangle’s area by given width and height.

var width;
var height;

function calRectangleArea(width, height) {
    var area = width * height;
    return area;
}

console.log("width = 3, height = 4), Area: " + calRectangleArea(3, 4));
console.log("width = 2.5, height = 3), Area: " + calRectangleArea(2.5, 3));
console.log("width = 5, height = 5), Area: " + calRectangleArea(5, 5));