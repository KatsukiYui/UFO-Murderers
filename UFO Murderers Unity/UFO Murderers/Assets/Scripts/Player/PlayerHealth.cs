using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    //used to view health during debug
    [SerializeField]
    float displayHP;

    //default Health
    public static float defaultHP = 50f;

    public static float health = 0f;

    public static float maxHealth = 0f;

    //slider used to display the health bar
    [SerializeField]
    Slider healthBar = null;

    [SerializeField]
    EnemyStats enemyDmg;

    //time to wait before switching scenes if the player dies
    float wait = 3f;
    float timer;


    void Start()
    {
        timer = 0f;

        //return the player to its original position
        gameObject.GetComponent<Transform>().position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        displayHP = health;

        healthBar.value = health / maxHealth;

        if (health <= 0)
        {
            //make the player disappear
            gameObject.GetComponent<Transform>().position = new Vector3(0,0, 100);

            timer += Time.deltaTime;

            if (timer >= wait)
            {
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);

            }

        }

    }
    
    //if an enemy hits the player the player takes damage
    private void OnTriggerEnter(Collider other)
    {
        enemyDmg = other.GetComponent<EnemyStats>();
        enemyDmg.DamagePlayer();
        Destroy(other.gameObject);
    }

}
