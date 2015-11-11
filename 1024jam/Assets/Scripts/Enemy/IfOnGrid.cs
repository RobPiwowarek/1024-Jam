using UnityEngine;
using System.Collections;

public class IfOnGrid : MonoBehaviour {
	// Use this for initialization
	void Awake () {
        Debug.Log("DUPA");
		if (GameObject.FindGameObjectWithTag("GW").GetComponent<Game_Continuity>().grid) {
            this.GetComponent<Moving>().enabled = false;
            Debug.Log(GetComponent<Moving>().enabled);
		}
	}

}
