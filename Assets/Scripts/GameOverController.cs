using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour {

    [SerializeField] AudioSource source;
    private bool sound;

    public void Sound() {
        if (source.isPlaying) {
            source.Stop();
        } else {
            source.Play();
        }
    }

    public void LoadScene(string name) {
        SceneManager.LoadScene(name);
    }

}
