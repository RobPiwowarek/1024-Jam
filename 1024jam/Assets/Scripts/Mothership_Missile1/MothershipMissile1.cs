using UnityEngine;
using System.Collections;

public class MothershipMissile1 : MonoBehaviour {

	public float speed = 0.25f;
	public float multiplier = 1.25f;
	public float speedmax = 10.0f;

	// Use this for initialization
	void Start () {
		StartCoroutine ("Attack");

	}

	IEnumerator Attack(){

		while (transform.position.y> -30.0f) {
			transform.position = new Vector2(transform.position.x,transform.position.y-speed*Time.deltaTime);
			if(speed<speedmax)
			speed *= multiplier;
			yield return null;
		}
		Destroy (this.gameObject);
	}

}
