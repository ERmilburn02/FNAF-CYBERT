using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NightManager : MonoBehaviour
{
    public static NightManager instance;

    void OnSceneLoaded(Scene _scene, LoadSceneMode _mode)
    {
        if (_scene.buildIndex == 2)
        {
            StartNight();
            if (Player.Night == 8)
            {
                SoundManager.instance.PlayDemoIntro();
            }
        }
    }

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    /// <summary>
    /// This function is called when the behaviour becomes disabled or inactive.
    /// </summary>
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    [ContextMenu("StartNight")]
    public void StartNight()
    {
        StartCoroutine(nameof(Night));
    }

    [ContextMenu("EndNightManually")]
    public void EndNightManually()
    {
        StopCoroutine(nameof(Night));
    }

    IEnumerator Night()
    {
        yield return new WaitForSeconds(30);
        Player.CurrentTime = 1;
        yield return new WaitForSeconds(30);
        Player.CurrentTime = 2;
        GameManager.Time2AM();
        yield return new WaitForSeconds(30);
        Player.CurrentTime = 3;
        yield return new WaitForSeconds(30);
        Player.CurrentTime = 4;
        GameManager.Time4AM();
        yield return new WaitForSeconds(30);
        Player.CurrentTime = 5;
        yield return new WaitForSeconds(30);
        Player.CurrentTime = 6;
        //TODO: END NIGHT
        // Disable all AI
        Player.DanDifficulty = 0;
        WinScreenManager.instance.ShowWinScreen();
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        //TODO: Seperate these into seperate deaths
        if (Player.DanInOffice || Player.RevInOffice || Player.MidnaInOffice || Player.AlyssaInOffice || Player.JerikaInOffice || Player.TuckerInOffice || Player.BrigetteInOffice)
        {
            EndNightManually();
        }
    }
}
