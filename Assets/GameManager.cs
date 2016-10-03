using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public static GameManager   instance;

    int score = 0;

    void Awake()
    {
        instance = this;
    }

    public void AddScore()
    {
        score++;
        Debug.Log("Score: " + score);
    }
}
