using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Log : MonoBehaviour {

    [SerializeField] TextMeshProUGUI text;
    string[] sentences = { "", "" };

    void Start() {
        Organ.OrganDying += OrganDyingText;
    }

    private void OrganDyingText(object sender, string name) {
        SetSentence($"We are losing connection to {name}");    
        text.text = string.Join("\n", sentences);
    }

    private void UnitsSend(object sender, KeyValuePair<int, string> unit) {
        SetSentence($"{unit.Key} units sent to {unit.Value}");
        text.text = string.Join("\n", sentences);
    }

    private void SetSentence(string sentece) {
        if (string.Equals("", sentences[0])) {
            sentences[0] = sentece;
        } else {
            sentences[0] = sentences[1];
            sentences[1] = sentece;
        }
    }

    void Update() {

    }
}
