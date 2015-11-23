// Sorting an array means to arrange its elements in increasing order.
// Write a script to sort an array.
// Use the selection sort algorithm: Find the smallest element, move it at the first position, 
// find the smallest from the rest, move it at the second position, etc.


var i,
    j,
    len,
    temp,
    min,
    arr = [1, 3, 66, 40, 21, 25, 4, 60, 33, 28, 44];

for (i = 0, len = arr.length; i < len - 1; i+=1) {

    min = i;
    for (j = i + 1, len = arr.length; j < len; j+=1) {
        if (arr[j] < arr[min]) {
            min = j;
        }
    }
    temp = arr[i];
    arr[i] = arr[min];
    arr[min] = temp;
}
for (i = 0, len = arr.length; i < len; i+=1) {
    console.log(arr[i] + ' ');
}