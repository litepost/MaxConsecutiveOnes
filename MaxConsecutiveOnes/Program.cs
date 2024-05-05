static int FindMaxConsecutiveOnes(int[] nums) {
    int i = 0;
    int j = 0;
    int previousZero = 0;
    int maxCount = 0;
    int index = 0;

    while (i < nums.Length) {
        System.Console.WriteLine("----------");
        System.Console.WriteLine($"i = {i}");
        if (nums[i] == 0) {
            j = i + 1;
            System.Console.WriteLine($"j before loop = {j}");
            while (j < nums.Length) {
                System.Console.WriteLine($"j = {j}");
                if (nums[j] == 0) {
                    if (j - previousZero > maxCount) {
                        maxCount = j - previousZero;
                        index = i;
                    }
                    previousZero = i;
                    i = j;
                    break;
                }
                else
                    j++;
            }

            if (i != j) {
                return Math.Max(maxCount, nums.Length-1 - previousZero);
            }
        }
        else {
            i++;
        }
    }
    return maxCount;
}

// int[] input = [0,0,1,0,1,1,1,0,1,1];
// int[] input = [1,0,1,1,0];
int[] input = [1,0,1,1,0,1];
int answer = FindMaxConsecutiveOnes(input);
System.Console.WriteLine($"answer = {answer}");