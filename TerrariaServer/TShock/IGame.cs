﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TShock
{
	public interface IGame
	{
		IList<IPlayer> Players { get; } 
	}
}