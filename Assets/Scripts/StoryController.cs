using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StoryController : MonoBehaviour
{
    public string scene;

    void Update()
    {
        if (Input.GetKey("space"))
        {
            SceneManager.LoadScene(scene);
        }
    }

    public void LoadScene() {
        SceneManager.LoadScene(scene);
    }
}
