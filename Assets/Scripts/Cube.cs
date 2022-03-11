using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    private void Start()
    {
        m_name = "Cube";
    }

    public override int GetSides()
    {
        return 6;
    }
}
