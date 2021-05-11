using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerikaController : MonoBehaviour
{

    public Room currentLocation = Room.RecRoom;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(nameof(main));
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
        JERIKA ROOM ORDER

        RecRoom
        HallwayFar
        RecRoom | Kitchen | HallwayClose
        HallwayFar | HallwayFar | Office

    */

    IEnumerator main()
    {
        bool ready = true;
        while (ready)
        {
            ready = false;
            yield return new WaitForSeconds(Random.Range(60, 121) / Player.JerikaDifficulty);
            if (AI.AttemptMove(Player.JerikaDifficulty))
            {
                if (!Player.CameraUp || (Player.CameraUp && Player.CurrentCamera != currentLocation))
                {
                    if (currentLocation != Room.Office) { Debug.Log("[JERKIA]: Moved"); }
                    if (currentLocation == Room.RecRoom || currentLocation == Room.Kitchen)
                    {
                        currentLocation = Room.HallwayFar;
                    }
                    else if (currentLocation == Room.HallwayFar)
                    {
                        Room[] _newLoc = { Room.RecRoom, Room.Kitchen, Room.HallwayClose };
                        int _i = Random.Range(0, 3);
                        currentLocation = _newLoc[_i];
                    }
                    else if (currentLocation == Room.HallwayClose)
                    {
                        int _i = Random.Range(0, 2);
                        if (_i == 1)
                        {
                            if (!Player.LeftDoorClosed)
                            {
                                currentLocation = Room.Office;
                                Player.JerikaInOffice = true;
                            }
                            else
                            {
                                currentLocation = Room.RecRoom;
                            }
                        }
                        else
                        {
                            currentLocation = Room.HallwayFar;
                        }
                    }
                }
            }
            ready = true;
        }
    }
}
