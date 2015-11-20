using UnityEngine;
using System.Collections;

public class GroupParentMovement : MonoBehaviour {
	Vector2 GridMovementTarget;
	public float GridMovementSmoothness = 1.0f;
	public float GridMovementTreshold = 1.0f;
	public float GridMovementXmin = 1.0f;
	public float GridMovementXmax = 1.0f;
	public float GridMovementYmin = 1.0f;
	public float GridMovementYmax = 1.0f;




	public void BeginGridMovement() {
		GridMovementTarget = new Vector2(Random.Range(GridMovementXmin,GridMovementXmax),Random.Range(GridMovementYmin,GridMovementYmax));
		StartCoroutine("Move_Grid_Randomly", GridMovementTarget);
		StartCoroutine ("CheckForEmptiness");
	}
		
	IEnumerator Move_Grid_Randomly(Vector2 GridMovementTarget){
		while (Vector2.Distance(transform.position, GridMovementTarget)>GridMovementTreshold) {
			transform.position = Vector2.Lerp(transform.position,GridMovementTarget,GridMovementSmoothness*Time.deltaTime);
			yield return null;
		}
		BeginGridMovement ();
	}

	public void EndGridMovement(){
		StopAllCoroutines();
		Debug.Log ("The Grid is empty");
		transform.position = new Vector2 (0.0f, 6.0f);
	}

	IEnumerator CheckForEmptiness(){
		while(transform.childCount>0){
			yield return new WaitForSeconds(1.0f);
			yield return null;
		}

			EndGridMovement();
		
	}
}
