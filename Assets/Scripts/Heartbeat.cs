using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Heartbeat : MonoBehaviour {
    
    public static Heartbeat beat;
    AudioSource source;

    private void Awake() {
        if (beat == null) {
            DontDestroyOnLoad(gameObject);
            beat = this;
        } else if (beat != this) {
            Destroy(gameObject);
        }
    }

    private void Start() {
        source = GetComponent<AudioSource>();
    }

    private void Update() {
        if(SceneManager.GetActiveScene().name == "Game") {
            source.volume = 0.1f;
        } else if (SceneManager.GetActiveScene().name == "GameOver") {
            source.volume = 0;
        } else {
            source.volume = 0.5f;
        }
    }
}
