using UnityEngine;
using System.Collections;

public class CreateWall : MonoBehaviour {
	public GameObject wall;
	float delayTime;	// 생성시간
	float height;
  	float width;

	// Use this for initialization
	void Start () {
		delayTime = 5.0f;	// 생성시간
		height = 2 * Camera.main.orthographicSize;
		width = 2 * Camera.main.orthographicSize * Camera.main.aspect;
	}
	
	// Update is called once per frame
	void Update () {
		delayTime -= Time.deltaTime;
		Vector2 position = new Vector2(width/2, Random.Range(-height, height));

		if (delayTime <= 0f) {
			CreateWall clone = Instantiate(wall, position, Quaternion.identity) as CreateWall;
			Destroy(this);
		}
	}
}