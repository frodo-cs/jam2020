using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    [SerializeField] Slider slider;
    List<Organ> organs;

    void Start() {
        organs = new List<Organ>(Objects.organs.Values);
    }

    void Update() {
        slider.value = GetAverage() / GetDeathOrgans();
    }

    float GetAverage() {
        return organs.Sum(x => x.Health) / organs.Count;
    }

    int GetDeathOrgans() {
        return organs.Where(x => x.Death).ToList().Count;
    }

}
