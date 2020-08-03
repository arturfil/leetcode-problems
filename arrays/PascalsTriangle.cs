using System.Collections.Generic;

namespace algorithms {

  public class PascalsTriangle {

    public IList<IList<int>> Generate(int numRows) {
      IList<IList<int>> pascal = new List<IList<int>>();
      IList<int> prevRow = numRows > 0 ? new List<int>(numRows){1} : null;

      for (int i = 1; i <= numRows; i++) {
        for (int j = prevRow.Count - 1; j > 0; j--) {
            prevRow[j] += prevRow[j - 1];
        }

        IList<int> row = new List<int>(prevRow);
        pascal.Add(row);
        prevRow.Add(0);
      }

      foreach(var outerl in pascal) {
        foreach(var innerl in outerl) {
          System.Console.Write(innerl);
        }
        System.Console.WriteLine();
      }

      return pascal;
    }

  }

}