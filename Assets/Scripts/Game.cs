using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Game : MonoBehaviour {

    [SerializeField] int minDeathOrgans = 2;
    [SerializeField] AudioSource source;

    private void Start() {
        GameEvents.current.OnOrganDied += OrganDied;
        GameEvents.current.OnGameLost += GameLost;
        GameEvents.current.OnGameWon += GameWon;
        SetRateOfDecay();
    }

    private void GameWon() {
        Debug.Log("Gano");
    }

    private void GameLost() {
        Debug.Log("Perdio");
    }

    private void OrganDied() {
        source.Play();
        if (CheckIfDead()) {
            GameEvents.current.GameLostTrigger();
        }
    }

    private bool CheckIfDead() {
        if (Organs.organs["brain"].Death || Organs.organs["heart"].Death || Organs.organs["liver"].Death)
            return true;
        if (KidLungNumber("kidney1", "kidney2") == 0 || KidLungNumber("lung1", "lung2") == 0)
            return true;
        if (NumberOfDeathOrgans() > minDeathOrgans)
            return true;
        return false;
    }

    // How many Kidneys or Lungs are alive
    private int KidLungNumber(string x, string y) {
        return (!Organs.organs[x].Death ? 1 : 0) + (!Organs.organs[y].Death ? 1 : 0);
    }

    private int NumberOfDeathOrgans() {
        return Organs.organs.Values.Where(x => x.Death).ToList().Count;
    }

    private void SetRateOfDecay() {
        foreach(Organ or in Organs.organs.Values) {
            or.decayRate = Random.Range(0.01f, 0.03f);
        }
    }
}
