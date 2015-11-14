using UnityEngine;
using System.Collections;

public class EnemyStraightAttack : MonoBehaviour {
    public GameObject missile;
    public float cooldownInSeconds;
    float nextAttack = 0.0f;
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextAttack)
        {
            nextAttack = Time.time + cooldownInSeconds;
            Instantiate(missile, new Vector3(transform.position.x, transform.position.y - 1), Quaternion.identity);
        }
        

	}
}
