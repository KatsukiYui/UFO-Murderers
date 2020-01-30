using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    //used to view health during debug
    [SerializeField]
    float displayDmg;

    //default Damage
    public static float defaultDmg = 10f;

    public static float damage;

    [SerializeField]
    EnemyStats enemyHP;


    void Update()
    {
        displayDmg = damage;
    }

    private void OnTriggerEnter(Collider other)
    {

        // Damage the enemy if we hit one, destroy ourselves
        enemyHP = other.GetComponent<EnemyStats>();
        if (enemyHP != null)
        {
            enemyHP.DamageEnemy();
            Destroy(gameObject);
        }
    }

}
