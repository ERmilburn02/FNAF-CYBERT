using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioClip jumpScareSound;
    public AudioClip demoIntro;
    AudioSource audioSource;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayJumpScareSound()
    {
        audioSource.Stop();
        audioSource.clip = jumpScareSound;
        audioSource.Play();
    }

    public void PlayDemoIntro()
    {
        audioSource.Stop();
        audioSource.clip = demoIntro;
        audioSource.Play();
    }
}
