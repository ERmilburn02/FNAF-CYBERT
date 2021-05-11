using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugUtils : MonoBehaviour
{
    // This script will be ddol in debug builds

    [ContextMenu("LogPlayerObject")]
    public void LogPlayerObject()
    {
        Debug.Log("===|PLAYER OBJECT|===");
        Debug.Log("Night: " + Player.Night);
        Debug.Log("Power: " + Player.Power);
        Debug.Log("LeftDoorClosed: " + Player.LeftDoorClosed);
        Debug.Log("RightDoorClosed: " + Player.RightDoorClosed);
        Debug.Log("CameraUp: " + Player.CameraUp);
        Debug.Log("CurrentCamera: " + Player.CurrentCamera);
        Debug.Log("RevEnabled: " + Player.RevEnabled);
        Debug.Log("RevInOffice: " + Player.RevInOffice);
        Debug.Log("MidnaEnabled: " + Player.MidnaEnabled);
        Debug.Log("MidnaInOffice: " + Player.MidnaInOffice);
        Debug.Log("TuckerEnabled: " + Player.TuckerEnabled);
        Debug.Log("TuckerInOffice: " + Player.TuckerInOffice);
        Debug.Log("DanDifficulty: " + Player.DanDifficulty);
        Debug.Log("DanInOffice: " + Player.DanInOffice);
        Debug.Log("JerikaDifficulty: " + Player.JerikaDifficulty);
        Debug.Log("JerikaInOffice: " + Player.JerikaInOffice);
        Debug.Log("AlyssaDifficulty: " + Player.AlyssaDifficulty);
        Debug.Log("AlyssaInOffice: " + Player.AlyssaInOffice);
        Debug.Log("BrigetteDifficulty: " + Player.BrigetteDifficulty);
        Debug.Log("BrigetteInOffice: " + Player.BrigetteInOffice);
        Debug.Log("SAVE_CurrentNight: " + Player.SAVE_CurrentNight);
        Debug.Log("SAVE_Night6Unlocked: " + Player.SAVE_Night6Unlocked);
        Debug.Log("SAVE_CustomNightUnlocked: " + Player.SAVE_CustomNightUnlocked);
        Debug.Log("SAVE_Beaten420: " + Player.SAVE_Beaten420);
        Debug.Log("===|END OF OBJECT|===");
    }

    public Room DEBUG_RoomChanger = Room.RecRoom;
    Room DRC_check;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        DRC_check = DEBUG_RoomChanger;
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if (DRC_check != DEBUG_RoomChanger)
        {
            Player.CurrentCamera = DEBUG_RoomChanger;
            DRC_check = DEBUG_RoomChanger;
        }
    }
}
