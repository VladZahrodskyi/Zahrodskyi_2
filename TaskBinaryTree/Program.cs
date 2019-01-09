using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TaskForBinaryTree.Helper;
using TaskForBinaryTree.Tree;

namespace TaskForBinaryTree
{
	class Program
	{
		static void Main(string[] args)
		{
			//Create BinaryTree instance 
			BinaryTree<Student> inst = new BinaryTree<Student>();

			//Initialize Events
			inst.AddNode += Inst_AddNode;
			inst.RemoveNode += Inst_AddNode;

			//Test student instance
			Student testStudent = new Student() { Mark = 80 };
			Random rand = new Random();

			//First step
			Console.WriteLine("STEP-1-------------------\n");
			//Initializing Tree by Students
			for (int i = 0; i < 10; i++)
			{
				int t = rand.Next(60, 100);
				inst.Add(new Student { Name = $"Vlad_{i}", Mark = rand.Next(60, 100) });//Will be invoken event - inst.AddNode
				//Console.WriteLine($"Vlad_{i}----{t}\t");
			}

			//Next step
			Console.WriteLine("STEP-2-------------------\n");
			inst.Add(testStudent);
			Console.WriteLine($"The Tree contain this student? Answer is {inst.Contains(testStudent)}\n");//true
			Console.WriteLine($"There are {inst.Count} in the tree");//11
			inst.Remove(testStudent);
			Console.WriteLine($"The Tree contain this student? Answer is {inst.Contains(testStudent)}");//false
			Console.WriteLine($"There are {inst.Count} in the tree");//10

			//Next step
			Console.WriteLine("STEP-3-------------------\n");
			try
			{
				foreach (var element in inst)//Not implemented
				{
					
				}
			}
			catch (NotImplementedException)
			{

				Console.WriteLine("try-catch was succesfully work");//will work
			}

			Console.WriteLine("STEP-4-------------------\n");
			foreach (var element in inst.InOrderTraversal())// Work right
			{
				Console.WriteLine(element.ToString());
			}
			
			Console.WriteLine("STEP-5-------------------\n");
			foreach (var element in inst.PreOrderTraversal())// Work right
			{
				Console.WriteLine(element.ToString());
			}

			Console.WriteLine("STEP-6-------------------\n");

			Console.WriteLine($"There are {inst.Count} in the tree");//10
			inst.Clear();
			Console.WriteLine($"There are {inst.Count} in the tree");//0

			Console.ReadKey();
		}

		private static void Inst_AddNode(string action)
		{
			Console.WriteLine(action);
			Console.WriteLine();
		}
	}
}
