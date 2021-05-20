using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerikaPhysicalController : MonoBehaviour
{
    public Transform RecRoomPos;
    public Transform HallFarPos;
    public Transform HallClosePos;
    public Transform OfficePos;
    public Transform KitchenPos;

    public float countdown = 10;
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if (FindObjectOfType<JerikaController>().currentLocation == Room.RecRoom)
        {
            transform.position = RecRoomPos.position;
            transform.rotation = RecRoomPos.rotation;
        }
        else if (FindObjectOfType<JerikaController>().currentLocation == Room.HallwayFar)
        {
            transform.position = HallFarPos.position;
            transform.rotation = HallFarPos.rotation;
        }
        else if (FindObjectOfType<JerikaController>().currentLocation == Room.HallwayClose)
        {
            transform.position = HallClosePos.position;
            transform.rotation = HallClosePos.rotation;
        }
        else if (FindObjectOfType<JerikaController>().currentLocation == Room.Kitchen)
        {
            transform.position = KitchenPos.position;
            transform.rotation = KitchenPos.rotation;
        }
        else if (Player.JerikaInOffice == true)
        {
            transform.position = new Vector3(0, -10, 0);
            countdown -= Time.deltaTime;
        }
        if (countdown <= 0)
        {
            // ded
            transform.position = OfficePos.position;
            transform.rotation = OfficePos.rotation;
            if (!isCRRunning) StartCoroutine(nameof(YoureAlreadyDead));
            isCRRunning = true;
        }
    }

    bool isCRRunning = false;

    IEnumerator YoureAlreadyDead()
    {
        SoundManager.instance.PlayJumpScareSound();
        yield return new WaitForSeconds(3);
        if (Player.CurrentTime != 6)
        {
            NightManager.instance.EndNightManually();
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
    }
}
