using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
	public abstract class Soldier
	{
		protected string UnitName;
		protected string Guns;
		protected string Health;


		protected int X;
		protected int Y;

		public abstract void Move(int x, int y);
	}
}
