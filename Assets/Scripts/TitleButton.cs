using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // for SceneManager

public class TitleButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void Button()
    {
        SceneManager.LoadScene(1);
    }
}
