﻿using System;
using InMemoryLoader;
using InMemoryLoaderBase;
using InMemoryLoaderCommon;
using log4net;
using System.Globalization;
using System.Linq;

namespace InMemoryLoaderCommenTestSuite.CryptUtilsTest
{
	public partial class Test
	{
		/// <summary>
		/// The log.
		/// </summary>
		private static readonly ILog log = LogManager.GetLogger (typeof(InMemoryLoaderCommenTestSuite.CryptUtilsTest.Test));
		/// <summary>
		/// The app base.
		/// </summary>
		private static AppBase appBase = AppBase.Instance;
		/// <summary>
		/// The crypt utils.
		/// </summary>
		private static IDynamicClassInfo cryptUtils = 
			appBase.ComponentLoader.ComponentRegistry.Where (utl => utl.Key.Class.Contains ("CryptUtils")).SingleOrDefault ().Value;

	}
}
