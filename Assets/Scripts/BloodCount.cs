using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BloodCount : MonoBehaviour {

    [SerializeField] float rate = 5;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] Slider slider;
    [SerializeField] AudioSource source;

    public int maxBlood = 100;
    float currentBlood = 0;

    private void Start() {
        slider.maxValue = maxBlood;
        slider.value = currentBlood;
        text.text = $"{currentBlood}";
        InvokeRepeating("IncreaseBloodCount", rate, rate);
    }

    void IncreaseBloodCount() {
        if(currentBlood < maxBlood) {
            currentBlood++;
            text.text = $"{currentBlood}";
            slider.value = currentBlood;
            source.Play();
        }     
    }
}
