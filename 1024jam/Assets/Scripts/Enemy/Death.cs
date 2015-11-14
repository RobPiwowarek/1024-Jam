using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
        if ((col != null)){
            MissileMovement mov = col.gameObject.GetComponent<MissileMovement>();
            if ((mov != null) && (this.GetComponent<EnemyMovement>().ID == mov.ID))
            {
                Destroy(col.gameObject);
                Destroy(this.gameObject);
            }
            else
                Destroy(col.gameObject);
        }
	}

}
