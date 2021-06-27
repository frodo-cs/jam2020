using UnityEngine;
using UnityEngine.UI;

public class Organ : MonoBehaviour {

    [SerializeField] Image image;
    [SerializeField] Sprite[] sprites;

    public int maxHealth = 100;
    public int minHealth = 0;

    [Range(0.01f, 0.02f)]
    public float decayRate = 0.01f;

    [HideInInspector] public float Health { get; set; }
    [HideInInspector] public bool Death { get; set; }

    private void Start() {
        image.sprite = sprites[0];
        Health = maxHealth;
        Death = false;
    }

    private void Update() {
        if (!Death && !PauseMenu.GamePaused) {
            Health -= decayRate;
            if (Health <= 0) {
                image.sprite = sprites[3];
                Death = true;
                GameEvents.current.OrganDiedTrigger();
            } else if (Health < maxHealth / 3) {
                image.sprite = sprites[2];
            } else if (Health < 2 * maxHealth / 3) {
                image.sprite = sprites[1];
            } else {
                image.sprite = sprites[0];
            }
        }    
    }
}
