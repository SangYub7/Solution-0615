class Solution
{
    public int solution(string s1, string s2)
    {
        int answer = s1.Length + s2.Length;

        for(int i = 1; i < s1.Length; i++)
        {
            string pre = s1.Substring( s1.Length - i , i);
            if (s2.StartsWith(pre))
                answer =  s1.Length + s2.Length - i;
        }

        return answer;
    }

    // 아래는 테스트케이스 출력을 해보기 위한 main 메소드입니다.
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        string s1 = new string("ababc");
        string s2 = new string("abcdab");
        int ret = sol.solution(s1, s2);

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret + " 입니다.");
    }
}