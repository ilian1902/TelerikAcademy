// Write a function that reverses the digits of given decimal number.

var btn = document.getElementById('value');

function reverseDigit(number) {
    var reversed = '';
    for (var i = number.length - 1; i >= 0; i--) {
        reversed += number[i];
    }
    return reversed;
}
btn.addEventListener('click', function () {
    var inputValue = document.getElementById('printValue').value;
    var resultArea = document.getElementById('result');
    result.innerHTML = "Reversed digit is " + reverseDigit(inputValue)
})