using UnityEngine;
using System.Collections;

public class MainPlayer : MonoBehaviour {
    // Use this for initialization
    void Start () {
        StartCoroutine("Fade");
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(3 * Vector2.left * Time.deltaTime);
	}

    IEnumerator Fade() {
        for (float f=1f; f>=0; f-=0.2f) {
            Color c = GetComponent<Renderer>().material.color;
            c.a = f;
            GetComponent<Renderer>().material.color = c;
            yield return new WaitForSeconds(1f);
        }
    }
}
