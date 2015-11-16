using UnityEngine;
using System.Collections;

public class Debris_Action : MonoBehaviour {

	public float lifetime = 5;
	// Use this for initialization
	void Start () {


		foreach(Transform el in transform){
			el.GetComponent<Rigidbody2D>().angularDrag = Random.Range(0.1f,0.75f);
			el.GetComponent<Rigidbody2D>().AddTorque(Random.Range(15.0f,60.0f));
		}



	}

	void Update(){
		lifetime -= Time.deltaTime;
		if (lifetime < 0)
			Destroy(this.gameObject);
	}
}
