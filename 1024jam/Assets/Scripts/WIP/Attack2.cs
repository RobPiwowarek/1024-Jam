using UnityEngine;
using System.Collections;

public class Attack2 : MonoBehaviour {

    public GameObject bullet;
    public GameObject[] spawnPoints;
    float cooldownStart1 = 0f;
    float cooldown1 = 5f;

    // Update is called once per frame
    void Update()
    {
        if (cooldownStart1 + cooldown1 < Time.time)
        {
            CoolAttack();
            cooldownStart1 = Time.time;
        }

    }

    void CoolAttack()
    {
        GameObject[] _temp = new GameObject[4];
        for (int i = 0; i < _temp.Length; i++)
        {
            _temp[i] = Instantiate(bullet, spawnPoints[i].transform.position, spawnPoints[i].transform.rotation) as GameObject;
            _temp[i].GetComponent<Rigidbody2D>().AddForce(Vector2.right * 5000f);
            Destroy(_temp[i], 4f);
       

        }
         
    }
}
