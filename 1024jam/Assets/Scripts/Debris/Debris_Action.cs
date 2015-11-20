using UnityEngine;
using System.Collections;

public class Debris_Action : MonoBehaviour {

	public float TorqueMaxStrength= 100.0f;
	public float ExplosionStrength = 100.0f;
		public float lifetime = 5.0f;
		// Use this for initialization
		void Start () {		
			
			foreach(Transform el in transform){
				el.GetComponent<Rigidbody2D>().angularDrag = Random.Range(0.1f,0.75f);
			el.GetComponent<Rigidbody2D>().AddTorque(Random.Range(15.0f,TorqueMaxStrength));
				el.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(el.localPosition.x*ExplosionStrength, el.localPosition.y*ExplosionStrength));
			}			
		StartCoroutine ("Dissapear",lifetime);
	}

	IEnumerator Dissapear(float duration){
		yield return new WaitForSeconds (duration);
		Destroy (this.gameObject);
	}
}
