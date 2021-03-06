﻿using UnityEngine;
using System.Collections;

public class MainPlayer : MonoBehaviour {
    public float speed = 10f;
    public float destroyTime = 5f;
    public float yIntervalRange = 5f;

    public Transform topWallTr;
    public Transform btmWallTr;

    private bool check;
    private float birdX;
    private float optSpeed;

    void Start () {
        Init();
        birdX = GameObject.Find("junkratBird").transform.position.x;
        optSpeed = GameManager.Instance.getOptSpeed();

        StartCoroutine(DestroyObj());
        StartCoroutine(CollideListener());
    }

    void Init() {
        float yRange = Random.Range(yIntervalRange, 2* yIntervalRange);
        check = false;
        topWallTr.localPosition = new Vector3(0, yRange, 0);
        btmWallTr.localPosition = new Vector3(0, -yRange, 0);

        // float yRandom = Random.Range(-yRange, yRange);
        transform.position = new Vector3(25, transform.position.y, transform.position.z);
    }
	
	void Update () {
        transform.Translate((speed+optSpeed) * Vector3.left * Time.deltaTime);
    }

    IEnumerator DestroyObj() {
        while (true) {
            yield return new WaitForSeconds(destroyTime);
             Init();
             this.gameObject.SetActive(false);
             GameManager.Instance.wallQueue.Enqueue(this.gameObject);
        }
        // Destroy(this.gameObject);
    }

    IEnumerator CollideListener() {
        while (true) {
            float wallX = transform.position.x;

            if (wallX < birdX+2.5f && wallX > birdX-2.5f && GameManager.Instance.IsCollide()) {
                check = true;
            }

            if (wallX <= birdX-2.5f && !check && !GameManager.Instance.IsCollide()) {
                GameManager.Instance.AddScore();
                check = true;
            }

            yield return null;
        }
    }
}