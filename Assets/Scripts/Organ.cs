using UnityEngine;
using UnityEngine.UI;

public class Organ : MonoBehaviour {

    [SerializeField] Image image;
    [SerializeField] Sprite[] sprites;

    public int maxHealth = 100;
    public int minHealth = 0;

    [Range(0.0f, 0.1f)]
    public float deterRate = 0.01f;

    [HideInInspector] public float Health { get; set; }

    private void Start() {
        image.sprite = sprites[0];
        Health = maxHealth;
    }

    private void Update() {
        Health -= deterRate;
        if(Health < maxHealth / 4) {
            image.sprite = sprites[3];
        } else if (Health < 2 * maxHealth / 4) {
            image.sprite = sprites[2];
        } else if (Health < 3 * maxHealth / 4) {
            image.sprite = sprites[1];
        } else {
            image.sprite = sprites[0];
        }
    }
}
