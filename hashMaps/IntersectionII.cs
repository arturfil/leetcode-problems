using System.Collections.Generic;

namespace algorithms {

  /*
    Here you are traversing between two arrays and you want to find
    common patterns, either strings or sequences.
    I've seen dynamic programming where you can implement this in a matrix

    So we could bould a double array to store the already comptuted resutls and that 
    way we can create a lookup table and keep track of the longest intersection
  */

  // testing arrays
  // {4,9,5};
  // {9,4,9,8,4};


  // basically, you want to create a hash map
  // with the arrya that has the minimum length
  // then you just have to add the unique keys (the numbers in the arrays);

  // return the value if they have more than one repetition
  // that way you know they have an intersection

  // Though you have to make sure that there is a pattern

  // ::::::::::::::::::::::::::::: NOTE -> CHECK FOR SORT SOLUTION LATER!
	public class IntersectionII {
		
		public int[] Intersect(int[] nums1, int[] nums2) {
  
      List<int> result = new List<int>(); // create an array/arrayList were you are storing the intersection
      Dictionary<int, int> intersection = new Dictionary<int, int>(); // Create a hashmap

      // Initialize the hashmpap
      foreach(int numb in nums1) { 
        try {
          intersection.Add(numb, 1); // try adding a new one
        } catch {
          intersection[numb]++; // if already exists add a +1; to the vale of the key
        }
      }
      
      foreach(int numb in nums2) {
        // check if the current value appears as a key in the hashmap
      
        if (intersection.ContainsKey(numb)) { 
          intersection[numb]--;
          result.Add(numb);
        }
      }        

      return result.ToArray();
	  }

  }

}
