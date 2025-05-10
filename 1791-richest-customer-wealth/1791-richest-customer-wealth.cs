public class Solution {
    public int MaximumWealth(int[][] accounts) {
       int maxwealth=0 ;
       for (int i=0 ; i < accounts.Length ;i++){
        int customerWealth=0;
        for(int j=0 ; j<accounts[i].Length;j++){
         customerWealth += accounts[i][j];
            
        }
        maxwealth=Math.Max(maxwealth,customerWealth);
       }
       return maxwealth;

        
    
    }
}