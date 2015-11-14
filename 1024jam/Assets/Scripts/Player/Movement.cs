using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	// Update is called once per frame
    PlayerStatistics stats;

    void Start(){
        stats = GetComponent<PlayerStatistics>();
    }

	void Update () {
        float input = Input.GetAxis("Horizontal");
        float speed = input * stats.HorizontalSpeed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed * Time.deltaTime, GetComponent<Rigidbody2D>().velocity.y);
	}
}
