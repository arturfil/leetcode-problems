using System;
using System.Collections.Generic;
using algorithms;

namespace Stack {

    /** 
        This is for testing purposes
    + ============================================================== +
    | In order to solve this proble you need to create a             |    
    | stack that keeps track of both the value and the cu-           |        
    | rrent minimun value.                                           |         
    |                                                                |         
    | You can use an already created stack for this problem          |             
    | and the specific thing here is that the minimum value          |                 
    | is only known for the current value and what was pre           |             
    | previously used, unless the current value itself is            |             
    | the current minimum.                                           |
    |                                                                |
    | Therefore if you insert a 10, 20, 8, 6, 40, 2, 11, 15          |
    | It would look like this where the stack implements an          |
    | array type of stack the first bein the val. and the            |
    | second value being the minimum AT THAT POINT:                  |
    |                                                                |                         
    | [10,10], [20, 10], [8,8], [6,6], [40,6], [2,2], [11,2], [15,2] |
    + ============================================================== +                         
    */

  public class MinStack {
    private Stack<int[]> stack = new Stack<int[]>();
    
    public MinStack() {}

    public void Push(int x) {
      if (stack.Count == 0) {
        stack.Push(new int[]{x,x}); // current and min        
        return;
      }

      int min = stack.Peek()[1];
      stack.Push(new int[]{x, Math.Min(x, min)});
    }

    public void Pop() => stack.Pop();

    public int Top() => stack.Peek()[0];

    public int GetMin() => stack.Peek()[1];
  }

}