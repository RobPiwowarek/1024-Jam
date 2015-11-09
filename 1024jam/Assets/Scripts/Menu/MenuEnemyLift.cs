using UnityEngine;
using System.Collections;

public class MenuEnemyLift : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        col.gameObject.transform.position = new Vector3(col.gameObject.transform.position.x, col.gameObject.transform.position.y + 50, col.gameObject.transform.position.z);
    }
}