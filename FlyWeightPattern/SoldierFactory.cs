using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
	public class SoldierFactory
	{
		private Dictionary<SoldierType, Soldier> _soldiers = new();


		public Soldier GetSoldier(SoldierType soldierType)
		{
			Soldier soldier = null;

			if(_soldiers.ContainsKey(soldierType))
			{
				soldier = _soldiers[soldierType];
			}
			else
			{
				if(soldierType == SoldierType.Leytenant)
				{
					soldier = new Leytenant();
				}
				else if (soldierType == SoldierType.Kapitan)
				{
					soldier = new Kapitan();
				}
				else if (soldierType == SoldierType.Mayor)
				{
					soldier = new Mayor();
				}

				_soldiers.Add(soldierType, soldier);
			}
			return soldier;
		}

	}
}
