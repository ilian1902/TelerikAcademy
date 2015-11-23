// Write an if statement that takes two double variables a and b and exchanges their 
// values if the first one is greater than the second.
// As a result print the values a and b, separated by a space.

var a,
    b;

function exchangeGreater(a, b) {
    var result;
    if (a > b) {
        var result = b + ' ' + a;

    } else if (b > a) {
        result = a + ' ' + b;
    }
    return result;
}

console.log('If a = 5 and b = 2 result is = ' + exchangeGreater(5, 2));
console.log('If a = 3 and b = 4 result is = ' + exchangeGreater(3, 4));
console.log('If a = 5.5 and b = 4.5 result is = ' + exchangeGreater(5.5, 4.5));
console.log('If a = 3.5 and b = 6.5 result is = ' + exchangeGreater(3.5, 6.5));