namespace Stack {

  public class Stack {
    static readonly int capacity = 1000;
    int top;
    int[] stack = new int[capacity];

    bool IsEmpty() => top < 0;

    public Stack() {
      top = -1;
    }

    internal bool Push(int data) {
      if (top >= capacity) {
        return false;
      } else {
        stack[++top] = data;
        return true;
      }
    }

    internal int Pop() {
      if (top < 0)
        return 0;
      else {
        int value = stack[top--];
        return value;
      }
    }

    internal int Peek() {
      if (top < 0) 
        return -1;
      else
        return stack[top];
    }
  }

}