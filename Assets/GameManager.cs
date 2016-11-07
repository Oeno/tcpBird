using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;

    int score = 0;  // 점수
    bool isCollide = false; // 충돌 여부 확인
    float optSpeed = 0f;  // 벽에 시간에 따른 추가 속도 부여
    Text scoreText;
    public Queue<GameObject> wallQueue = new Queue<GameObject>();

    void Awake() {
        Instance = this;
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
        optSpeed += Time.deltaTime;
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

    public float getOptSpeed()
    {
        return optSpeed;
    }
}
