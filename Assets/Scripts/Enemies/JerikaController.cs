using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerikaController : MonoBehaviour
{

    public Room currentLocation;

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
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 10) / 2 * Player.JerikaDifficulty);
            if (AI.AttemptMove(Player.JerikaDifficulty))
            {
                if (Player.CurrentCamera != currentLocation)
                {
                    // INSERT MOVEMENT CODE
                }
            }
        }
    }
}
