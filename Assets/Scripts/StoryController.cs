using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StoryController : MonoBehaviour
{
    public string story;
    public TextMeshProUGUI text;
    public string scene;

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

    public void LoadScene() {
        SceneManager.LoadScene(scene);
    }
}
