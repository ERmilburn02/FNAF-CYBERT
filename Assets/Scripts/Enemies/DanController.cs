using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanController : MonoBehaviour
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
        DAN ROOM ORDER

        RecRoom
        HallwayFar
        HallwayClose
        Office

    */

    IEnumerator main()
    {
        bool ready = true;
        while (ready)
        {
            ready = false;
            yield return new WaitForSeconds(Random.Range(1, 6) * 20 / Player.DanDifficulty);
            if (AI.AttemptMove(Player.DanDifficulty))
            {
                if (!Player.CameraUp)
                {
                    if (currentLocation != Room.Office) { Debug.Log("[DAN]: Moved"); }
                    if (currentLocation == Room.RecRoom)
                    {
                        currentLocation = Room.HallwayFar;
                    }
                    else if (currentLocation == Room.HallwayFar)
                    {
                        currentLocation = Room.HallwayClose;
                    }
                    else if (currentLocation == Room.HallwayClose)
                    {
                        if (!Player.LeftDoorClosed)
                        {
                            currentLocation = Room.Office;
                            Player.DanInOffice = true;
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
