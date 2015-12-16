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
		/// Ermittelt den Dateinamen einer Klassenbibliothek
		/// </summary>
		/// <returns>Gibt den Dateinamen der Klassenbibliothek zurück</returns>
		public string GetLibraryFilename
		{
			get
			{
				FileInfo fi = new FileInfo(Assembly.GetExecutingAssembly().Location);
				return fi.Name;
			}
		}
	}
}

