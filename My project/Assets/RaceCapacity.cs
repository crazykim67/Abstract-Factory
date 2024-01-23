using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RaceCapacity
{
    public abstract void expand();
}

public class SupplyDepot : RaceCapacity
{
    public override void expand()
    {
        Debug.Log("테란 인구 수 8 증가!!!");
    }
}

public class Pylon : RaceCapacity
{
    public override void expand()
    {
        Debug.Log("프로토스 인구 수 8 증가!!!");
    }
}
