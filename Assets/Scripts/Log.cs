using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Log : MonoBehaviour {

    [SerializeField] TextMeshProUGUI text;
    List<string> sentences;
    int count = 0;

    void Start() {
        sentences = new List<string>();
        Organ.OrganDying += OrganDyingText;
        Organ.OrganDied += OrganDiedText;
        Controls.UnitsSend += UnitsSend;
    }

    private void OrganDiedText(object sender, KeyValuePair<string, string> pair) {
        SetText($"{count}: {pair.Value} lost");
    }

    private void OrganDyingText(object sender, string name) {
        SetText($"{count}: We are losing connection to {name}");    
    }

    private void UnitsSend(object sender, KeyValuePair<int, string> unit) {
        SetText($"{count}: {unit.Key} units sent to {unit.Value}");
    }

    private void SetText(string sentece) {
        sentences.Insert(0, sentece);
        text.text = string.Join("\n", sentences);
        count++;
    }
}
