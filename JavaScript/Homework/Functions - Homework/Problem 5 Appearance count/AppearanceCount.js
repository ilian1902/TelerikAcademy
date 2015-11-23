// Write a function that counts how many times given number appears in given array.
// Write a test function to check if the function is working correctly.

var btn = document.getElementById('print-nums-button');

function checkHowManyTimes(arr, digit) {
    var count = 0;
    for (var i = 0; i < arr.length; i+=1) {
        if (arr[i] === digit) {
            count+=1;
        }
    };
    return count;
}
btn.addEventListener('click', function () {
    var inputValue = document.getElementById('value').value;
    var givenDigit = document.getElementById('number').value;
    var resultArea = document.getElementById('result');
    var arrayOfDigits = inputValue.split(' ');
    var repeatedTimes = checkHowManyTimes(arrayOfDigits, givenDigit);
    result.innerHTML = "Digit " + givenDigit + " is repeated " + repeatedTimes + " times in the array " + arrayOfDigits;
})