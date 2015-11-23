// Write a script that finds the greatest of given 5 variables.
// Use nested if statements.

var nums = [1, 50, 9, 0, 166];
var max = nums[0];

for (var i = 1; i < nums.length; i++) {
    if (nums[i] > max) {
        max = nums[i];
    }
}

console.log(nums);
console.log('The biggest is '+ max);