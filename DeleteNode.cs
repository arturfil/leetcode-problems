using System;

namespace algorithms {

  /**
    - I Added all this classes in the case that you want to review linked lists and how they are formed.
    - Briefly, a linked list is made by nodes "[val]" that point to another nodes and hence they remain linked.
    - A linked list would look like [1]->[34]->[22]->[52]->[7]->
    - Here I implemented the main Add and Print methods in the Node class but this can be easily done in the LinkedList class.

    - The leet code problem asks to create a delete method, where similar to print, you simply put the value you want to delete
      And the method checks recursively whether the node value matches with the target node, if so, you simply point the previous to current.next
      or you point current to current.next.next with the idea of skipping the value you want to delete.
    - After "unlinking" the value you want to delte, C# garbage collector will free the memory, C and C++ requires you to free that memory as an FYI.
  */

  public class Node {
    public Node next;
    public int data;

    public Node(int val) {
      data = val;
      next = null;
    }

    public void AddToEnd(int data) {
      if (next == null)
        next = new Node(data);
      else
        next.AddToEnd(data);
    }

    public void DeleteNode(int data) {
      // head 
      // if (head.data == data) {

      // }
      // if (next.data == data) {

      // }
    }

    public void Print() {
      Console.Write($"|{data}|->");
      if(next != null)
        next.Print();
    }
  }

  public class DeleteNode {

    public void deleteNode(Node node) {
      Node node_to_delete = new Node(0);
     while (node != node_to_delete) {
       node_to_delete = node_to_delete.next;
     } 
     node_to_delete.next = node_to_delete.next.next;
    }

  }

  public class LinkedList {
    public Node head;

    public LinkedList() {
      head = null;
    }

    public void AddToEnd(int data) {
      if (head == null)
        head = new Node(data);
      else 
        head.AddToEnd(data);
    }

    public void AddToBeginning(int data) {
      if (head == null)
        head = new Node(data);
      else {
        Node temp = new Node(data);
        temp.next = head;
        head = temp;
      }
    }

    // this is the solution to leet code, very lame,
    // if you have a linked list like so [1]->[2]->[3]
    // and you want to delete [2]; you simply point [1] to [3] 
    // you basicaly say make pointer [1] to [2] replace the data with 3
    // and you also replace the the [1] pointer, or "next" to [3] instead of now the other [3]
    // basically you are doing:
    // Step 1: [1]->[3]->[3]; where you copy the data;
    // Step 2: [1]->[3] x-[3]; unlink the last node;
    // For this method to work, you neet to create the link list node by node which is a pain
    public void DeleteNode(Node node) {
      node.data = node.next.data;
      node.next = node.next.next;
    }

    // I like this method better because if you want to find the node by the value it does exactly that
    public Node FindNode(int data) {
      Node target = new Node(data);
      Node current = head;

      while(target.data != current.data && current.next != null) {
        current = current.next;
      }
      if (target.data == current.data) {
        System.Console.WriteLine($"\nFound value & node! target: {target.data} value: {current.data}");
        return current;
      }
      System.Console.WriteLine($"Value was not found, current node on list is {current.data}");
      return current;
    }

    // I like this recursive function better because you just nead the head node and the value you
    // want to delete
    public void DeleteNode(Node node, int data) {
      if (node.data == data ) {
        node.data = node.next.data;
        node.next = node.next.next;
        return;
      }
      DeleteNode(node.next, data);
    }

    public void Print() {
      if (head != null)
        head.Print();
    }
  }

}