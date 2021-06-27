using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objects : MonoBehaviour {
    [SerializeField] List<Organ> o; // 9
    [SerializeField] List<Button> b; // 9

    public static Dictionary<string, Organ> organs;
    public static Dictionary<string, Button> buttons;

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

        buttons = new Dictionary<string, Button>();
        buttons.Add("bladder", b[0]);
        buttons.Add("kidney1", b[1]);
        buttons.Add("kidney2", b[2]);
        buttons.Add("lung1", b[3]);
        buttons.Add("lung2", b[4]);
        buttons.Add("heart", b[5]);
        buttons.Add("brain", b[6]);
        buttons.Add("stomach", b[7]);
        buttons.Add("liver", b[8]);
    }
}
