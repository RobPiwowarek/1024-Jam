using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter2D(Collision2D col){

		if(this.GetComponent<Moving>().ID == col.gameObject.GetComponent<Move>().ID){

			Destroy(col.gameObject);
			Destroy(this.gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
