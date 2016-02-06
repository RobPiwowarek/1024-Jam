using UnityEngine;
using System.Collections;

public class BombSpawn : MonoBehaviour {

    public GameObject bullet;
    float cooldownStart1 = 0.5f;
    float cooldown1 = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if (cooldownStart1 + cooldown1 < Time.time)
        {
            DropTheBomb();
            cooldownStart1 = Time.time;
        }

    }

    void DropTheBomb()
    {
        GameObject _temp = Instantiate(bullet, this.transform.position, Quaternion.identity) as GameObject;
        //destroyed in explosion script
    }
}
