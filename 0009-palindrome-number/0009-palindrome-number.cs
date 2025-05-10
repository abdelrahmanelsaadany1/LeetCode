public class Solution {
    public bool IsPalindrome(int x) {
        int reversednum=0;
        int originalX = x;
        
        if(x==0 ){

            return true ;
        }
        else if(x<0){
            return false ;
        }
        else {
            while (x>0)
            {
                int digit =x%10;
                reversednum=reversednum*10+digit;
                x = x / 10;
                



            }
            return originalX==reversednum;




        }
        
        
    }
}