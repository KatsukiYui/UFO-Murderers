using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMPlayer : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Music");

        if (players.Length > 1)
        {
            Destroy(this.gameObject);
       
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }

    }
}
