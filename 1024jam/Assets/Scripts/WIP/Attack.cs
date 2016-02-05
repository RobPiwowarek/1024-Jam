using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

    public GameObject target;
    public GameObject bullet;
    float cooldownStart1 = 0f;
    float cooldown1 = 2f;

	// Update is called once per frame
	void Update () 
    {
        if (cooldownStart1+cooldown1 < Time.time)
        {
            CoolAttack();
            cooldownStart1 = Time.time;
        }
            
	}

    void CoolAttack()
    {
        GameObject _temp = Instantiate(bullet, this.transform.position, Quaternion.identity) as GameObject;
        Vector3 trajektoria = target.transform.position - this.transform.position;
        _temp.GetComponent<Rigidbody2D>().AddForce(0.1f* new Vector3(target.transform.position.x - this.transform.position.x, target.transform.position.y - this.transform.position.y, 0f));
        GameObject.Destroy(_temp, 4f);
    }


}
