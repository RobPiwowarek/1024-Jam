using UnityEngine;
using System.Collections;

public class MothershipMovement : MonoBehaviour {
	public float treshold = 0.15f;
	public float smoothness = 0.5f;
	public float DescendMovement = 5.0f;
	int FightScenario = 0;
	Vector2 target = new Vector2(0.0f,0.0f);
	// Use this for initialization
	void Start () {
		StartCoroutine ("Mothership_Descend");
	}

	IEnumerator Mothership_Descend(){
		while (transform.position.y>5.0f) {
			float w = Time.deltaTime*DescendMovement;
			transform.position = new Vector2(transform.position.x,transform.position.y-w);
			yield return null;
		}
		yield return new WaitForSeconds (3.0f);
		StartCoroutine ("Mothership_Fight");
	}

	IEnumerator Mothership_Fight(){
		switch (FightScenario) {
		case 0:{
			target = new Vector2(Random.Range(-1.16f,1.16f),Random.Range(4.0f,7.0f));
			while(Vector2.Distance(transform.position,target)>treshold){
				transform.position = Vector2.Lerp(transform.position,target,Time.deltaTime*smoothness);
				yield return null;
				}
			break;

		}

		case 1:{
			yield return new WaitForSeconds(Random.Range(1.0f,4.0f));
			Debug.Log("Ratata!");
			yield return new WaitForSeconds(Random.Range(1.0f,4.0f));
			Debug.Log("Ratata2!");
			break;

		}

		}
		FightScenario = Random.Range (0,1);
		StartCoroutine ("Mothership_Fight");
		}
}
