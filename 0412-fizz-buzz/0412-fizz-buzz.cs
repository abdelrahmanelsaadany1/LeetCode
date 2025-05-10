public class Solution {
    public IList<string> FizzBuzz(int n) {
        int i;
        string [] answer  =new string [n];
        for(i=1;i<=n;i++){
            if(i%3==0 && i%5 ==0)
            {
                answer[i-1]="FizzBuzz";
            }
            else if (i%3==0 && i%5 !=0)
            {
                answer[i-1]="Fizz";

            }
             else if (i%3!=0 && i%5 ==0)
            {
                answer[i-1]="Buzz";

            }
            else{
                 answer[i-1]=i.ToString();
            }
        }
        return answer.ToList();

        
    }
}