using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
    public string text;
    private AudioSource clap_sound;
    public GameObject goaltext;

    void Start()
    {
      clap_sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter");
        goaltext.SetActive(true);
        clap_sound.Play();

    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("stay");
      //  display = true;
    }

   
}

