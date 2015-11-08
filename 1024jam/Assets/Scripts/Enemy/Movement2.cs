using UnityEngine;
using System.Collections;

public class Movement2 : MonoBehaviour {
    //TODO:
    //sekwencja: lewa -> prawa; prawa -> lewa; dół -> lewy górny -> dół; to samo w prawo etc.
    // w każdym przypadku leci około sekunde w kazda strone,


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Quaternion moveAng = Quaternion.Euler(-300, 100, 0);
        // angles are in degrees, 000 is due north, Clockwise, left-handed.
        // 315 around x is North and up 45.
        transform.position += moveAng * (Vector3.forward * 0.125f);
        // Use this for initialization
	}
}
