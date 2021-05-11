using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevController : MonoBehaviour
{
    //TODO: GIVE REV UNIQUE MECHANIC CONNECTED TO HELL AND CLOSET

    //Plan Make Rev an enemy that has to be checked on regularly to prevent him killing you

    float maxCountdownTimer = 60 / Player.Night;
    public float countdownTimer = -1;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        countdownTimer = maxCountdownTimer;
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if (Player.RevEnabled)
        {
            if (!Player.RevInOffice)
            {
                if (Player.CameraUp && Player.CurrentCamera == Room.Hell)
                {
                    countdownTimer = maxCountdownTimer;
                    return;
                }
                if (countdownTimer > 0)
                {
                    countdownTimer -= Time.deltaTime;
                }
                if (countdownTimer <= 0)
                {
                    countdownTimer = 0;
                    Player.RevInOffice = true;
                    Debug.Log("[REV]: Spawned");
                }
            }
        }
    }
}
