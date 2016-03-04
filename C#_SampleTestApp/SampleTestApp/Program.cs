/// <summary>
/// Main class.
/// </summary>
using System;

/// <summary>
/// telstra app
/// </summary>
namespace TelstraApp
{
    #region MAIN
	/// <summary>
	/// entry program
	/// </summary>
	class MainClass
	{
		public static void Main (string[] args)
		{

			// Question 1
			double avg = MathUtils.Average ( 10, 15 );
			Console.WriteLine ( "Average : " + avg.ToString() );

			// Question 2
			Path path = new Path("/a/b/c/d");
			string cdResult = path.Cd ("../x").currentPath;
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
