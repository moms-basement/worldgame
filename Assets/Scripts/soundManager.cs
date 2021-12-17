using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    
    public static AudioClip meteorBreakS, earthHitS;
    static AudioSource audioSource;
     
    void Start()
    {
        earthHitS = Resources.Load<AudioClip>("explosion");
        meteorBreakS = Resources.Load<AudioClip>("explode");


        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "explode":
                audioSource.PlayOneShot(meteorBreakS);
                break;
            case "explosion":
                audioSource.PlayOneShot(earthHitS);
                break;
        }
    }
}
