using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static bool AttemptMove(int _difficulty)
    {
        int _roll = Random.Range(0, 20);
        if (_difficulty >= _roll)
        {
            return true;
        }
        return false;
    }
}
