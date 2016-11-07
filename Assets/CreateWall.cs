using UnityEngine;
using System.Collections;

public class CreateWall : MonoBehaviour {
    public GameObject wallPrefab;
    public float spawnTime = 3f;
    public float yRange = 5f;
    public int numWall = 5;

    void Start () {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner() {
        for (int i=0; i<numWall; i++) {
            float yRandom = Random.Range(-yRange, yRange);

            Instantiate(wallPrefab, new Vector3(25, yRandom, 0), Quaternion.identity);

            yield return new WaitForSeconds(spawnTime);
        }
    }
}