using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {
    public GameObject missile;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(missile, new Vector3(transform.position.x, transform.position.y+1), Quaternion.identity);
        }
	}
}
