using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        float input = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(input * 1000 * Time.deltaTime, GetComponent<Rigidbody2D>().velocity.y);
	}
}
