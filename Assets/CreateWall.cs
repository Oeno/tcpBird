using UnityEngine;
using System.Collections;

public class CreateWall : MonoBehaviour {
    public GameObject wallPrefab;
    public float spawnTime = 3f;
    public float yRange = 5f;

    void Start () {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner() {
        while (true) {
            float yRandom = Random.Range(-yRange, yRange);

            Instantiate(wallPrefab, new Vector3(25, yRandom, 0), Quaternion.identity);

            yield return new WaitForSeconds(spawnTime);
        }
    }
}