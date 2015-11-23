// Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
// Print “not a digit” in case of invalid input.
// Use a switch statement.

var num;
function digitWord(num) {
    switch (num) {
        case 0: return 'zero';
            break;
        case 1: return 'one';
            break;
        case 2: return 'two';
            break;
        case 3: return 'tree';
            break;
        case 4: return 'four';
            break;
        case 5: return 'five';
            break;
        case 6: return 'six';
            break;
        case 7: return 'seven';
            break;
        case 8: return 'eight';
            break;
        case 9: return 'nine';
            break;
        default: return 'Not a digit';

    }
}
console.log('5 is ' + digitWord(5));
console.log('1 is ' + digitWord(1));
console.log('3 is ' + digitWord(3));
console.log('2 is ' + digitWord(2));
console.log('4 is ' + digitWord(4));
console.log('6 is ' + digitWord(6));
console.log('9 is ' + digitWord(9));
console.log('7 is ' + digitWord(7));
console.log('8 is ' + digitWord(8));
console.log('0 is ' + digitWord(0));
console.log('0.8 is ' + digitWord(0.8));
console.log('-2 is ' + digitWord(-2));
console.log('-2.5 is ' + digitWord(-2.5));
console.log('ABC is ' + digitWord('ABC'));