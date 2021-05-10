using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugUtils : MonoBehaviour
{
    // This script will be ddol in debug builds

    public void LogPlayerObject()
    {
        Debug.Log("===|PLAYER OBJECT|===");

        Debug.Log("===|END OF OBJECT|===");
    }
}
