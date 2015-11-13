using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject[] enemies = new GameObject[10];

	public void SpawnEnemies(int quantity, int type){

        int range = ChooseRange(type);
        
        while (quantity-- > 0)
        {
            Vector2 spawnPosition = new Vector2(Random.Range(-8.0f, 8.0f), transform.position.y);
            Instantiate(enemies[Random.Range(0+range, 3+range+1)], spawnPosition, Quaternion.identity);
        }

	}

    int ChooseRange(int type)
    {
        if (type == 2) return 3;
        else if (type == 3) return 6;

        return 0; // if (type == 1)
    }
}
