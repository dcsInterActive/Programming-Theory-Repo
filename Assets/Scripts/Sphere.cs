using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private void Start()
    {
        m_name = "Sphere";
    }

    public override int GetSides()
    {
        return 1;
    }
}
