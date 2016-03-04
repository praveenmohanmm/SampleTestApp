/// <summary>
/// file to find given bst is valid or not
/// </summary>
using System;

/// <summary>
/// telstra app
/// </summary>
namespace TelstraApp
{
	#region FOURTH ANSWER
	/// <summary>
	/// class contain single node info
	/// </summary>
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

	/// <summary>
	/// class for checking given node is bst or not
	/// </summary>
	public class BinarySearchTree
	{
		private static  int previousValue = int.MinValue;
		/// <summary>
		/// to check whther the given node is avalid bst or not
		/// </summary>
		/// <returns><c>true</c>  true, if valid bst else false </c>.</returns>
		/// <param name="root">Root.</param>
		public static bool IsValidBST(Node root)
		{
			if (root != null)
			{
				// recusrive fn call, if fails not a bst
				if (!IsValidBST(root.Left))
				{
					return false;
				}

				// values in left must be small and value in right nodes must be greater
				if (root.Value <= previousValue)
				{
					return false;
				}

				previousValue = root.Value;
				return IsValidBST(root.Right);
			}

			// when all the condition satisfies, it's a valid bst
			return true;
		}
	}​
	#endregion
}

