using UnityEngine;
using System.Collections;

public class MainPlayer : MonoBehaviour {
    // Use this for initialization
    void Start () {
        StartCoroutine(Stop(5.5f));
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(10 * Vector2.left * Time.deltaTime);
    }

    IEnumerator Stop(float time) {
        Destroy(this.gameObject, time);
        yield return null;
    }
}