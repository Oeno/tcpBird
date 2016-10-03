using UnityEngine;
using System.Collections;

public class CreateWall : MonoBehaviour {
    public GameObject wallPrefab;
    public float spawnTime = 3.0f;
    public float yRange = 5.0f;

    void Start () {
        StartCoroutine(Spawner());
    }
    
    void Update(){
    }

    IEnumerator Spawner() {
        while (true)
        {
            var yRandom = Random.Range(-yRange, yRange);
            Instantiate(wallPrefab, new Vector3(25, yRandom, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}