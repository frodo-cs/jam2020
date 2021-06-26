using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryController : MonoBehaviour
{
    public string story;
    public Text text;

    public string scene;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Reloj());
    }

    IEnumerator Reloj()
    {
        foreach (char caracter in story)
        {
            text.text += caracter;
            yield return new WaitForSeconds(0.07f);
            
        }
    }

    void Update()
    {
        if (Input.GetKey("space"))
        {
            SceneManager.LoadScene(scene);
        }
    }

}
