using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour {
    [SerializeField] AudioSource source;
    [SerializeField] Slider bloodCount;
    [SerializeField] Slider bloodToGive;

    public static event EventHandler<KeyValuePair<int, string>> UnitsSend;

    private void Start() {
        Organ.OrganDied += DeactivateButton;
    }

    private void DeactivateButton(object sender, KeyValuePair<string, string> pair) {
        Objects.buttons[pair.Key].interactable = false;
    }

    public void OnButtonPress(string name) {
        int temp = (int)bloodToGive.value;
        bloodCount.value -= bloodToGive.value;
        float sum = Objects.organs[name].Health + bloodToGive.value;
        if (sum > Objects.organs[name].maxHealth) {
            Objects.organs[name].Health = Objects.organs[name].maxHealth;
        } else {
            Objects.organs[name].Health = sum;
        }
        if(temp > 0)
            OnUnitsSend(new KeyValuePair<int, string>(temp, Objects.organs[name].organName));
    }

    public void GeneralButton() {
        source.Play();
    }

    protected virtual void OnUnitsSend(KeyValuePair<int, string> pair) {
        UnitsSend?.Invoke(this, pair);
    }
}
