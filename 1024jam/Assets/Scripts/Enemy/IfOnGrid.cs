using UnityEngine;
using System.Collections;

public class IfOnGrid : MonoBehaviour {
	public GameObject Game_World;
	// Use this for initialization
	void Start () {
		if (Game_World.GetComponent<Game_Continuity> ().grid == true) {
			this.GetComponent<Moving>().enabled = false;
		}
	}

}
