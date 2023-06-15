 class Solution
{
    public int[] solution(string commands)
    {
        int x = 0;
        int y = 0;

        for(int i = 0; i < commands.Length; i++)
        {
            if (commands[i] == 'U')
                y++;
            if (commands[i] == 'R')
                x++;
            if (commands[i] == 'D')
                y--;
            if (commands[i] == 'L')
                x--;
        }


        int[] answer = new int[]{x,y};
        return answer;
    }

    // 아래는 테스트케이스 출력을 해보기 위한 main 메소드입니다.
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        string commands = "URDDL";
        int[] ret = sol.solution(commands);

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + string.Join(',', ret) + " 입니다.");
    }
}