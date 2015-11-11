using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour {
	public int ID = 0;
	public float smoothness = 1;
	bool routine = false;
	Vector2 target = new Vector2 (0, 3);
	public float threshold = 0.05f;
	//public GameObject Player;
	//public GameObject missile;
	public float Range_xmin = -3.0f;
	public float Range_xmax = 3.0f;
	public float Range_ymin = 0.0f;
	public float Range_ymax = 5.50f;
	// Use this for initialization


	void Start () {

		if (ID > 3) {
			StartCoroutine ("Descend");
		} else {
			StartCoroutine("Rocket");

		}

	}
	
	// Update is called once per frame
	void Update () {
		if (routine == true) {
			//StopCoroutine("Move_Randomly");
			routine  = false;
			target = new Vector2(Random.Range(Range_xmin,Range_xmax),Random.Range(Range_ymin,Range_ymax));
			StartCoroutine("Move_Randomly", target);
		}
	
	}

	IEnumerator Move_Randomly(Vector2 target){
		while (Vector2.Distance(transform.position, target)>threshold) {
			transform.position = Vector2.Lerp(transform.position,target,smoothness*Time.deltaTime);
			yield return null;

		}
		routine = true;

	}

	IEnumerator Descend()
	{
		float w = 0.0f;
		while (transform.position.y>7) {
			w = Time.deltaTime*4;
			transform.position = new Vector2(transform.position.x,transform.position.y-w);
			yield return null;
		}

		routine = true;
	}


	IEnumerator Rocket()
	{
		float w = 10.0f;
		while (true) {
			w = Time.deltaTime * 4;
			transform.position = new Vector2 (transform.position.x, transform.position.y - w);
			yield return null;
		}

	}


}
