/**
 * @param {number[]} nums
 * @return {number}
 */
var majorityElement = function(nums) {
  var candidate;
  var count = 0;

  for (var i = 0; i < nums.length; i++) {
    if (count === 0) {
      candidate = nums[i];
    }
    count += (nums[i] === candidate) ? 1 : -1;
  }

  return candidate;
};


   


  