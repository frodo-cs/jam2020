using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrganController : MonoBehaviour
{

    [SerializeField] Image image;
    [SerializeField] Sprite[] sprites;
    [SerializeField] Slider slider;
    [SerializeField] Image sliderColor;

    public int maxHealthOrgan = 100;
    public int minHealthOrgan = 0;

    [Range(0.0f, 0.1f)]
    public float deterRate = 0.01f;

    [HideInInspector] public float HealthOrgan { get; set; }

    private void Start()
    {
        image.sprite = sprites[0];
        HealthOrgan = maxHealthOrgan;
        slider.value = HealthOrgan;
        
    }

    private void Update()
    {
        if (HealthOrgan > minHealthOrgan)
        {
            HealthOrgan -= deterRate;
            slider.value = HealthOrgan;
            if (HealthOrgan < maxHealthOrgan / 4)
            {
                sliderColor.color = new Color32(154, 17, 24, 255);
                image.sprite = sprites[3];
            }
            else if (HealthOrgan < 2 * maxHealthOrgan / 4)
            {
                sliderColor.color = new Color32(226, 108, 0, 255);
                image.sprite = sprites[2];
            }
            else if (HealthOrgan < 3 * maxHealthOrgan / 4)
            {
                sliderColor.color = new Color32(241, 231, 15, 255);
                image.sprite = sprites[1];
            }
            else
            {
                image.sprite = sprites[0];
            }
        }
        else
        {
            image.sprite = sprites[4];
        }
        
    }
}