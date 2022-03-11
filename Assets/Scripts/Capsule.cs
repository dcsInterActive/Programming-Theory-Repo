using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    private void Start()
    {
        m_name = "Capsule";
    }

    public override int GetSides()
    {
        return 1;
    }
}
