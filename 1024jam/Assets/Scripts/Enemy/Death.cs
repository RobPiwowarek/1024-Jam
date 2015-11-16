using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {



	void OnTriggerEnter2D(Collider2D col){
        if ((col != null)){
            MissileMovement mov = col.gameObject.GetComponent<MissileMovement>();
            if ((mov != null) && (this.GetComponent<EnemyMovement>().ID == mov.ID)){
                Destroy(col.gameObject);
                Destroy(this.gameObject);

            }
            else{
                PlayerStatistics playerStats = col.gameObject.GetComponent<PlayerStatistics>() ;
                if (playerStats != null)
                {
                    playerStats.DealDamage(1);
                    //Filip daj immune na jakieś 2 sekundy
                    //playerStats.Immune = true;
                }
                else if (mov != null)
                {
                    //Debug.Log("DESTRUCTION");
                    Destroy(col.gameObject);
                }
                
            }
        }
	}

}
