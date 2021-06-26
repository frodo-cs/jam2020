using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour {
    [SerializeField] AudioSource source;
    public Slider bloodLeft;
    public Slider bloodToGive;
    int n;

    public void OnButtonPress() { 
        n++;
        Debug.Log("Button clicked " + n + " times.");
    }

    public void GeneralButton() {
        source.Play();
        bloodToGive.value = bloodToGive.maxValue;
    }

}
