using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;

    int score = 0;

    void Awake() {
        Instance = this;
    }

    public void AddScore() {
        score++;
        Debug.Log("Score: " + score);
    }
}
