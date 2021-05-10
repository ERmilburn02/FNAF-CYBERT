using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitSceneManager : MonoBehaviour
{
    void Start()
    {
        if (Debug.isDebugBuild)
        {
            var go = new GameObject { name = "[Debug Utils]" };
            go.AddComponent<DebugUtils>();
            DontDestroyOnLoad(go);
        }

        GameManager.InitVariables();
        GameManager.LoadGame();
        GameManager.SaveGame();
        SceneManager.LoadSceneAsync(1);
    }
}
