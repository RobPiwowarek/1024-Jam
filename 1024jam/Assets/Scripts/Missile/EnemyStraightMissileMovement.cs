using UnityEngine;
using System.Collections;

public class EnemyStraightMissileMovement : MonoBehaviour {
    public float speed = 0.5f;
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - speed);
	}
}
