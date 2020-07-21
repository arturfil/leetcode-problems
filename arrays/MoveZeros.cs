namespace algorithms {

  public class MoveZeros {

    // int[] test = {0,1,0,3,12};
    // result => {1,3,12,0,0}

    // [0,1,0,3,12];

    // [0, 1, 0, 12, 12]
    public void moveZeros(int[] arr) {
      int index = 0;
      for(int i = 0; i < arr.Length; i++) {
        
        if (arr[i] != 0) {  // first round => arr[1] = arr[0]
          arr[index++] = arr[i];
        }  
        System.Console.Write($"round {i} index = {index} ");
        System.Console.WriteLine($"and arr[index++] = {arr[index+1]}");
      }

      System.Console.WriteLine(arr[1]);
      System.Console.WriteLine(arr[2]);
      
      System.Console.WriteLine("Second loop beg");

      for(int i = index; i < arr.Length; i++) {
        System.Console.Write($"before {arr[i]} ");
        arr[i] = 0;
        System.Console.Write($"after {arr[i]}");
        System.Console.WriteLine();
      } 
    }

    public void print(int[] arr) {
      foreach(int num in arr) 
        System.Console.Write($"{num}, ");
    }

  }

}