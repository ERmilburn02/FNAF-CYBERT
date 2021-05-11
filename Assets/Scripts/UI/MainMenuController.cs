using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public TMP_Text CustomDanDifficulty;
    public TMP_Text CustomJerikaDifficulty;
    public TMP_Text CustomAlyssaDifficulty;
    public TMP_Text CustomBrigetteDifficulty;
    public Toggle CustomRev;
    public Toggle CustomMidna;
    public Toggle CustomTucker;

    [ContextMenu("Continue")]
    public void ContinueStory()
    {
        if (Player.SAVE_CurrentNight == -1)
        {
            NewGame();
        }
        if (Player.SAVE_CurrentNight == 1)
        {
            NewGame();
        }
    }

    [ContextMenu("NewGame")]
    public void NewGame()
    {
        GameManager.SetupNight1();
        SceneManager.LoadSceneAsync(2);
    }


    [ContextMenu("CustomNight")]
    public void LaunchCustomNight()
    {
        GameManager.SetupNight(int.Parse(CustomDanDifficulty.text), int.Parse(CustomJerikaDifficulty.text), int.Parse(CustomAlyssaDifficulty.text), int.Parse(CustomBrigetteDifficulty.text), CustomRev.isOn, CustomMidna.isOn, CustomTucker.isOn, 7, 100, 12);
        SceneManager.LoadSceneAsync(2);
    }
}
