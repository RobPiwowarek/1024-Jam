using UnityEngine;
using System.Collections;

public class EnemySpawnerSpawning : MonoBehaviour {

	public GameObject[] Enemies = new GameObject[10];


	public void SpawnEnemies(int quantity, int type){

		switch (type) {
		case 1:{
			while(quantity>0){
				Instantiate(Enemies[(int)Random.Range(0.0f,3.0f)],new Vector2(Random.Range(-8.0f,8.0f),transform.position.y),Quaternion.identity);
				quantity--;

			}
			break;
		}
		case 2:{
			while(quantity>0){
				Instantiate(Enemies[(int)Random.Range(4.0f,6.0f)],transform.position,Quaternion.identity);
				quantity--;

			}
			break;
		}
		case 3:{
			while(quantity>0){
				Instantiate(Enemies[(int)Random.Range(7.0f,9.0f)],transform.position,Quaternion.identity);
				quantity--;
			}
				break;
			
		}
		}
	}
}
