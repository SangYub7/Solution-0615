 class Solution
{
    public int solution(int[] arr)
    {
        // 여기에 코드를 작성해주세요.
        int answer = 0;
 
        for(int i = 0; i < arr.Length; i++)
        {
            int startIdx = i;
            
            while (startIdx +1 < arr.Length && arr[startIdx] < arr[startIdx + 1] )
            {
                startIdx++;
            }

            answer = Math.Max(answer, startIdx - i + 1);
            i = startIdx;
        }       

        return answer;
    }

    // 아래는 테스트케이스 출력을 해보기 위한 main 메소드입니다.
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[] arr = { 3, 1, 2, 4, 5, 1, 2, 2, 3, 4 };
        int ret = sol.solution(arr);

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret + " 입니다.");
    }
}