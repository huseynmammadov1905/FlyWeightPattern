
using FlyWeightPattern;

SoldierType[] soldiers = { SoldierType.Kapitan, SoldierType.Leytenant, SoldierType.Mayor };


SoldierFactory soldierFactory = new SoldierFactory();

int locationX = 10;
int locationY = 5;

foreach (var soldier in soldiers)
{
	locationX += 5;
	locationY += 10;

	Soldier sld = soldierFactory.GetSoldier(soldier);

	sld.Move(locationX, locationY);
}

