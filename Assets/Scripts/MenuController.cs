using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{
    public string scene;
    public string instructions;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            SceneManager.LoadScene(scene);
        }

        else if (Input.GetKey("i"))
        {
            SceneManager.LoadScene(instructions);
        }
    }

}
