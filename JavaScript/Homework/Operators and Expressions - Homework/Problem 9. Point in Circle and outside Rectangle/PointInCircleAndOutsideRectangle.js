// Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

var x,
    y,
    cx,
    cy,
    r,
    top,
    bottom,
    left,
    right;

function isInsideCircle(x, y, cx, cy, r) {
    return (x - cx) * (x - cx) + (y - cy) * (y - cy) < r * r;
}

function isOutsideRectangle(x, y, top, bottom, left, right) {
    return !(x >= left && x <= right && y <= top && y >= bottom);
}

console.log("is x = 1, y = 2 inside circle K(1, 1) and inside rectangle R(1, -1, 6, 2): " + isInsideCircle(1, 2, 1, 1, 3) && isOutsideRectangle(1, -1, 6, 2));
console.log("is x = -100, y = -100 inside circle K(1, 1) and inside rectangle R(1, -1, 6, 2): " + isInsideCircle(-100, -100, 1, 1, 3) && isOutsideRectangle(1, -1, 6, 2));
console.log("is x = 1, y = 2.5 inside circle K(1, 1) and inside rectangle R(1, -1, 6, 2): " + isInsideCircle(1, 2.5, 1, 1, 3) && isOutsideRectangle(1, -1, 6, 2));