using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidnaController : MonoBehaviour
{
    int remainingCams = 10;

    public static MidnaController instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void LookedAtCams()
    {
        if (!Player.MidnaEnabled) { return; }

        MidnaController.instance.remainingCams--;
        if (MidnaController.instance.remainingCams == 0)
        {
            MidnaController.instance.SpawnMidna();
            MidnaController.instance.remainingCams = Random.Range((10 - Player.Night), 7);
        }
    }

    public void SpawnMidna()
    {
        Debug.Log("[MIDNA]: Spawned");
        Player.MidnaInOffice = true;
        // Show Midna in room
    }
}
