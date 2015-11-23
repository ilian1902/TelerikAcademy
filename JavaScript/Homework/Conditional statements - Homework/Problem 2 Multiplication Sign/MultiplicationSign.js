// Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.

var testNums1 = { a: 5, b: 2, c: 2 },
			testNums2 = { a: -2, b: -2, c: 1 },
			testNums3 = { a: -2, b: 4, c: 3 },
			testNums4 = { a: 0, b: 1, c: 1 };

console.log(testNums1, getMultiplicationSign(testNums1));
console.log(testNums2, getMultiplicationSign(testNums2));
console.log(testNums3, getMultiplicationSign(testNums3));
console.log(testNums4, getMultiplicationSign(testNums4));

function getMultiplicationSign(nums) {
    var result = nums.a * nums.b * nums.c;
    if (result > 0) {
        return "+";
    } else if (result < 0) {
        return "-";
    } else {
        return "0";
    }
}