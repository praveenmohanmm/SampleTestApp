using System;

namespace SampleTestApp
{
	#region FIRST  ANSWER
	public class MathUtils
	{

		public static double Average(double a, double b)
		{

			return ( a + b ) / 2;

		}

	}
	#endregion

    #region SECOND ANSWER
	public class Path
	{

		public string CurrentPath { get; private set; }
		public Path(string path)
		{
			this.CurrentPath = path;
		}
		public Path Cd(string newPath)
		{
			// path excluding last dir
			string basePath = this.CurrentPath.Substring (0, CurrentPath.LastIndexOf ("/"));
			// new dir name starting pos
			int newDirNamePos = newPath.LastIndexOf ( "/" );
			// Add new dir name to base dir path
			CurrentPath = basePath + newPath.Substring ( newDirNamePos, newPath.Length - newDirNamePos );
			return this;
		}
	}
    #endregion

    #region THIRD ANSWER
	public class Run
	{
		public static int IndexOfLongestRun(string str)
		{
			int mostRepeatingIndex = 0;
			int currentMostRepatingIndex = 0;
			int currentIndex = 0;
			for (var index = 0; index < str.Length; ++index)
			{
				if (str[index] == str[currentIndex])
				{
					if (currentMostRepatingIndex < index - currentIndex) 
					{
						mostRepeatingIndex = currentIndex;
						currentMostRepatingIndex = index - currentIndex;
					}
				}
				else
				{
					currentIndex = index;
				}
			}
			return mostRepeatingIndex;
		}

	}​
    #endregion



   #region FOURTH ANSWER
	public class Node
	{
		public int Value { get; set; }
		public Node Left { get; set; }
		public Node Right { get; set; }
		public Node(int value, Node left, Node right)
		{
			Value = value;
			Left = left;
			Right = right;
		}
	}

	public class BinarySearchTree
	{
		private static  int previousValue = int.MinValue;
		public static bool IsValidBST(Node root)
		{
			if (root != null)
			{
				if (!IsValidBST(root.Left))
				{
					return false;
				}

				if (root.Value <= previousValue)
				{
					return false;
				}

				previousValue = root.Value;
				return IsValidBST(root.Right);
			}

			return true;
		}
	}​
   #endregion

    #region MAIN
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Question 1
			double avg = MathUtils.Average ( 10, 15 );
			Console.WriteLine ( "Averaget : " + avg.ToString() );

			// Question 2
			Path path = new Path("/a/b/c/d");
			string cdResult = path.Cd ("../x").CurrentPath;
			Console.WriteLine ( "CD result : " + cdResult );

			//Question 3
			int longRunIndex = Run.IndexOfLongestRun("abbcccddddcccbba");
			Console.WriteLine ( "longest run index : " + longRunIndex.ToString() );

			//Question 4
			Node n1 = new Node(1, null, null);
			Node n3 = new Node(3, null, null);
			Node n2 = new Node(2, n1, n3);
			bool isValidBst = BinarySearchTree.IsValidBST ( n2 );
			Console.WriteLine ( "binary search tree result : " + isValidBst );

		}
	}
    #endregion


}
