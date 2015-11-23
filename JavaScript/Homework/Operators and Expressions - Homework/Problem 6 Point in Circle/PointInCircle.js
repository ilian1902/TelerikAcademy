﻿// Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius

var x,
    y,
    cx,
    cy,
    r;

function isInside(x, y, cx, cy, r) {
    return (x - cx) * (x - cx) + (y - cy) * (y - cy) < r * r;
}

console.log("is x = 1, y = 1 inside circle K(O, 5): " + isInside(1, 1, 0, 0, 5));
console.log("is x = 1.5, y = -1 inside circle K(O, 5): " + isInside(1.5, -1, 0, 0, 5));
console.log("is x = 100, y = -30 inside circle K(O, 5): " + isInside(100, -30, 0, 0, 5));
console.log("is x = 0.9, y = 1.93 inside circle K(O, 5): " + isInside(0.9, 1.93, 0, 0, 5));