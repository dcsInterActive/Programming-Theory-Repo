using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    private void Start()
    {
        m_name = "Cylinder";
    }

    public override int GetSides()
    {
        return 3;
    }
}
