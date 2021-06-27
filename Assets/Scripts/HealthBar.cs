using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    [SerializeField] Slider slider;
    [SerializeField] Image sliderColor;
    List<Organ> organs;

    void Start() {
        organs = new List<Organ>(Objects.organs.Values);
    }

    void Update() {
        slider.value = GetAverage() / GetDeathOrgans();
        sliderColor.color = Color.Lerp(Color.red, Color.green, slider.value / slider.maxValue);
    }

    float GetAverage() {
        return organs.Sum(x => x.Health) / organs.Count;
    }

    int GetDeathOrgans() {
        return organs.Where(x => x.Death).ToList().Count + 1;
    }

}
