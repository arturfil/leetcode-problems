namespace algorithms {

  // TESING 
  /*
    int[] test = {0,5,2,4,7,1,6};
    MissingNumber missing = new MissingNumber();
    int result = missing.ReturnNumber(test);
    System.Console.WriteLine(result);
  */

  // The array has to start with 0 otherwise it will give the wrong number
  // Given an array, check which number is missing
  // [1,3,0] -> missing number is the 0
  // [9,6,4,2,3,5,7,0,1] -> the missing number is 8
  public class MissingNumber {

    public int ReturnNumber(int[] nums) {
      QuickSortArray(nums, 0, nums.Length-1);
      
      if (nums[nums.Length-1] != nums.Length) 
        return nums.Length;
      else if (nums[0] != 0) 
        return 0;


      for(int i = 0; i<nums.Length-1; i++)
        if (nums[i] + 1 != nums[i+1])
          return nums[i]+1;

      return -1;
    }

    public void QuickSortArray(int[] arr, int low, int high) {
      if (low < high) {
        int pi = partition(arr, low, high);
        QuickSortArray(arr, low, pi-1);
        QuickSortArray(arr, pi+1, high);
      }
    }

    public static int partition(int[] arr, int low, int high) {
      int pivot = arr[high];
      int i = (low - 1);
      
      for (int j = low; j < high; j++) {
        if (arr[j] < pivot) {
          i++;
          // swap arr[i] and arr[j]
          int temp = arr[i];
          arr[i] = arr[j];
          arr[j] = temp;
        }
      }

      int temp1 = arr[i+1];
      arr[i+1] = arr[high];
      arr[high] = temp1;
      return i+1;
    }
  }

}