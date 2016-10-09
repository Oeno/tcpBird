using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;

    int score = 0;
    bool isCollide = false;

    void Awake() {
        Instance = this;
    }

    public void AddScore() {
        score++;
        Debug.Log("Score: " + score);
    }

    public bool IsCollide() {
        return isCollide;
    }

    public void setIsCollide(bool isCollide) {
        this.isCollide = isCollide;
    }
}
