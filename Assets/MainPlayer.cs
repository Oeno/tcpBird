using UnityEngine;
using System.Collections;

public class MainPlayer : MonoBehaviour {

    private GameObject wall;

    // Use this for initialization
    void Start () {
        wall = GameObject.FindWithTag("WallSprite");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(3*Vector2.left * Time.deltaTime);
	}
}
