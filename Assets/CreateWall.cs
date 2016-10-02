using UnityEngine;
using System.Collections;

public class CreateWall : MonoBehaviour {
	public GameObject wall;
    public GameObject emptyObj;
    public Transform _parent;
	float height;
    float width;

	// Use this for initialization
	void Start () {
        height = 2 * Camera.main.orthographicSize;
        width = 2 * Camera.main.orthographicSize * Camera.main.aspect;
        StartCoroutine(Spawner(5.0f, 2));
    }

    // Update is called once per frame
    void Update()
    {
        /*delayTime -= Time.deltaTime;
        Vector2 position = new Vector2(width / 2, Random.Range(-height, height));

        if (delayTime <= 0f)
        {
            CreateWall clone = Instantiate(wall, position, Quaternion.identity) as CreateWall;
            Destroy(this);
        }*/
    }

    IEnumerator Spawner(float time, int num)
    {
        yield return new WaitForSeconds(time);
        for (int i=0; i<num; i++) {
            Vector2 position = new Vector2(width / 2, Random.Range(-height, height));
            CreateWall clone = Instantiate(wall, position, Quaternion.identity) as CreateWall;
        }
    }
}