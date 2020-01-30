using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class InGameUI : MonoBehaviour
{
    //level display code
    [SerializeField]
    private TextMeshProUGUI levelTxt = null;

    //display the countdown
    [SerializeField]
    private TextMeshProUGUI timeTxt = null;

    // Start is called before the first frame update
    void Start()
    {
        //set it to display the current level
        levelTxt.text = "Level: " + LevelSystem.level.ToString();
    }

    //Menu button code
    public void BackToMenu()
    {
        //switch to back to main menu
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void DisplayTime(float time)
    {

        if (time >= 0)
        {
            //makin it more aesthetically pleasing
            if (time < 10)
            {
                //timeMS is the melliseconds remaining after deducting the whole seconds
                int timeMS = (int)((time - (int)time) * 100);
                timeTxt.text = "0" + ((int)time).ToString() + ":" + timeMS;
            }
            else
            {
                int timeMS = (int)((time - (int)time) * 100);
                timeTxt.text = ((int)time).ToString() + ":" + timeMS;
            }

        }
        else
        {
            time = 0;
            timeTxt.text = "00:00";

        }

    }
}
