using UnityEngine;
using System.Collections;

public class MainPlayer : MonoBehaviour {
    public float speed = 10f;
    public float destroyTime = 5f;
    public float yIntervalRange = 5f;

    public Transform topWallTr;
    public Transform btmWallTr;

    private bool check;
    private float birdX;

    void Start () {
        float yRange = Random.Range(yIntervalRange, 2* yIntervalRange);
        topWallTr.localPosition = new Vector3(0, yRange, 0);
        btmWallTr.localPosition = new Vector3(0, -yRange, 0);
        check = false;
        birdX = GameObject.Find("junkratBird").transform.position.x;

        StartCoroutine(DestroyObj());
        StartCoroutine(CollideListener());
    }
	
	void Update () {
        transform.Translate(speed * Vector3.left * Time.deltaTime);
    }

    IEnumerator DestroyObj() {
        yield return new WaitForSeconds(destroyTime);

        Destroy(this.gameObject);
    }

    IEnumerator CollideListener() {
        while (true) {
            float wallX = transform.position.x;

            if (wallX < birdX+2.5f && wallX > birdX-2.5f && GameManager.Instance.IsCollide()) {
                check = true;
            }

            if (wallX <= birdX-2.5f && !check) {
                GameManager.Instance.AddScore();
                check = true;
            }

            yield return null;
        }
    }
}