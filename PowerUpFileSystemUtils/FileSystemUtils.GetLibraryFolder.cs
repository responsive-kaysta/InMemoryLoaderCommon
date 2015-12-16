﻿using System;
using log4net;
using PowerUpBase;
using System.IO;
using System.Reflection;

namespace PowerUpFileSystemUtils
{
	public partial class FileSystemUtils : AbstractPowerUpComponent
	{
		/// <summary>
		/// Ermittelt den Ordnernamen einer Klassenbibliothek
		/// </summary>
		/// <returns></returns>
		public string GetLibraryFolder
		{
			get
			{
				FileInfo fi = new FileInfo(Assembly.GetExecutingAssembly().Location);
				return fi.DirectoryName;
			}
		}
	}
}

