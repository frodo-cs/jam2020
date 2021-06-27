﻿using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BloodCount : MonoBehaviour {

    [SerializeField] float rate = 5;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] Slider slider;
    [SerializeField] AudioSource source;

    public int maxBlood = 100;

    private void Start() {
        slider.maxValue = maxBlood;
        slider.value = 15;
        InvokeRepeating("IncreaseBloodCount", rate, rate);
    }

    void IncreaseBloodCount() {
        if(slider.value < maxBlood && !PauseMenu.GamePaused) {
            slider.value+=5;
            source.Play();
        }     
    }

    public void FixedUpdate()
    {
        text.text = $"{slider.value}";
    }
}
