using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public GameObject popclick,among;

    public void OnPointerDown (PointerEventData eventData)

    {

        GameManager.Instance.CollectByTap (eventData.position, transform);
        popclick.SetActive(true);
        among.SetActive(false);

    }


    public void OnPointerUp (PointerEventData eventData)

    {

        popclick.SetActive(false);
        among.SetActive(true);

    }
}
