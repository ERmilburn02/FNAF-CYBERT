using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [ContextMenu("Continue")]
    public void ContinueStory()
    {
        if (Player.SAVE_CurrentNight == -1)
        {
            // No Save, start from Night 1
            GameManager.SetupNight1();
            SceneManager.LoadSceneAsync(2);
        }
    }

    [ContextMenu("NewGame")]
    public void NewGame()
    {
        GameManager.SetupNight1();
        SceneManager.LoadSceneAsync(2);
    }
}
