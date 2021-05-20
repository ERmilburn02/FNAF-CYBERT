using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanPhysicalController : MonoBehaviour
{
    public Transform RecRoomPos;
    public Transform HallFarPos;
    public Transform HallClosePos;
    public Transform OfficePos;

    public float countdown = 10;
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if (FindObjectOfType<DanController>().currentLocation == Room.RecRoom)
        {
            transform.position = RecRoomPos.position;
            transform.rotation = RecRoomPos.rotation;
        }
        else if (FindObjectOfType<DanController>().currentLocation == Room.HallwayFar)
        {
            transform.position = HallFarPos.position;
            transform.rotation = HallFarPos.rotation;
        }
        else if (FindObjectOfType<DanController>().currentLocation == Room.HallwayClose)
        {
            transform.position = HallClosePos.position;
            transform.rotation = HallClosePos.rotation;
        }
        else if (Player.DanInOffice == true)
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
