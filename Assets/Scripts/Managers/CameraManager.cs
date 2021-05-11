using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager instance;

    public RenderTexture HallwayCloseRT;
    public RenderTexture HallwayFarRT;
    public RenderTexture HellRT;
    public RenderTexture KitchenRT;
    public RenderTexture RecRoomRT;

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
    }
}
