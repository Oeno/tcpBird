using UnityEngine;
using System.Collections;

public class BirdController : MonoBehaviour
{
    public float speed = 15f;
    public KeyCode upKey = KeyCode.Space;

    void Start() {
        StartCoroutine(KeyListener());
    }

    void Update() {
        transform.Translate(speed * Vector3.down * Time.deltaTime);
    }

    IEnumerator KeyListener() {
        while (true) {
            if (Input.GetKey(upKey)) {
                transform.Translate(2 * speed * Vector3.up * Time.deltaTime);
            }
            yield return null;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Collision");
    }
}
