using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour {
    [SerializeField] AudioSource source;
    public Slider bloodCount;
    public Slider bloodToGive;
    int n;
    
    public void OnButtonPress() {
        n++;
        Debug.Log("Button clicked " + n + " times.");
    }

    public void GeneralButton()
    {
        source.Play();

    }

    private void FixedUpdate()
    {
        
    }

}
