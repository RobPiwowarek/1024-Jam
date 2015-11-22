using UnityEngine;
using System.Collections;

public class EnemyMissileDamage : MonoBehaviour {
    public int damage = 1;

    void OnCollisionEnter2D(Collision2D col)   {
        PlayerStatistics ps = col.gameObject.GetComponent<PlayerStatistics>();
        if (ps != null)
        {
            ps.DealDamage(damage);
            Destroy(this.gameObject);
        }
    }
}
