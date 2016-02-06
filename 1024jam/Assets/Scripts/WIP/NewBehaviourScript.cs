using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject parent;

    void Update()
    {
        transform.Rotate(transform.up * 200 * Time.deltaTime);
        transform.RotateAround(parent.transform.position, Vector3.back, 500 * Time.deltaTime);
    }
}
