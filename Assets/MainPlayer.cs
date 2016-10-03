﻿using UnityEngine;
using System.Collections;

public class MainPlayer : MonoBehaviour {
    public float speed = 10;
    public float destroyTime = 5.0f;
    public float yIntervalRange = 5.0f;

    public Transform topWallTr;
    public Transform btmWallTr;

    void Start () {
        var yRange = Random.Range(yIntervalRange, 2* yIntervalRange);
        topWallTr.localPosition = new Vector3(0, yRange, 0);
        btmWallTr.localPosition = new Vector3(0, -yRange, 0);

        StartCoroutine(DestroyObj());
    }
	
	void Update () {
        transform.Translate(speed * Vector2.left * Time.deltaTime);
    }

    IEnumerator DestroyObj() {
        yield return new WaitForSeconds(destroyTime);
        GameManager.instance.AddScore();
        Destroy(gameObject);
    }
}