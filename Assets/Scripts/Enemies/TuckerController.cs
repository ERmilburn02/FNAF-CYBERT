using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuckerController : MonoBehaviour
{
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        if (Player.TuckerEnabled)
        {
            StartCoroutine(nameof(main));
        }
    }

    IEnumerator main()
    {
        while (true)
        {
            while (!Player.TuckerInOffice)
            {
                int _x = Random.Range((10 * Player.Night), 100);
                if (_x > 75)
                {
                    Player.TuckerInOffice = true;
                    // Show tucker
                }
                else
                {
                    yield return new WaitForSeconds(20 / Player.Night);
                }
                yield return new WaitForSeconds(10 - Player.Night);
            }
        }
    }
}
