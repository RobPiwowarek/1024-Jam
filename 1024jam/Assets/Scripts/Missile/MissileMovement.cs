using UnityEngine;
using System.Collections;

public class MissileMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	   
	}
	public int ID = 0;
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1);
	}
}
