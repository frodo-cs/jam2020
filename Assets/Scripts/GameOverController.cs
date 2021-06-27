using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour {

    [SerializeField] AudioSource source;
    [SerializeField] Button button;
    [SerializeField] Sprite[] sprite;

    public void Sound() {
        if (source.isPlaying) {
            source.Stop();
            button.image.sprite = sprite[1];
        } else {
            source.Play();
            button.image.sprite = sprite[0];
        }
    }

    public void LoadScene(string name) {
        SceneManager.LoadScene(name);
    }

}
