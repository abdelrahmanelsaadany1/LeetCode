public class Solution {
    public int FindNumbers(int[] nums) {
        int sum=0;
        foreach (int i in nums)
        {
            if(i.ToString().Length%2==0){
                sum++;


            }
           
            


        }
         return sum;
        
        
    }
}