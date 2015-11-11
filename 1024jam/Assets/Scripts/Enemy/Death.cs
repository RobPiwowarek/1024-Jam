using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {



	void OnTriggerEnter2D(Collider2D col){

		if (this.GetComponent<Moving> ().ID == col.gameObject.GetComponent<Move> ().ID) {
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		} else {
			Destroy (col.gameObject);
		
		}
	}

}
