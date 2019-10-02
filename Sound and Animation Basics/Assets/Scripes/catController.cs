using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catController : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip musicClipOne;
    public AudioClip musicClipTwo;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    /* The code below here sets the Integer value of our anim variable based on whether we have the W key pressed down 
     * or not. If it is pressed down, the State integer gets set to 1; when it is released, we set it back to 0.  
     * We do something similar for the running animation with the Left Shift key.
    */
    void Update()
    {
        //w key controls walk and soundclip_1
        if (Input.GetKeyDown(KeyCode.W))
        {
            musicSource.clip = musicClipOne;
            musicSource.Play();
            anim.SetInteger("State", 1);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            musicSource.Stop();
            anim.SetInteger("State", 0);
        }
        //R key controls walk and soundclip_2
        if (Input.GetKeyDown(KeyCode.R))
        {
            musicSource.clip = musicClipTwo;
            musicSource.Play();
            anim.SetInteger("State", 2);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            musicSource.Stop();
            anim.SetInteger("State", 0);
        }
        // L key to loop sound
        if (Input.GetKeyDown(KeyCode.L))
        {
            musicSource.loop = true;
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            musicSource.loop = false;
        }
        //escape key down to exit
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}

