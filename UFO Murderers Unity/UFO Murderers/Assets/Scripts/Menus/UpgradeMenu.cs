using UnityEngine;
using UnityEngine.SceneManagement;

public class UpgradeMenu : MonoBehaviour
{

    [SerializeField]
    float damageUp = 5f;

    [SerializeField]
    float healthUp = 10f;

    public void UpDamage()
    {
        BulletDamage.damage += damageUp;
        SwitchToGame();
    }

    public void UpHealth()
    {
        PlayerHealth.maxHealth += healthUp;
        SwitchToGame();
    }

    public void UpFire()
    {
        //add a bullet?
        SwitchToGame();
    }

    private void SwitchToGame()
    {

        LevelSystem.level++;

        //fully heal the player
        PlayerHealth.health = PlayerHealth.maxHealth;

        //switch back to the game;
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}
