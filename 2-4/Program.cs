
class Solution
{
    public int solution(int[] arr, int K)
    {
        int answer = 0;

        for (int i = 0; i < arr.Length; i++)
            for (int j = i+1; j < arr.Length; j++)
                for (int h = j+1; h < arr.Length; h++)
                    if (i != j && i != h && j != h)
                        if ((arr[i] + arr[j] + arr[h]) % K == 0)
                            answer++;




        return answer;
    }

    // 아래는 테스트케이스 출력을 해보기 위한 main 메소드입니다.
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[] arr = { 1, 2, 3, 4, 5 };
        int K = 3;
        int ret = sol.solution(arr, K);


        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret + " 입니다.");
    }
}