using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string m_name;

    public string Name
    {
        get { return m_name; }
    }

    protected void Awake()
    {
        m_name = "Shape";
    }

    public virtual int GetSides()
    {
        return 0;
    }

    public string GetMaterial()
    {
        Material m = gameObject.GetComponent<Renderer>().material;
        if (m != null)
        {
            return m.name;
        }
        return "invalid material";
    }
}
