using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CameraOpener : MonoBehaviour, IPointerEnterHandler
{
    public GameObject camDisplay;
    public float cameraCountdown = 10f;
    public float cameraCooldown = 0f;
    public Slider cameraCooldownSlider;
    public Slider cameraCountdownSlider;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (cameraCooldown <= 0)
        {
            camDisplay.SetActive(!camDisplay.activeSelf);
            Player.CameraUp = camDisplay.activeSelf;
            MidnaController.LookedAtCams();
        }
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if (Player.CameraUp)
        {
            cameraCountdown -= Time.deltaTime;
        }
        else
        {
            cameraCountdown += Time.deltaTime;
            if (cameraCountdown >= 10f) cameraCountdown = 10f;
            cameraCooldown -= Time.deltaTime;
            if (cameraCooldown <= 0) cameraCooldown = 0f;
        }
        if (cameraCountdown <= 0 && Player.CameraUp)
        {
            camDisplay.SetActive(false);
            MidnaController.LookedAtCams();
            cameraCooldown = 10f;
            Player.CameraUp = false;
        }
        cameraCountdownSlider.value = cameraCountdown;
        cameraCooldownSlider.value = cameraCooldown;
    }

    // /// <summary>
    // /// Called when the mouse enters the GUIElement or Collider.
    // /// </summary>
    // void OnMouseEnter()
    // {
    //     camDisplay.SetActive(!isOpen);
    //     isOpen = !isOpen;
    // }
}
