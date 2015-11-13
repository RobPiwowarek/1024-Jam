using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {



	void OnTriggerEnter2D(Collider2D col){

		if (this.GetComponent<EnemyMovement> ().ID == col.gameObject.GetComponent<MissileMovement> ().ID) {
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		} else {
			Destroy (col.gameObject);
		
		}
	}

}
