using System;

namespace Arrays {

  public class MergeSortedArr {

    public void Merge() {
      System.Console.WriteLine("I'm just overloading this method");
    }

    /**
      nums1 = [1,2,3,0,0,0]
      nums2 = [2,5,6]
    */

    public void Merge(int[] nums1, int m, int[] nums2, int n) {
      int ptr1 = m - 1;
      int ptr2 = n - 1;
      
      int final_ptr = m + n - 1;
      
      while ((ptr1 >= 0) && (ptr2 >= 0)){
          nums1[final_ptr--] = (nums1[ptr1] < nums2[ptr2]) ? nums2[ptr2--] : nums1[ptr1--];
      } 
      
      Array.Copy(nums2, 0, nums1, 0, ptr2 + 1);
        
    }

  }

}