using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
    public string scene;
    public string instructions;

    void Update() {
        if (Input.GetKeyUp("space")) {
            SceneManager.LoadScene(scene);
        } else if (Input.GetKey("i")) {
            SceneManager.LoadScene(instructions);
        }
    }

    public void LoadScene(string name) {
        SceneManager.LoadScene(name);
    }

}
