using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSystem : MonoBehaviour
{
    //current level
    public static int level = 1;

    [SerializeField]
    Canvas inGameCanvas = null;

    //the levels are time based and this is the time limit
    [SerializeField]
    float levelTime = 10f;

    //time since the start of the level
    float currTime;

    // Start is called before the first frame update
    void Start()
    {
        currTime = levelTime;

        //reset player health and bullet damage undoing any upgrades
        if (level == 1)
        {
            PlayerHealth.maxHealth = PlayerHealth.defaultHP;
            PlayerHealth.health = PlayerHealth.maxHealth;
            BulletDamage.damage = BulletDamage.defaultDmg;
        }
    }

    // Update is called once per frame
    void Update()
    {
        currTime -= Time.deltaTime;

        inGameCanvas.GetComponent<InGameUI>().DisplayTime(currTime);

        if (currTime <= 0 && PlayerHealth.health >= 0)
        {
            //switch to the upgrade menu scene;
            SceneManager.LoadScene("UpgradeMenu", LoadSceneMode.Single);
        }

    }
}
