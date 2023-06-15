class Solution
{
    public bool isZero(long n)
    {
        while( n > 0)
        {
            if (n % 10 == 0)
                return true;
            n /= 10;
        }
        return false; 
    }

    public long solution(long num)
    {        
        long answer = 0;

        long next = num + 1;
 
        while(next > 0)
        {
            if(next % 10 == 0)
            {
                answer = answer * 10 + 1;
            }else
                answer = answer * 10 + (next % 10);

            next /= 10;
        }


 
        return answer;
    }

    // The following is main method to output testcase.
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        long num = 9949999;
        num = 999999999999;
        long ret = sol.solution(num);

        // Press Run button to receive output. 
        Console.WriteLine("Solution: return value of the method is " + ret + " .");
    }
}