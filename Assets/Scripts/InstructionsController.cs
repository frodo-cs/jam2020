using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsController : MonoBehaviour {
    public string menu;
    public string scene;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey("space")) {
            SceneManager.LoadScene(scene);
        } else if (Input.GetKey("escape")) {
            SceneManager.LoadScene(menu);
        }
    }

    public void LoadScene(string name) {
        SceneManager.LoadScene(name);
    }

}
