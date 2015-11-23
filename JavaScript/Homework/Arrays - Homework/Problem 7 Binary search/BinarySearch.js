// Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.


var mid,
    arr = [3, 1, 5, 12, 4, 8, 2],
    search = 4,
    first = 0,
    last = arr.length - 1;

arr.sort(function (a, b) {
    return a - b;
});

while (last >= first) {
    mid = parseInt((first + last) / 2);
    if (arr[mid] < search) {
        first = mid + 1;
    } else if (arr[mid] > search) {
        last = mid - 1;
    } else {
        console.log('Search = '+ search + ' index = '+ mid);
        break;
    }
}
console.log(arr);