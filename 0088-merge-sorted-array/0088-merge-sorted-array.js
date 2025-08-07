/**
 * @param {number[]} nums1
 * @param {number} m
 * @param {number[]} nums2
 * @param {number} n
 * @return {void} Do not return anything, modify nums1 in-place instead.
 */
var merge = function(nums1, m, nums2, n) {
    var arr=[];
    for(i=0;i<m;i++){
        
            arr.push(nums1[i])
        
        

    }

            var mergedArray = arr.concat(nums2); 
        
         
         mergedArray.sort((a, b) => a - b)
         for(i=0;i<mergedArray.length;i++){
       
            nums1[i] = mergedArray[i];
        }
     
   
};