using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Target : MonoBehaviour, IPointerClickHandler
{
    public MoveRotate moveRotate;

    public void OnPointerClick(PointerEventData eventData)
    {
        moveRotate.target = transform;
    }
}
