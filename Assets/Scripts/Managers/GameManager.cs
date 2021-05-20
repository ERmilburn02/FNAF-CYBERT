using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static void InitVariables()
    {
        Player.Night = -1;
        Player.CurrentTime = -1;
        Player.Power = -1;
        Player.LeftDoorClosed = false;
        Player.RightDoorClosed = false;
        Player.CameraUp = false;
        Player.CurrentCamera = Room.RecRoom;
        Player.RevEnabled = false;
        Player.RevInOffice = false;
        Player.MidnaEnabled = false;
        Player.MidnaInOffice = false;
        Player.TuckerEnabled = false;
        Player.TuckerInOffice = false;
        Player.DanDifficulty = -1;
        Player.DanInOffice = false;
        Player.JerikaDifficulty = -1;
        Player.JerikaInOffice = false;
        Player.AlyssaDifficulty = -1;
        Player.AlyssaInOffice = false;
        Player.BrigetteDifficulty = -1;
        Player.BrigetteInOffice = false;
        Player.SAVE_CurrentNight = -1;
        Player.SAVE_Night6Unlocked = false;
        Player.SAVE_CustomNightUnlocked = false;
        Player.SAVE_Beaten420 = false;
    }

    public static void SaveGame()
    {
        SaveSystem.SavePlayer();
    }

    public static void LoadGame()
    {
        PlayerData _sav = SaveSystem.LoadPlayer();
        if (_sav != null)
        {
            Player.SAVE_CurrentNight = _sav.CurrentNight;
            Player.SAVE_Night6Unlocked = _sav.Night6Unlocked;
            Player.SAVE_CustomNightUnlocked = _sav.CustomNightUnlocked;
            Player.SAVE_Beaten420 = _sav.Beaten420;
        }
    }

    public static void SetupNight(int _dan, int _jerika, int _alyssa, int _brigette, bool _rev, bool _midna, bool _tucker, int _night, int _power, int _time)
    {
        Player.DanDifficulty = _dan;
        Player.JerikaDifficulty = _jerika;
        Player.AlyssaDifficulty = _alyssa;
        Player.BrigetteDifficulty = _brigette;
        Player.RevEnabled = _rev;
        Player.MidnaEnabled = _midna;
        Player.TuckerEnabled = _tucker;
        Player.Night = _night;
        Player.Power = _power;
        Player.CurrentTime = _time;
    }

    public static void SetupNight1()
    {
        SetupNight(3, 0, 0, 0, false, false, false, 1, 100, 12);
    }

    public static void SetupNight2()
    {
        // SetupNight(1, 2, 0, 0, false, false, false, 1, 100, 12);
    }

    public static void SetupNight3()
    {
        // SetupNight(2, 4, 0, 0, false, false, /*true*/ false, 1, 100, 12);
    }

    /*
    public static void SetupNight4()
    {
        SetupNight(0, 0, 0, 0, false, false, false, 1, 100, 12);
    }

    public static void SetupNight5()
    {
        SetupNight(0, 0, 0, 0, false, false, false, 1, 100, 12);
    }
    */

    public static void Time2AM()
    {
        // Player.JerikaDifficulty++;
    }

    public static void Time4AM()
    {
        // Player.JerikaDifficulty++;
    }
}
