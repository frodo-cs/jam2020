using System;
using UnityEngine;
using UnityEngine.UI;

public class Organ : MonoBehaviour {

    [SerializeField] Image image;
    [SerializeField] Sprite[] sprites;

    public string organ;
    public int maxHealth = 100;
    public int minHealth = 0;

    [Range(0.01f, 0.02f)]
    public float decayRate = 0.01f;

    [HideInInspector] public float Health { get; set; }
    [HideInInspector] public bool Death { get; set; }

    private bool dying = false;

    public static event EventHandler<string> OrganDying;

    private void Start() {
        image.sprite = sprites[0];
        Health = maxHealth;
        Death = false;
    }

    public void IncrementDecayRate() {
        if (!Death) {
            decayRate += 0.01f;
        }    
    }

    private void Update() {
        if (!Death && !PauseMenu.GamePaused) {
            Health -= decayRate;
            if (Health <= 0) {
                image.sprite = sprites[3];
                Death = true;
                GameEvents.current.OrganDiedTrigger();
            } else if (Health < maxHealth / 3 && !dying) {
                image.sprite = sprites[2];
                dying = true;
                OnOrganDying(organ);
            } else if (Health < 2 * maxHealth / 3 && Health >= maxHealth / 3) {
                image.sprite = sprites[1];
                dying = false;
            } else if (Health >= 2 * maxHealth / 3) {
                image.sprite = sprites[0];
                dying = false;
            }
        }    
    }

    protected virtual void OnOrganDying(string name) {
        OrganDying?.Invoke(this, name);
    }
}
