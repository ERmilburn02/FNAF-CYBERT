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

    [ContextMenu("Demo")]
    public void Demo()
    {
        GameManager.SetupNight(8, 0, 0, 0, false, false, false, 3, 100, 12);
        SceneManager.LoadSceneAsync(2);
    }


    [ContextMenu("CustomNight")]
    public void LaunchCustomNight()
    {
        GameManager.SetupNight(int.Parse(CustomDanDifficulty.text), int.Parse(CustomJerikaDifficulty.text), int.Parse(CustomAlyssaDifficulty.text), int.Parse(CustomBrigetteDifficulty.text), CustomRev.isOn, CustomMidna.isOn, CustomTucker.isOn, 7, 100, 12);
        SceneManager.LoadSceneAsync(2);
    }

    public void DanAIChange(int _value)
    {
        CustomDanDifficulty.text = (int.Parse(CustomDanDifficulty.text) + _value).ToString();
        if (CustomDanDifficulty.text == "21") { CustomDanDifficulty.text = "20"; }
        if (CustomDanDifficulty.text == "-1") { CustomDanDifficulty.text = "0"; }
    }

    public void JerikaAIChange(int _value)
    {
        CustomJerikaDifficulty.text = (int.Parse(CustomJerikaDifficulty.text) + _value).ToString();
        if (CustomJerikaDifficulty.text == "21") { CustomJerikaDifficulty.text = "20"; }
        if (CustomJerikaDifficulty.text == "-1") { CustomJerikaDifficulty.text = "0"; }
    }

    public void AlyssaAIChange(int _value)
    {
        CustomAlyssaDifficulty.text = (int.Parse(CustomAlyssaDifficulty.text) + _value).ToString();
        if (CustomAlyssaDifficulty.text == "21") { CustomAlyssaDifficulty.text = "20"; }
        if (CustomAlyssaDifficulty.text == "-1") { CustomAlyssaDifficulty.text = "0"; }
    }

    public void BrigetteAIChange(int _value)
    {
        CustomBrigetteDifficulty.text = (int.Parse(CustomBrigetteDifficulty.text) + _value).ToString();
        if (CustomBrigetteDifficulty.text == "21") { CustomBrigetteDifficulty.text = "20"; }
        if (CustomBrigetteDifficulty.text == "-1") { CustomBrigetteDifficulty.text = "0"; }
    }
}
