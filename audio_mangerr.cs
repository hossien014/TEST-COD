using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class audio_mangerr : MonoBehaviour
{
  AudioListener a_l;
    GameObject play;
    GameObject stop;

    private void Awake()
    {
        a_l = GetComponent<AudioListener>();
        play = GameObject.Find("play");
        stop = GameObject.Find("stop");
        stop.SetActive(false);
    }

    public void on_off_audio()
    {
        if (a_l.enabled == true)
        {
            a_l.enabled = false;
            play.SetActive(false);
            stop.SetActive(true);

        }
        else
        {
            a_l.enabled = true;
            play.SetActive(true);
            stop.SetActive(false);
        }

       
    }
}
