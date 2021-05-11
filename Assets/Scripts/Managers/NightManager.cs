using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightManager : MonoBehaviour
{
    public static NightManager instance;

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
        yield return new WaitForSeconds(45);
        Player.CurrentTime = 1;
        yield return new WaitForSeconds(45);
        Player.CurrentTime = 2;
        GameManager.Time2AM();
        yield return new WaitForSeconds(45);
        Player.CurrentTime = 3;
        yield return new WaitForSeconds(45);
        Player.CurrentTime = 4;
        GameManager.Time4AM();
        yield return new WaitForSeconds(45);
        Player.CurrentTime = 5;
        yield return new WaitForSeconds(45);
        Player.CurrentTime = 6;
        //TODO: END NIGHT
    }
}
