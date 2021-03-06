﻿using System;
using InMemoryLoaderBase;
using log4net;
using System.Text.RegularExpressions;

namespace PowerUpStringUtils
{
	public partial class StringUtils : AbstractComponent
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="strToCheck"></param>
		/// <param name="strContains"></param>
		/// <returns></returns>
		public bool StringContains(string strToCheck, string strContains)
		{
			if (strToCheck == null || strContains == null)
			{
				return false;
			}
			if (strToCheck.Contains(strContains))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

