using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;



public class OptionsMenu : MonoBehaviour
{

    [SerializeField]
    AudioMixer masterAudioMixer = null;

    [SerializeField]
    Slider masterAudioSlider = null;
    [SerializeField]
    Slider effectsAudioSlider = null;
    [SerializeField]
    Slider bgmAudioSlider = null;

    [SerializeField]
    Slider tiltSpeedSlider = null;

    //setting the slider values to the current values
    private void Start()
    {
        //used to extract the audioMixer value
        float value = 0;
        masterAudioMixer.GetFloat("volumeMaster", out value);
        masterAudioSlider.value = value;
        masterAudioMixer.GetFloat("volumeEffects", out value);
        effectsAudioSlider.value = value;
        masterAudioMixer.GetFloat("volumeBGM", out value);
        bgmAudioSlider.value = value;

        tiltSpeedSlider.value = TiltMovement.tiltSpeed;

    }
    

    public void Back()
    {
        //switch to back to main menu
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void SetMasterVolume(float volume)
    {
        masterAudioMixer.SetFloat("volumeMaster", volume);
    }

    public void SetBGMVolume(float volume)
    {
        masterAudioMixer.SetFloat("volumeBGM", volume);
    }

    public void SetEffectsVolume(float volume)
    {
        masterAudioMixer.SetFloat("volumeEffects", volume);
    }

    public void SetTiltSpeed(float speed)
    {
        TiltMovement.tiltSpeed = speed;
    }

}
