using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderOrganController : MonoBehaviour
{

    [SerializeField] Image image;
    [SerializeField] Organ organ;
    [SerializeField] Slider slider;
    [SerializeField] Image sliderColor;
    [SerializeField] Sprite sprite;


    [HideInInspector] public float HealthOrgan { get; set; }

    private void Start()
    {
        image.sprite = organ.GetComponent<Image>().sprite;
        slider.maxValue = organ.maxHealth;
        slider.value = organ.Health;
    }

    private void Update()
    {
        image.sprite = organ.Death ? sprite : organ.GetComponent<Image>().sprite;
        sliderColor.color = Color.Lerp(Color.red, Color.green, slider.value / slider.maxValue);
        slider.value = organ.Health;
    }
}