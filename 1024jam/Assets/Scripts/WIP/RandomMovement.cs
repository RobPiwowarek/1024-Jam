using UnityEngine;
using System.Collections;

public class RandomMovement : MonoBehaviour {

    float amplitudeX = 50f;
    float amplitudeY = 20f;
    float frequencyX = 0.2f;
    float frequencyY = 0.4f;

	// Update is called once per frame
	   void Update () {
           float _new_x = amplitudeX * Mathf.Sin(2 * Mathf.PI * frequencyX * Time.time);
           float _new_y = amplitudeY * Mathf.Sin(2 * Mathf.PI * frequencyY * Time.time);           
           transform.position = new Vector3(_new_x, _new_y, 0);
       }
}
