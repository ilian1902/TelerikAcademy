// Write an expression that checks for given integer if its third digit (right-to-left) is 7.

function checkThirdDigit(num) {
    var div = Math.floor(num / 100) % 10;
    return div === 7;
}

console.log("5: " + checkThirdDigit(5));
console.log("701: " + checkThirdDigit(701));
console.log("1732: " + checkThirdDigit(1732));
console.log("9703: " + checkThirdDigit(9703));
console.log("877: " + checkThirdDigit(877));
console.log("777877: " + checkThirdDigit(777877));
console.log("9999799: " + checkThirdDigit(9999799));