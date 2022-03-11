using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public abstract class Shape : MonoBehaviour
{
    // ENCAPSULATION
    protected string m_name;
    public string Name
    {
        get { return m_name; }
    }

    protected void Awake()
    {
        m_name = "Shape";
    }

    // POLYMORPHISM
    public virtual int GetSides()
    {
        return 0;
    }

    // ABSTRACTION
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
