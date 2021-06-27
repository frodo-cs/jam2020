using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BloodToGive : MonoBehaviour
{

    [SerializeField] Slider slider;
    [SerializeField] Slider bloodCount;
    [SerializeField] TextMeshProUGUI text;

    public void FixedUpdate()
    {
        slider.maxValue = bloodCount.value;
        text.text = $"{slider.value}";
    }
}
