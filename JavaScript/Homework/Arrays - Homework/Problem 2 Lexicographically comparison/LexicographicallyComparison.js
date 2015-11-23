// Write a script that compares two char arrays lexicographically (letter by letter).

var firstArray,
    secondArray,
    i,
    len,
    isCharEquals,
    arrEqualsChar = [];

firstArray = ['p', 'e', 's', 'h', 'o'];
secondArray = ['g', 'o', 's', 'h', 'o'];
isCharEquals = true;

if (firstArray.length === secondArray.length) {

    for (i = 0, len = firstArray.length; i < len; i += 1) {

        if (firstArray[i] === secondArray[i]) {

            arrEqualsChar[i] = firstArray[i];
            isCharEquals = true;

        } else {
            isCharEquals = false;
        }
    }

} else {
    isCharEquals = false;
}

console.log(arrEqualsChar);
console.log(isCharEquals);