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
        while (true)
        {
            yield return new WaitForSeconds(20 / Player.DanDifficulty);
            if (AI.AttemptMove(Player.DanDifficulty))
            {
                if (!Player.CameraUp)
                {
                    // INSERT MOVEMENT CODE
                }
            }
        }
    }
}
