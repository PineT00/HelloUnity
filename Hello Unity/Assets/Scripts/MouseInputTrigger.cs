using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseInputTrigger : MonoBehaviour
{
    public MeshRenderer ren;

    void Start()
    {
        ren = GetComponent<MeshRenderer>();
    }

    public void OnPointerEnter(BaseEventData eventData)
    {
        Debug.Log($"{gameObject.name} Enter");
        ren.material.color = Color.yellow;
    }

    public void OnPointerExit(BaseEventData eventData)
    {
        Debug.Log($"{gameObject.name} Exit");
        ren.material.color = Color.white;
    }

    public void OnPointerUp(BaseEventData eventData)
    {
        Debug.Log($"{gameObject.name} Up");
        ren.material.color = Color.red;
    }

    public void OnPointerDown(BaseEventData eventData)
    {
        Debug.Log($"{gameObject.name} Down");
        ren.material.color = Color.blue;
    }

    public void OnPointerClick(BaseEventData eventData) //다운업세트. 업때 다른곳에 커서두면 호출안됨.
    {
        Debug.Log($"{gameObject.name} Click");
        ren.material.color = Color.black;
    }


}
