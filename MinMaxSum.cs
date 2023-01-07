static void minMaxSum(List<int> arr)
{
    arr.Sort();
    long min = 0;
    long max = 0;
    // min sum 
    for (int i = 0; i < arr.Count -1; i++)
    {
        min = min + arr[i];   
    }
    for (int i = 1; i < arr.Count; i++)
    {
        max = max + arr[i];   
    }
  Console.Write($"{min} {max}"); 
}

List<int> testList = new List<int>() { 256741038 , 623958417 , 467905213 , 714532089 , 938071625};
minMaxSum(testList);