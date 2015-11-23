// Write a script that finds the maximal sequence of equal elements in an array.

var arr,
    arrSequence,
    i,
    len,
    count =1,
    bestSquence = 1,
    num = 0;

arr = [2, 3, 5, 6, 2, 2, 2, 2, 1];
arrSequence = [];

for (i = 1, len = arr.length-1; i <= len; i+=1) {
    if (arr[i] === arr[i-1]) {
        count += 1;
    } else {
        count = 1;
    }
    if(count >= bestSquence){
        bestSquence = count;
        num = arr[i];
    }
}

for (i = 0; i < bestSquence; i+=1) {
    arrSequence[i] = num;
}
console.log(arrSequence);