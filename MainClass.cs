using Arrays;

namespace algorithms {

  class MainClass {

    static void Main(string[] args) {

      int[] nums1 = {1,2,3,0,0,0};
      int[] nums2 = {2,5,6};

      var merg = new MergeSortedArr();

      merg.Merge(nums1, 3, nums2, 3);
    }

  }

}

