using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseFactory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RaceFactory fac = null;

        Race type = Race.Terran;

        if(type == Race.Terran)
            fac = new TerranFactory();
        else if(type == Race.Protoss)
            fac = new ProtossFactory();

        RaceCapacity capacity = fac.makeCapacityBuilng();
        UnitBuilding building = fac.makeUnitBuilding();

        capacity.expand();
        building.produce();
    }
}
