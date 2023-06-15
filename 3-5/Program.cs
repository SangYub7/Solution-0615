class Solution
{
    public string solution(string phrases, int second)
    {

        string answer = "";

        second = second % 28;

        if (second <= 14)
        {
            answer += phrases.Substring(0, second);
            answer = answer.PadLeft(14 , '_');
        }
        else
        {
            answer += phrases.Substring(second-14);
            answer = answer.PadRight(14, '_');

        }

        

        return answer;
    }

    // 아래는 테스트케이스 출력을 해보기 위한 main 메소드입니다.
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        string phrases = new string("happy-birthday");
        int second = 3;
        string ret = sol.solution(phrases, second);
        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret + " 입니다.");

        ret = sol.solution(phrases, 14);
        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret + " 입니다.");

        ret = sol.solution(phrases, 20);
        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret + " 입니다.");

        ret = sol.solution(phrases, 28);
        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret + " 입니다.");

        ret = sol.solution(phrases, 29);
        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret + " 입니다.");
    }
}