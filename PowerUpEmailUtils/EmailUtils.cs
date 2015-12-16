﻿using System;
using log4net;
using PowerUpBase;

namespace PowerUpEmailUtils
{
	public partial class EmailUtils : AbstractPowerUpComponent
	{
		/// <summary>
		/// The log.
		/// </summary>
		private static readonly ILog log = LogManager.GetLogger (typeof(EmailUtils));

		/// <summary>
		/// Initializes a new instance of the <see cref="PowerUpEmailUtils.EmailUtils"/> class.
		/// </summary>
		public EmailUtils ()
		{
			log.DebugFormat ("Create a new instance of Type: {0}", this.GetType ().ToString ());
		}
	}
}

