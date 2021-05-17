using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraOpener : MonoBehaviour, IPointerEnterHandler
{
    public GameObject camDisplay;

    public void OnPointerEnter(PointerEventData eventData)
    {
        camDisplay.SetActive(!camDisplay.activeSelf);
        MidnaController.LookedAtCams();
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
