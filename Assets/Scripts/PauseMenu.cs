using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    [SerializeField] GameObject pauseMenu;
    public static bool GamePaused = false;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            SetPause();
        }
    }

    private void SetPause() {
        pauseMenu.SetActive(!GamePaused);
        Time.timeScale = !GamePaused ? 0f : 1f;
        GamePaused = !GamePaused;
    }

    public void Resume() {
        SetPause();
    }

    public void LoadScene(string name) {
        SceneManager.LoadScene(name);
    }
}
