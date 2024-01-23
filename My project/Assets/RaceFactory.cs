using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Race
{
    Terran,
    Protoss,
    Zerg
}

public abstract class RaceFactory : MonoBehaviour
{
    public abstract RaceCapacity makeCapacityBuilng();
    public abstract UnitBuilding makeUnitBuilding();
}

public class TerranFactory : RaceFactory
{
    public override RaceCapacity makeCapacityBuilng()
    {
        return new SupplyDepot();
    }

    public override UnitBuilding makeUnitBuilding()
    {
        return new Barracks();
    }
}

public class ProtossFactory : RaceFactory
{
    public override RaceCapacity makeCapacityBuilng()
    {
        return new Pylon();
    }

    public override UnitBuilding makeUnitBuilding()
    {
        return new Gateway();
    }
}
