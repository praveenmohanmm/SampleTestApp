/// <summary>
/// file contains change directory implementation
/// </summary>
using System;

/// <summary>
/// telstra app
/// </summary>
namespace TelstraApp
{
	#region SECOND ANSWER
	/// <summary>
	/// change directory implementation
	/// </summary>
	public class Path
	{
		public string currentPath { get; private set; }

		/// <summary>
		/// constructor, initialise curentPath
		/// </summary>
		/// <param name="path">Path.</param>
		public Path(string path)
		{
			this.currentPath = path;
		}

		/// <summary>
		/// take new path and perform change directry
		/// </summary>
		/// <param name="newPath">New path.</param>
		public Path Cd(string newPath)
		{
			// path excluding last dir
			string basePath = this.currentPath.Substring (0, currentPath.LastIndexOf ("/"));
			// new dir name starting pos
			int newDirNamePos = newPath.LastIndexOf ( "/" );
			// Add new dir name to base dir path
			currentPath = basePath + newPath.Substring ( newDirNamePos, newPath.Length - newDirNamePos );
			return this;
		}
	}
	#endregion
}

