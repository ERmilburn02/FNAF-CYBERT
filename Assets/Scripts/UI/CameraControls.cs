using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    void SwitchCamera(Room _room)
    {
        Player.CurrentCamera = _room;
    }

    public void SwitchToHellCamera()
    {
        SwitchCamera(Room.Hell);
    }

    public void SwitchToHallwayFarCamera()
    {
        SwitchCamera(Room.HallwayFar);
    }

    public void SwitchToHallwayCloseCamera()
    {
        SwitchCamera(Room.HallwayClose);
    }

    public void SwitchToKitchenCamera()
    {
        SwitchCamera(Room.Kitchen);
    }

    public void SwitchToRecRoomCamera()
    {
        SwitchCamera(Room.RecRoom);
    }
}
