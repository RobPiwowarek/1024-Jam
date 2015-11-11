using UnityEngine;
using System.Collections;

public class Game_World_1 : MonoBehaviour {

	// Use this for initialization


	void OnTriggerExit2D(Collider2D col){
		DestroyObject(col.gameObject);
	}
	// Update is called once per frame

}
