using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : Shape
{
    private void Start()
    {
        m_name = "Plane";
    }

    public override int GetSides()
    {
        return 2;
    }
}
