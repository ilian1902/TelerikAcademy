// Write a script that finds the biggest of three numbers.
// Use nested if statements.

var a,
    b,
    c;

function theBiggest(a, b, c) {
    if (a>b && a>c) {
        return a;
    } else if (b > a && b > c) {
        return b;
    } else {
        return c;
    }
}

console.log('If a = 5 and b = 2 and c = 2 The Biggest is = ' + theBiggest(5, 2, 2));
console.log('If a = -2 and b = -2 and c = 1 The Biggest is = ' + theBiggest(-2, -2, 1));
console.log('If a = -2 and b = 4 and c = 3 The Biggest is = ' + theBiggest(-2, 4, 3));
console.log('If a = 0 and b = -2.5 and c = 5 The Biggest is = ' + theBiggest(0, -2.5, 5));
console.log('If a = -0.1 and b = -0.5 and c = -1.1 The Biggest is = ' + theBiggest(-0.1, -0.5, -1.1));
