using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Text sliderValue;
    public Slider slider;
    int currentValue;

    // Start is called before the first frame update
    public void OnSliderChanged(float value)
    {
        sliderValue.text = value.ToString();
        Debug.Log(value);
    }

    public void UpdateBlood()
    {
        currentValue++;
        slider.value = currentValue;
    }
}
