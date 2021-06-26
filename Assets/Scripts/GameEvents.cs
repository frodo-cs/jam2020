using System;
using UnityEngine;

public class GameEvents : MonoBehaviour {
    public static GameEvents current;
    private void Awake() {
        current = this;
    }

    public event Action OnGameWon;
    public event Action OnOrganDied;
    public event Action OnGameLost;

    public void GameWonTrigger() {
        if (OnGameWon != null) {
            OnGameWon.Invoke();
        }
    }

    public void OrganDiedTrigger() {
        if (OnOrganDied != null) {
            OnOrganDied.Invoke();
        }
    }

    public void GameLostTrigger() {
        if (OnGameLost != null) {
            OnGameLost.Invoke();
        }
    }
}

