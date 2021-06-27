using System.Collections.Generic;
using UnityEngine;

public class RandomEvent : MonoBehaviour {

    [SerializeField] Clock clock;
    [SerializeField] float exponential;
    [SerializeField] float rate;
    List<Organ> list;
    private float min = 1;

    private void Start() {
        InvokeRepeating("FireEvent", rate, rate);
        list = new List<Organ>(Objects.organs.Values);
    }

    private void Update() {
        min += Time.deltaTime; 
    }

    private void FireEvent() {
        int n = Random.Range(0, GetNumber());
        int min = (int)(this.min + (clock.maxTime - clock.time));
        if (n > min) {
            list[Random.Range(0, Objects.organs.Values.Count)].IncrementDecayRate();
        }
    }

    private int GetNumber() {
        return (int)Mathf.Pow(1 + clock.maxTime - clock.time, exponential);
    }
}
