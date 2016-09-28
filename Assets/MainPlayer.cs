using UnityEngine;
using System.Collections;

public class MainPlayer : MonoBehaviour {
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(3 * Vector2.left * Time.deltaTime);
	}
}
