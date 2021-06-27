using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {

    [SerializeField] int minDeathOrgans = 2;

    private void Start() {
        Time.timeScale = 1f;
        PauseMenu.GamePaused = false;
        Organ.OrganDied += OrganDied;
        GameEvents.current.OnGameLost += GameLost;
        GameEvents.current.OnGameWon += GameWon;
        SetRateOfDecay();
    }

    private void GameWon() {
        SceneManager.LoadScene("YouWin");
    }

    private void GameLost() {
        SceneManager.LoadScene("GameOver");
    }

    private void OrganDied(object sender, KeyValuePair<string, string> e) {
        if (CheckIfDead()) {
            GameEvents.current.GameLostTrigger();
        }
    }

    private bool CheckIfDead() {
        if (Objects.organs["brain"].Death || Objects.organs["heart"].Death || Objects.organs["liver"].Death)
            return true;
        if (KidLungNumber("kidney1", "kidney2") == 0 || KidLungNumber("lung1", "lung2") == 0)
            return true;
        if (NumberOfDeathOrgans() > minDeathOrgans)
            return true;
        return false;
    }

    // How many Kidneys or Lungs are alive
    private int KidLungNumber(string x, string y) {
        return (!Objects.organs[x].Death ? 1 : 0) + (!Objects.organs[y].Death ? 1 : 0);
    }

    private int NumberOfDeathOrgans() {
        return Objects.organs.Values.Where(x => x.Death).ToList().Count;
    }

    private void SetRateOfDecay() {
        foreach(Organ or in Objects.organs.Values) {
            or.decayRate = Random.Range(0.01f, 0.05f);
        }
    }
}
