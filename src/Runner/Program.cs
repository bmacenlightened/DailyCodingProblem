// See https://aka.ms/new-console-template for more information
using ProbabilityProblems;
using BinaryTreeProblems;
using StackProblems;
using LinkedListProblems;

Console.WriteLine("Hello, World!");

TwoDiceRolls r = new();
r.RunTestCases();

var root = new BinaryTreeNode<int>(10);
root.Left = new BinaryTreeNode<int>(5);
root.Right = new BinaryTreeNode<int>(5);
root.Left.Right = new BinaryTreeNode<int>(2);
root.Right.Right= new BinaryTreeNode<int>(1);
root.Right.Right.Left = new BinaryTreeNode<int>(-1);

var orchestrator = new BinaryTreeOrchestrator();

Console.WriteLine(orchestrator.MinPathSum(root));

Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

ListNode<int> head = new ListNode<int>(1);
head.Next = new ListNode<int>(2);
head.Next.Next = new ListNode<int>(3);
head.Next.Next.Next = new ListNode<int>(4);

var i = 5;
while (i-- > 0)
{
    Console.WriteLine(new RandomNodePicker<int>(head).GetRandomNode());
}

LinkedListUtils<int> linkedListUtils= new LinkedListUtils<int>();
linkedListUtils.PrintList(head);
PairwiseNodeFlipper pairwise = new PairwiseNodeFlipper();
var flipped = pairwise.PairwiseFlip(head);
linkedListUtils.PrintList(flipped);