// Write a script that finds the most frequent number in an array.

var i,
    len,
    arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    count = 1,
    maxCount = 1,
    countedNum = 0;

arr.sort(function (a, b) {
    return a - b;
});

for (i = 0, len = arr.length; i < len - 1; i+=1) {
    if (arr[i] == arr[i + 1]) {
        count++;
    } else {
        count = 1;
    }
    if (count >= maxCount) {
        maxCount = count;
        countedNum = arr[i];
    }
}
if (maxCount > 1) {
    console.log('Most frequant number is ' + countedNum + ' and it is counted ' + maxCount + ' times.');
} else {
    console.log('No frequancy!');
}