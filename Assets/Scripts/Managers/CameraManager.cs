using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraManager : MonoBehaviour
{
    public static CameraManager instance;

    public RenderTexture HallwayCloseRT;
    public RenderTexture HallwayFarRT;
    public RenderTexture HellRT;
    public RenderTexture KitchenRT;
    public RenderTexture RecRoomRT;

    public RawImage display;

    public Room currentDisplayedCamera;

    public Dictionary<Room, RenderTexture> cams;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        instance = this;

        cams = new Dictionary<Room, RenderTexture>()
        {
            {Room.HallwayClose, HallwayCloseRT},
            {Room.HallwayFar, HallwayFarRT},
            {Room.Hell, HellRT},
            {Room.Kitchen, KitchenRT},
            {Room.RecRoom, RecRoomRT}
        };

        currentDisplayedCamera = Player.CurrentCamera;
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if (Player.CurrentCamera != currentDisplayedCamera)
        {
            display.texture = cams[Player.CurrentCamera];
            currentDisplayedCamera = Player.CurrentCamera;
        }
    }
}
