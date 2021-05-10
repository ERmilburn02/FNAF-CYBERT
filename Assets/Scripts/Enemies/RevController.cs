using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevController : MonoBehaviour
{
    //TODO: REWRITE AS MIDNA CONTROLLER, GIVE REV UNIQUE MECHANIC CONNECTED TO HELL AND CLOSET

    int remainingCams = 10;

    public static RevController instance;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void LookedAtCams()
    {
        RevController.instance.remainingCams--;
        if (RevController.instance.remainingCams == 0)
        {
            RevController.instance.SpawnRev();
            RevController.instance.remainingCams = 10;
        }
    }

    public void SpawnRev()
    {
        Player.Rev = true;
        // Show Rev in room
    }
}
