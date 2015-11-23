// Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.

var number = 698;
hundreds = (Math.floor(number / 100)),
tenths = ((Math.floor(number / 10)) % 10),
ones = (number % 10),
teens = (ones + 10);
        //result;

switch (hundreds) {
    case 1: hundreds = 'one hundred '; break;
    case 2: hundreds = 'two hundred '; break;
    case 3: hundreds = 'three hundred '; break;
    case 4: hundreds = 'four hundred '; break;
    case 5: hundreds = 'five hundred '; break;
    case 6: hundreds = 'six hundred '; break;
    case 7: hundreds = 'seven hundred '; break;
    case 8: hundreds = 'eight hundred '; break;
    case 9: hundreds = 'nine hundred '; break;
}

switch (tenths) {
    case 0: tenths = ''; break;
    case 1: tenths = 'ten'; break;
    case 2: tenths = 'twenty '; break;
    case 3: tenths = 'thirty '; break;
    case 4: tenths = 'fourty '; break;
    case 5: tenths = 'fifty '; break;
    case 6: tenths = 'sixty '; break;
    case 7: tenths = 'seventy '; break;
    case 8: tenths = 'eighty '; break;
    case 9: tenths = 'ninety '; break;
}

switch (teens) {
    case 11: teens = 'eleven'; break;
    case 12: teens = 'twelve'; break;
    case 13: teens = 'thirteen'; break;
    case 14: teens = 'fourteen'; break;
    case 15: teens = 'fifteen'; break;
    case 16: teens = 'sixteen'; break;
    case 17: teens = 'seventeen'; break;
    case 18: teens = 'eighteen'; break;
    case 19: teens = 'nineteen'; break;
}

switch (ones) {
    case 0: ones = ''; break;
    case 1: ones = 'one'; break;
    case 2: ones = 'two'; break;
    case 3: ones = 'three'; break;
    case 4: ones = 'four'; break;
    case 5: ones = 'five'; break;
    case 6: ones = 'six'; break;
    case 7: ones = 'seven'; break;
    case 8: ones = 'eight'; break;
    case 9: ones = 'nine'; break;
    case 10: ones = 'ten'; break;

}
var result = '';
if (number == 0) {
    result = 'zero';
}
if (number <= 9 && number > 0) {
    result = ones;
}
if (number > 10 && number <= 19) {
    result = teens;
}
if (number == 10) {
    result = tenths;
}
if (number >= 20 && number <= 99) {
    result = tenths + ones;
}
if (number >= 100 && number <= 999) {
    result = hundreds + 'and ' + tenths + ones;
}
consile.log(result);