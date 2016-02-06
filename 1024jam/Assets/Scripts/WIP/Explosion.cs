using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
    public GameObject bullet;

	// Use this for initialization
	void Start () {
        Invoke("Explode", 2f);
        Destroy(this.gameObject, 2f);
	}

    void Explode()
    {
        GameObject[] _temp = new GameObject[8];
        for (int i = 0; i < _temp.Length; i++)
        {
            _temp[i] = Instantiate(bullet, this.transform.position, this.transform.rotation) as GameObject;
            _temp[i].GetComponent<Rigidbody2D>().AddForce(0.25f*new Vector2(Mathf.Sin(Mathf.PI/4*i), Mathf.Cos(Mathf.PI/4*i)));
            Destroy(_temp[i], 2f);
        }
    }
}
