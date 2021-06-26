using TMPro;
using UnityEngine;

public class Clock : MonoBehaviour {

    [SerializeField] TextMeshProUGUI textTime;
    [SerializeField] int maxTime;
    float time;

    private void Start() {
        time = maxTime;
        textTime.text = $"{maxTime}";
    }

    private void Update() {
        if(time > 0) {
            time -= Time.deltaTime;
            textTime.text = time.ToString("0");
        } else {
            textTime.text = "0";
            GameEvents.current.GameWonTrigger();
        }
    }

}
