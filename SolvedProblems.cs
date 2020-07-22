namespace algorithms
{

  public class SolvedProblems {
    
    public void print() {
      System.Console.WriteLine(
        @"
          This Problems are solved:
          ------------------------

          /**
          KidsWithCandies kidncandie = new KidsWithCandies();
          int[] candies = {1,3,9};
          int extra = 4;
          kidncandie.measure(candies, extra);
          
          /**
          RunningSum runningSum = new RunningSum();
          int[] ex_nums = {1,2,3,4};
          running sum problem;
          runningSum.Add(ex_nums);

          /**
          Defanging def = new Defanging();
          string ip_address = '123.123.422.92' // these go in double quotations when testing
          def.change(ip_address);

          /**
          char[] test = {'h','e','l','l','o'};
          ReverseString revStr = new ReverseString();
          revStr.reverse(test);

          /**
          Divisor Game
          NOTE: Check class, it is very easy

          /**
          BinaryTree bt = new BinaryTree();
          bt.root = new Node(1);
          bt.root.left = new Node(2);
          bt.root.right = new Node(3);
          bt.root.left.left = new Node(4);
          bt.root.left.right = new Node(5);   
          int result = bt.maxDepth(bt.root);
          System.Console.WriteLine($'The height of the tree is {result}'); // need double quotes here in order to work

          /**
          int[] nums = {4,4,1,2,3,1,2};
          SingleNumber single = new SingleNumber();
          single.single(nums);

          /**
          DeleteNode
          LinkedList list = new LinkedList();
          list.AddToEnd(4);
          list.AddToEnd(6);
          list.AddToEnd(10);
          list.AddToEnd(11);
          list.AddToBeginning(22);
          list.AddToBeginning(42);
          list.Print();
          // list.FindNode(42);
          list.DeleteNode(list.head, 10);
          System.Console.WriteLine("");
          list.Print();
          list.DeleteNode(list.head, 6);
          System.Console.WriteLine("");
          list.Print();

          /**
          FizzBuzz fizz = new FizzBuzz();
          fizz.Print(15);

          /**
          TwoSum sum = new TwoSum();
          int[] test = {3,3};
          sum.returnSum(test, 6);

          /**
          ValidAnagram vAnagram = new ValidAnagram();
          string s1 = 'airplane';                           // NOTE: this go with doulbe quotes on implementation
          string s2 = 'lanepair';                           // NOTE: this go with doulbe quotes on implementation
          System.Console.WriteLine(vAnagram.Check(s1, s2));

          /**
          Reverse LinkedList
          ListNode head = new ListNode();
          ListNode node1 = new ListNode(1);
          ListNode node2 = new ListNode(2);
          ListNode node3 = new ListNode(3);
          head.next = node1;
          node1.next = node2;
          node2.next = node3;
          head.PrintNodes(head);
          node1.reverseList(head);
          System.Console.WriteLine();
          node1.PrintNodes(node3);

          /**
          MajorityElement major = new MajorityElement();
          int[] test_nums = {4,4,4,2,3};
          int result = major.returnMajElementDict(test_nums);
          System.Console.WriteLine(result);

          /**
          MoveZeros mZeros = new MoveZeros();
          int[] test = {0,1,0,3,12};
          mZeros.moveZeros(test);
          mZeros.print(test);
          //mZeros.print(test);

          /** 
          ArrayToTree arr2tree = new ArrayToTree();
          int[] test = {-10, -3, 0, 5, 9};
          
          arr2tree.convertToTree(test);

        "
      );
    }

  }
    
}