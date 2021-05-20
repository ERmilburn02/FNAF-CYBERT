using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuckerController : MonoBehaviour
{
    public GameObject tuckerObj;

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
        bool ready = true;
        while (ready)
        {
            ready = false;
            int _x = Random.Range((10 * Player.Night), 101);
            if (_x > 90)
            {
                if (!Player.TuckerInOffice)
                {
                    Debug.Log("[TUCKER]: Spawned");
                    Player.TuckerInOffice = true;
                    // Show tucker
                    tuckerObj.SetActive(true);
                }
            }
            else
            {
                yield return new WaitForSeconds(20 / Player.Night);
            }
            yield return new WaitForSeconds(20 - Player.Night);
            ready = true;
        }
    }
}
