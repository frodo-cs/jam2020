using System.Collections.Generic;
using UnityEngine;

public class Organs : MonoBehaviour {
    [SerializeField] List<Organ> o; // 9

    public static Dictionary<string, Organ> organs;

    private void Awake() {
        organs = new Dictionary<string, Organ>();
        organs.Add("bladder", o[0]);
        organs.Add("kidney1", o[1]);
        organs.Add("kidney2", o[2]);
        organs.Add("lung1", o[3]);
        organs.Add("lung2", o[4]);
        organs.Add("heart", o[5]);
        organs.Add("brain", o[6]);
        organs.Add("stomach", o[7]);
        organs.Add("liver", o[8]);
    }
}
