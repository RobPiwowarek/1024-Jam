using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject parent;
    float _angle = 0.05f;

    void Update()
    {
        transform.Rotate(transform.up * 200 * Time.deltaTime);
        transform.RotateAround(parent.transform.position, Vector3.back, 500 * Time.deltaTime);
    }
}
