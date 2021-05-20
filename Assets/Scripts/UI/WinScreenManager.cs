using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreenManager : MonoBehaviour
{
    public RectTransform screen;
    public static WinScreenManager instance;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        instance = this;
    }

    public void ExitGameButton()
    {
        Application.Quit();
    }

    public void ShowWinScreen()
    {
        screen.gameObject.SetActive(true);
    }
}
