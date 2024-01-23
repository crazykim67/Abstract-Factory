using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UnitBuilding
{
    public abstract void produce();
}

public class Barracks : UnitBuilding
{
    public override void produce()
    {
        Debug.Log("테란 유닛 생산!!!");
    }
}

public class Gateway : UnitBuilding
{
    public override void produce()
    {
        Debug.Log("프로토스 유닛 생산!!!");
    }
}