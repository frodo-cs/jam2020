using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour
{
    [SerializeField] AudioSource source;
    [SerializeField] Slider bloodCount;
    [SerializeField] Slider bloodToGive;
    
    public void OnButtonPress(string name)
    {
        
        bloodCount.value -= bloodToGive.value;
        float sum = Organs.organs[name].Health + bloodToGive.value;
        if (sum > Organs.organs[name].maxHealth)
        {
            Organs.organs[name].Health = Organs.organs[name].maxHealth;
        }
        else
        {
            Organs.organs[name].Health = sum;
        }
    }

    public void GeneralButton()
    {
        source.Play();

    }

}
