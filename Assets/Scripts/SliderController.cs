using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Text sliderValue;
    public Slider slider;
    int value = 0;

    // Start is called before the first frame update
    public void OnSliderChanged(float value)
    {
        sliderValue.text = slider.value.ToString();
    }

    public void UpdateBlood()
    {
        value++;
        slider.value = value;
    }
}
