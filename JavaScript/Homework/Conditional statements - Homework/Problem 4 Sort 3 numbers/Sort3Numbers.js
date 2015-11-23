// Sort 3 real values in descending order.
// Use nested if statements.
//    Note: Don’t use arrays and the built-in sorting functionality.

var testNums = {a: 9, b: 20, c: 2};
var a = testNums.a, b = testNums.b, c = testNums.c;
var temp;

console.log(testNums);

if(a >= b){
    if(c > a){
        testNums.a = c;
        testNums.b = a;
        testNums.c = b;
    } else {
        testNums.a = a;
        testNums.b = c;
        testNums.c = b;
    }
} else {
    if(b >= c){
        if(c >= a){
            testNums.a = b;
            testNums.b = c;
            testNums.c = a;
        } else {
            testNums.a = b;
            testNums.b = a;
            testNums.c = c;
        }
    } else {
        testNums.a = c;
        testNums.b = b;
        testNums.c = a;
    }
}

console.log(testNums);