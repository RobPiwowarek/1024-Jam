using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {
    public GameObject[] missiles = new GameObject[10];
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            Instantiate(missiles[0], new Vector3(transform.position.x, transform.position.y+1), Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Instantiate(missiles[1], new Vector3(transform.position.x, transform.position.y + 1), Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Instantiate(missiles[2], new Vector3(transform.position.x, transform.position.y + 1), Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            Instantiate(missiles[3], new Vector3(transform.position.x, transform.position.y + 1), Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            Instantiate(missiles[4], new Vector3(transform.position.x, transform.position.y + 1), Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            Instantiate(missiles[5], new Vector3(transform.position.x, transform.position.y + 1), Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            Instantiate(missiles[6], new Vector3(transform.position.x, transform.position.y + 1), Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            Instantiate(missiles[7], new Vector3(transform.position.x, transform.position.y + 1), Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            Instantiate(missiles[8], new Vector3(transform.position.x, transform.position.y + 1), Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            Instantiate(missiles[9], new Vector3(transform.position.x, transform.position.y + 1), Quaternion.identity);
        }
	}
}
