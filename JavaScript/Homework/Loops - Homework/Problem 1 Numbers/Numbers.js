// Write a script that prints all the numbers from 1 to N.

var numberInput = document.getElementById('print-nums-button');

numberInput.addEventListener('click', function () {
    var inputValue = document.getElementById('value').value;
    var resultArea = document.getElementById('result');
    for (var i = 1; i <= parseInt(inputValue) ; i += 1) {
        resultArea.innerHTML += (i + " ");
    }
})