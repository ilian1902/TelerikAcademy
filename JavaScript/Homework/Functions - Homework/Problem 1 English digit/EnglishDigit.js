﻿// Write a function that returns the last digit of given integer as an English word.

var btn = document.getElementById('printNumber');

function returnLastDigit(number) {
    switch (number.toString()[number.length - 1] - '0') {
        case 0:
            return "zero";
            break;
        case 1:
            return "one";
            break;
        case 2:
            return "two";
            break;
        case 3:
            return "three";
            break;
        case 4:
            return "four";
            break;
        case 5:
            return "five";
            break;
        case 6:
            return "six";
            break;
        case 7:
            return "seven";
            break;
        case 8:
            return "eight";
            break;
        case 9:
            return "nine";
            break;
    }
}

btn.addEventListener('click', function () {
    var inputValue = document.getElementById('value').value;
    var resultArea = document.getElementById('result');
    result.innerHTML = "Last digit of value " + inputValue + " is " + returnLastDigit(inputValue)
})