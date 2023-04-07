﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
	public class Leytenant : Soldier
	{
		public Leytenant()
		{
			UnitName = "XTQ";
			Guns = "Rpk 74";
			Health = "Good";

		}

		public override void Move(int x, int y)
		{
			X = x;
			Y = y;
			Console.WriteLine("Leytenant {0} : {1} koordinatina hereket etdi", X, Y);
		}
	}
}
