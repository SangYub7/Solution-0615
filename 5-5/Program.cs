﻿
class Solution
{
    public int solution(int[] enemies, int[] armies)
    {
         int answer = 0;

        Array.Sort(enemies);
        Array.Sort(armies);

        int enemiesIdx = 0;

        for(int i = 0; i < armies.Length; i++)
        {
            if (enemiesIdx < enemies.Length && armies[i] >= enemies[enemiesIdx])
            {
                enemiesIdx++;
                answer++;
            }
        }

        return answer;
    }

    // 아래는 테스트케이스 출력을 해보기 위한 main 메소드입니다.
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[] enemies1 = { 1, 4, 3 };
        int[] armies1 = { 1, 3 };
        int ret1 = sol.solution(enemies1, armies1);

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret1 + " 입니다.");

        int[] enemies2 = { 1, 1, 1 };
        int[] armies2 = { 1, 2, 3, 4 };
        int ret2 = sol.solution(enemies2, armies2);

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret2 + " 입니다.");
    }
}