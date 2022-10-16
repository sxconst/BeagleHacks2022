using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogHouseSoundEffect : MonoBehaviour
{
    public AudioSource barkSound;

    private void Awake()
    {
        barkSound = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.newScore == Score.desiredScore)
        {
            barkSound.PlayOneShot(barkSound.clip);
        }
    } 
}
