using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(nameof(main));
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator main()
    {
        while (true)
        {
            yield return new WaitForSeconds(20 / Player.DanDifficulty);
            if (AI.AttemptMove(Player.DanDifficulty))
            {
                // INSERT MOVEMENT CODE
            }
        }
    }
}
