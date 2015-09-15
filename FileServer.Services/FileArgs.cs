using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileServer.Services
{
	public delegate void FileEventHandler(object sender, FileEventArgs e);

	public class FileEventArgs : EventArgs
	{
		/// <summary>
		/// Gets the virtual path.
		/// </summary>
		public string VirtualPath { get; } = null;

	    /// <summary>
		/// Initializes a new instance of the <see cref="FileEventArgs"/> class.
		/// </summary>
		/// <param name="vPath">The v path.</param>
		public FileEventArgs(string vPath)
		{
			this.VirtualPath = vPath;
		}
	}
}
