// Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

var buton = document.getElementById('print-nums-button');

buton.addEventListener('click', function () {
    var inputValue = document.getElementById('value').value;
    var resultArea = document.getElementById('result');
    for (var i = 1; i <= parseInt(inputValue) ; i += 1) {
        if (i % 7 != 0 && i % 3 != 0)
            resultArea.innerHTML += (i + ' ');
    }
})