using UnityEngine;
using System.Collections;

public class CreateWall : MonoBehaviour {
	public GameObject wall;
	float delayTime = 5.0f;	// 생성시간

	// Use this for initialization
	void Start () {
    // 	for (int y = 0; y < 5; y++) {
    //     	Instantiate(wall, new Vector2(0, y), Quaternion.identity);
	// 	}
	}
	
	// Update is called once per frame
	void Update () {
		delayTime -= Time.deltaTime;

		if (delayTime <= 0) {
			GameObject wall2 = Instantiate(wall.gameObject, new Vector2(0,0), Quaternion.identity) as GameObject;
			Destroy(this.gameObject);
		}
	}
}