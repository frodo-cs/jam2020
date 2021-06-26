using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string scene;
    public string menu;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            SceneManager.LoadScene(scene);
        }

        else if (Input.GetKey("escape")) 
        {
            SceneManager.LoadScene(menu);
        }
    }

}
