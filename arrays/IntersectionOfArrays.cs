using System.Collections;
using System.Collections.Generic;

namespace algorithms {
  /**
    example1
    If arr1 = [1,2,2,1] && arr2 = [2,2] => intersection => [2,2]
    example2
    If arr1 = [4,9,5] && arr2 = [9,4,9,8,4] => intersection => [4,9]
  */
  public class IntersectionOfArrays {

    public int[] Intersect(int[] arr1, int[] arr2) {
      List<int> temp = new List<int>();
      for (int i = 0; i < arr1.Length-1; i++) {
        for (int j = 0; j < arr2.Length-1; j++) {
          if (arr2[j] == arr1[i]) {
            if (arr2[j+1] == arr1[i+1]) {
              temp.Add(arr1[i]);
              temp.Add(arr1[i+1]);
            }
          }   
        }
      }

      int[] solution = temp.ToArray();

      return solution;
    }

  }

}