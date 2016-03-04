/// <summary>
/// file contains implementation of longest run char in a string
/// </summary>
using System;

/// <summary>
/// telstra app
/// </summary>
namespace TelstraApp
{
	#region THIRD ANSWER
	/// <summary>
	/// class is for getting longest run char
	/// </summary>
	public class Run
	{
		/// <summary>
		/// function recieves string and return he longest run chars index position
		/// </summary>
		/// <returns>The of longest run chars index.</returns>
		/// <param name="str">String.</param>
		public static int IndexOfLongestRun(string testString)
		{
			int mostRepeatingIndex = 0;
			int currentMostRepatingIndex = 0;
			int currentIndex = 0;
			for (var index = 0; index < testString.Length; ++index)
			{
				// checks if a char is repeating or not
				if (testString[index] == testString[currentIndex])
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
}

