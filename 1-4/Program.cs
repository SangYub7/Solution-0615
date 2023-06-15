class Solution
{
    public int[] solution(int[] arrA, int[] arrB)
    {
        int arrA_idx = 0, arrB_idx = 0;
        int arrA_len = arrA.Length;
        int arrB_len = arrB.Length;
        int[] answer = new int[arrA_len + arrB_len];
        int answer_idx = 0;
        while (arrA_idx < arrA_len && arrB_idx < arrB_len){
            if (arrA[arrA_idx] < arrB[arrB_idx])
                answer[answer_idx++] = arrA[arrA_idx++];
            else
                answer[answer_idx++] = arrB[arrB_idx++];
        }
        while (arrA_idx < arrA_len)
            answer[answer_idx++] = arrA[arrA_idx++];
        while (arrB_idx < arrB_len)
            answer[answer_idx++] = arrB[arrB_idx++];
        return answer;
    }

    // The following is main method to output testcase.
    public static void Main(String[] args)
    {
        Solution sol = new Solution();
        int[] arrA = { -2, 3, 5, 9 };
        int[] arrB = { 0, 1, 5 };
        int[] ret = sol.solution(arrA, arrB);

        // Press Run button to receive output. 
        Console.WriteLine("Solution: return value of the method is " + string.Join(',', ret) + " .");
    }
}