using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class CreateWall : MonoBehaviour {
    public GameObject wallPrefab;
    public float spawnTime = 3f;
    public float yRange = 5f;
    public int numWall = 10;

    void Start () {
        InitWall(numWall);
        StartCoroutine(Spawner());
    }

    void InitWall(int num) {
        for (int i=0; i<num; i++) {
            float yRandom = Random.Range(-yRange, yRange);
            GameObject wall = (GameObject)Instantiate(wallPrefab, new Vector3(25, yRandom, 0), Quaternion.identity);
            ReturnWall(wall);
        }
    }

    IEnumerator Spawner() {
        while (true) {
            GetWall();
            yield return new WaitForSeconds(spawnTime);
        }
    }

    public GameObject GetWall() {
        GameObject wall = GameManager.Instance.wallQueue.Dequeue();
        wall.SetActive(true);
        return wall;
    }

    public void ReturnWall(GameObject wall) {
        wall.SetActive(false);
        GameManager.Instance.wallQueue.Enqueue(wall);
    }
    
}