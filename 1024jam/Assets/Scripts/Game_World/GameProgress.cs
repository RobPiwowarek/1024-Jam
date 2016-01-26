using UnityEngine;
using System.Collections;

public class GameProgress : MonoBehaviour {
	public int chapter = 0;
	public float[] times_required = new float[7] {3.0f, 0.0f, 3.0f, 0.0f, 4.0f, 0.0f, 15.0f};
	public GameObject Messager;
	public GameObject Mothership;
	public GameObject EnemyGridSpawner;
	bool nextChapter = false;
	public GameObject EnemyGroupSpawner;
	public bool grid = false;

	void Start () {
		StartCoroutine ("History", times_required[chapter]);
	}
	
	// Update is called once per frame
	void Update () {
		if (nextChapter) {
			nextChapter = false;		
            
			if(chapter<=5){
				chapter++;
				Debug.Log("Chapter: " + chapter); 
				StartCoroutine ("History", times_required[chapter]);
			}            
			//Debug.Log("NextChapter");
		}
	}

	IEnumerator History(float time_required){
		switch (chapter) {
		case 0:{
			Messager.GetComponent<Messaging>().Message(chapter);
			yield return new WaitForSeconds(time_required);
			nextChapter = true;
			break;
		}
		case 1: {
			/*
			int i = (int)time_required;
			EnemyGroupSpawner.GetComponent<EnemySpawner>().SpawnEnemies(4,1);
			yield return new WaitForSeconds(Random.Range(0.5f,2.5f));
			EnemyGroupSpawner.GetComponent<EnemySpawner>().SpawnEnemies(4,1);
			yield return new WaitForSeconds(Random.Range(0.5f,2.5f));
			EnemyGroupSpawner.GetComponent<EnemySpawner>().SpawnEnemies(4,1);
			yield return new WaitForSeconds(Random.Range(0.5f,2.5f));
			*/
			nextChapter = true;

			break;
		}
		case 2: {
			/*
			Messager.GetComponent<Messaging>().Message(chapter);
			yield return new WaitForSeconds(time_required);

			*/
			nextChapter = true;
			break;
		}
		case 3: {
		
			nextChapter = true;
			break;
		}
		case 4: {
/*
			Messager.GetComponent<Messaging>().Message(chapter);

			yield return new WaitForSeconds(time_required);
*/
			nextChapter = true;

			break;
		}
		case 5: {
			grid = true;
			EnemyGridSpawner.GetComponent<EnemyGroupSpawner>(). GenerateSingleEnemyGroup(0, 6);

			nextChapter = true;
			break;
		}
		case 6: {
			grid = false;
			Instantiate(Mothership,new Vector2(0.0f,16.0f),Quaternion.identity);
			//Next_chapter = true;
			break;
		}
		}
	}
}
