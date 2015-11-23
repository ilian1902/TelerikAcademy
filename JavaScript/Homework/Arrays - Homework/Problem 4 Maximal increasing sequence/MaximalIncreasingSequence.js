// Write a script that finds the maximal increasing sequence in an array.

var i,
    len,
    arr = [3, 2, 3, 4, 2, 2, 4],
    bestSeq = 1,
    currSeq = 1,
    bestNum = '',
    currNum = '';

for (i = 0, len = arr.length; i < len - 1; i+=1) {
    if (arr[i] < arr[i + 1]) {
        currSeq++;
        currNum = currNum + arr[i] + ' ';
    } else {
        if (currSeq >= bestSeq) {
            bestSeq = currSeq;
            currNum = currNum + arr[i] + ' ';
            bestNum = currNum;
        }
        currSeq = 1;
        currNum = '';
    }
}
if (currSeq >= bestSeq) {
    currNum += arr[arr.length - 1];
    bestNum = currNum;
}

console.log("Maximal increasing sequance is: " + bestNum);