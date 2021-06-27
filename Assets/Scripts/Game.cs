using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Game : MonoBehaviour {

    [SerializeField] List<Organ> organs; // 9
    [SerializeField] int minDeathOrgans = 2;
    [SerializeField] AudioSource source;
    enum O { BLADDER, KIDNEY_1, KIDNEY_2, LUNG_1, LUNG_2, HEART, BRAIN, STOMACH, LIVER }

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
        if (organs[(int)O.BRAIN].Death || organs[(int)O.HEART].Death || organs[(int)O.LIVER].Death)
            return true;
        if (KidLungNumber((int)O.KIDNEY_1, (int)O.KIDNEY_2) == 0 || KidLungNumber((int)O.LUNG_1, (int)O.LUNG_2) == 0)
            return true;
        if (NumberOfDeathOrgans() > minDeathOrgans)
            return true;
        return false;
    }

    // How many Kidneys or Lungs are alive
    private int KidLungNumber(int x, int y) {
        return (!organs[x].Death ? 1 : 0) + (!organs[y].Death ? 1 : 0);
    }

    private int NumberOfDeathOrgans() {
        return organs.Where(x => x.Death).ToList().Count;
    }

    private void SetRateOfDecay() {
        foreach(Organ or in organs) {
            or.decayRate = Random.Range(0.01f, 0.03f);
        }
    }
}
