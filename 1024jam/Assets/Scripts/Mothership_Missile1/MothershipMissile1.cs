using UnityEngine;
using System.Collections;

public class MothershipMissile1 : MonoBehaviour {

	public float speed = 0.25f;
	public float multiplier = 1.25f;
	public float XMovement = 0;
	public float XMultiplier = 0.02f;

	// Use this for initialization
	void Start () {
		StartCoroutine ("Attack");
		XMovement = -0.35f*XMultiplier;;//Random.Range (-0.35f,0.35f)*XMultiplier;
	}

	IEnumerator Attack(){

		while (true) {
			transform.position = new Vector2(transform.position.x+XMovement,transform.position.y-speed*Time.deltaTime);
			speed *= multiplier;
			yield return null;
		}
	}

}
