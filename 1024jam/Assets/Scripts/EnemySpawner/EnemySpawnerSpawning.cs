using UnityEngine;
using System.Collections;

public class EnemySpawnerSpawning : MonoBehaviour {

	public GameObject Enemy;
	// Use this for initialization
	void Start () {
		Instantiate (Enemy,new Vector3(Random.Range(-3.0f, 3.0f),transform.position.y),Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
