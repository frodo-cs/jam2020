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
    }

    private void OrganDyingText(object sender, string name) {
        SetSentence($"{count} We are losing connection to {name}");    
        text.text = string.Join("\n", sentences);
        count++;
    }

    private void UnitsSend(object sender, KeyValuePair<int, string> unit) {
        SetSentence($"{unit.Key} units sent to {unit.Value}");
        text.text = string.Join("\n", sentences);
    }

    private void SetSentence(string sentece) {
        sentences.Insert(0, sentece);    
    }

    void Update() {

    }
}
