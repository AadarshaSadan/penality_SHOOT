using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class freekicker : MonoBehaviour {
	public float force=2f;
	public GameObject dir;
	public Slider sl;
     AudioSource kick_sound;
	// Use this for initialization
	void Start () {
        kick_sound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
            force++; ;
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
            force++;
        if (Input.GetMouseButtonDown(0))
            {
                 Debug.Log("Clicked");
               kick_sound.Play();
				this.GetComponent<Rigidbody>().AddForce(transform.forward*force,ForceMode.Impulse);
				dir.SetActive (false);
			}
		sl.value = force;
	}

}
