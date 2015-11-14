using UnityEngine;
using System.Collections;

public class IfOnGrid : MonoBehaviour {
	// Use this for initialization
	void Awake () {
		if (GameObject.FindGameObjectWithTag("GW").GetComponent<GameProgress>().grid) {
            this.GetComponent<EnemyMovement>().enabled = false;
            Debug.Log(GetComponent<EnemyMovement>().enabled);
		}
	}

}
