﻿using System;

namespace SHOIC
{
	interface IFlooder
	{
		#region Properties
		int Delay { get; set; }

		bool IsFlooding { get; set; }
		#endregion

		#region Methods
		void Start();
		#endregion
	}
}
