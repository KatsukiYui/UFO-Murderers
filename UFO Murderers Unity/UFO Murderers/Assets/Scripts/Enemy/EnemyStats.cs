using UnityEngine;

public class EnemyStats : MonoBehaviour
{

    [SerializeField]
    float baseHP = 20f;
    [SerializeField]
    float enemyHealth;

    [SerializeField]
    float baseDMG = 5f;
    [SerializeField]
    float enemyDamage;


    Rigidbody rigidbod = null;

    [SerializeField]
    float baseVelocity = 20;
    [SerializeField]
    float maxVelocity;

    //the rate at which the enemy stats grow each level
    [SerializeField]
    float hpMultiplier = 0f;
    [SerializeField]
    float dmgMultiplier = 0f;
    [SerializeField]
    float velocityMultiplier = 0f;


    void Start()
    {
        //increasing the enemy stats based on the current level
        enemyHealth = baseHP + ((LevelSystem.level - 1) * hpMultiplier);
        enemyDamage = baseDMG + ((LevelSystem.level -1) * dmgMultiplier);
        maxVelocity = baseVelocity + ((LevelSystem.level - 1) * velocityMultiplier);

        rigidbod = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (rigidbod.velocity.magnitude > maxVelocity)
        {
            rigidbod.velocity = Vector3.ClampMagnitude(rigidbod.velocity, maxVelocity);
        }

    }


    public void DamageEnemy()
    {
        enemyHealth -= BulletDamage.damage;
        if(enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void DamagePlayer()
    {
        PlayerHealth.health -= enemyDamage;
    }

    //if the enemy hits the bottom of the stage the player takes damage
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Bottom")
        {
            DamagePlayer();
            Destroy(gameObject);
        }
    }
}
