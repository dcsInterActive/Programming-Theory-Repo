using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInput : MonoBehaviour
{
    public Camera GameCamera;

    public Text nameText;
    public Text sidesText;
    public Text colorText;

    private Shape m_Shape = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = GameCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider != null)
                {
                    var shape = hit.collider.GetComponentInParent<Shape>();
                    if (shape != null)
                    {
                        m_Shape = shape;
                        nameText.text = "Name : " + m_Shape.Name;
                        sidesText.text = "Sides : " + m_Shape.GetSides();
                        colorText.text = "Color : " + m_Shape.GetMaterial();
                    }
                    else
                    {
                        Debug.Log("shape is null");
                    }
                }
                else
                {
                    Debug.Log("collider is null");
                }
            }
        }
    }
}
