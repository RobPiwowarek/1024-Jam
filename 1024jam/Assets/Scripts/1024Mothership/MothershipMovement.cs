using UnityEngine;
using System.Collections;

public class MothershipMovement : MonoBehaviour {
	//Mothership Behaviour/life
	public int MothershipLife = 10000;
	int FightScenario = 0;

	//Mothership Movement
	public float treshold = 0.15f;
	public float smoothness = 0.5f;
	public float DescendMovement = 5.0f;
	Vector2 target = new Vector2(0.0f,5.0f);

	//Mines
	public GameObject Mine;



	// Use this for initialization
	void Start () {
		transform.position = new Vector2(0.0f,16.0f);
		StartCoroutine ("Mothership_Descend");
	}

	IEnumerator Mothership_Descend(){
		while (Vector2.Distance(transform.position,target)>1.0f) {
			//float w = Time.deltaTime*DescendMovement;
			//transform.position = new Vector2(transform.position.x,transform.position.y-w);
			transform.position = Vector2.Lerp(transform.position,target,Time.deltaTime*DescendMovement);
			yield return null;
		}
		yield return new WaitForSeconds (3.0f);
		StartCoroutine ("Mothership_Fight");
		StopCoroutine ("Mothership_Descend");
	}

	 public void Got_Hit(int damage){
		MothershipLife -= damage;
		if (MothershipLife < 0) {
			Destroy(this.gameObject);
		}
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
			target = new Vector2(0.0f,16.0f);
			while(Vector2.Distance(transform.position,target)>treshold){
				transform.position = Vector2.Lerp(transform.position,target,Time.deltaTime*smoothness*3.0f);
				yield return null;
			}

			//Instantiate(Mine,new Vector2(transform.position.x,transform.position.y),Quaternion.identity);

			yield return new WaitForSeconds(1.0f);
			target = new Vector2(Random.Range(-1.16f,1.16f),Random.Range(4.0f,7.0f));
			while(Vector2.Distance(transform.position,target)>treshold){
				transform.position = Vector2.Lerp(transform.position,target,Time.deltaTime*smoothness);
				yield return null;
			}
			/*
			yield return new WaitForSeconds(Random.Range(1.0f,4.0f));
			Debug.Log("Ratata!");
			yield return new WaitForSeconds(Random.Range(1.0f,4.0f));
			Debug.Log("Ratata2!");*/
			break;

		}

		}

		FightScenario = Random.Range (0,2);
		StartCoroutine ("Mothership_Fight");
		}
}
