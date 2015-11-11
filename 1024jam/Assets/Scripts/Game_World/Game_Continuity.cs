using UnityEngine;
using System.Collections;

public class Game_Continuity : MonoBehaviour {
	public int chapter = 0;
	public float[] times_required = new float[6] {3.0f, 0.0f, 3.0f, 0.0f, 4.0f, 0.0f};
	public GameObject Messager;
	public GameObject EnemyGridSpawner;
	bool Next_chapter = false;
	// Use this for initialization



	void Start () {
		StartCoroutine ("History", times_required[chapter]);

	}
	
	// Update is called once per frame
	void Update () {
		if (Next_chapter) {

			Next_chapter = false;
			chapter++;
			if(chapter<=5){
				StartCoroutine ("History", times_required[chapter]);
			}
			Debug.Log("NextChapter");

		}
	}

	IEnumerator History(float time_required){
		switch (chapter) {
		case 0:{
			Messager.GetComponent<Messaging>().Message(chapter);
			yield return new WaitForSeconds(time_required);
			Next_chapter = true;
			break;
		}
		case 1: {

			Next_chapter = true;
			break;
		}
		case 2: {
			Messager.GetComponent<Messaging>().Message(chapter);
			yield return new WaitForSeconds(time_required);
			Next_chapter = true;
			break;
		}
		case 3: {
			Debug.Log("Chapter 3 working");
			Next_chapter = true;
			break;
		}
		case 4: {
			Debug.Log("Chapter 4 working1");
			Messager.GetComponent<Messaging>().Message(chapter);
			Debug.Log("Chapter 4 working2");
			yield return new WaitForSeconds(time_required);

			Next_chapter = true;
			break;
		}
		case 5: {
			
			//Next_chapter = true;
			break;
		}
		}
	}
}
