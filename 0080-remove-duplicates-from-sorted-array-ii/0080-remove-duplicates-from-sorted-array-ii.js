/**
 * @param {number[]} nums
 * @return {number}
 */
var removeDuplicates = function(nums) {
    for(var i=0 ; i<nums.length;i++){
        if (nums[i]==nums[i+1]&&nums[i+1]==nums[i+2]&&nums[i]==nums[i+2]){
            nums.splice(i+2,1)
            i=i-2;

        }
    }
    return nums.length ;
};