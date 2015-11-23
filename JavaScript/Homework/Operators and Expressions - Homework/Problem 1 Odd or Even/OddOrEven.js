// Write an expression that checks if given integer is odd or even.

var num;
function isOdd(num) {
    return (num % 2 === 0) ? true : false;
}

for (var i = -5; i <= 5; i++) {
    console.log("Is " + i + " odd: " + isOdd(i));
}