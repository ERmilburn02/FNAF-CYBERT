using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitSceneManager : MonoBehaviour
{
    public GameObject SM;
    void Start()
    {
        if (Debug.isDebugBuild)
        {
            var go = new GameObject { name = "[Debug Utils]" };
            go.AddComponent<DebugUtils>();
            DontDestroyOnLoad(go);
        }

        var _goNM = new GameObject { name = "[NIGHT MANAGER]" };
        _goNM.AddComponent<NightManager>();
        DontDestroyOnLoad(_goNM);

        Instantiate(SM);

        GameManager.InitVariables();
        GameManager.LoadGame();
        GameManager.SaveGame();
        SceneManager.LoadSceneAsync(1);
    }
}
