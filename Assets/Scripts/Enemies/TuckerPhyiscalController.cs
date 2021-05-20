using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TuckerPhyiscalController : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Player.TuckerInOffice = false;
        Debug.Log("[TUCKER]: Despawned");
        // Hide Tucker
        GetComponentInParent<Transform>().gameObject.SetActive(false);
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
