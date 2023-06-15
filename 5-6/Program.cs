class Solution
{

    public int ConvertBase(string str, int fromBase)
    {

        int digit = 0;
        int answer = 0;
        for (int i = str.Length - 1 ; i >=0; i--)
        {
            int num = str[i] - '0';

            answer +=  num * (int)Math.Pow(fromBase, digit);
            digit++;

        }

        return answer;
    }

    public string ConvertBase(int n, int fromBase)
    {

        string answer = "";
        
        while ( n > 0)
        {
            answer = (n % fromBase).ToString() + answer;
            n /= fromBase;
        }

        return answer;
    }


    public string solution(string s1, string s2, int p, int q)
    {
         string answer = "";

        // p진법을 => 10진법으로.

        int s1Num = ConvertBase(s1, p);
        int s2Num = ConvertBase(s2, p);

        answer = ConvertBase(s1Num + s2Num, q);

        return answer;
    }

    // 아래는 테스트케이스 출력을 해보기 위한 main 메소드입니다.	
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        string s1 = new string("112001");
        string s2 = new string("12010");
        int p = 3;
        int q = 8;
        string ret = sol.solution(s1, s2, p, q);

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret + " 입니다.");
    }
}