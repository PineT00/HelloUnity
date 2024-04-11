using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;



public class MouseInput : MonoBehaviour, 
    IPointerEnterHandler, 
    IPointerExitHandler,
    IPointerDownHandler,
    IPointerUpHandler,
    IPointerClickHandler
{
    public MeshRenderer ren;

    void Start()
    {
        ren = GetComponent<MeshRenderer>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log($"{gameObject.name} Enter");
        ren.material.color = Color.yellow;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log($"{gameObject.name} Exit");
        ren.material.color = Color.white;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log($"{gameObject.name} Up");
        ren.material.color = Color.red;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log($"{gameObject.name} Down");
        ren.material.color = Color.blue;
    }

    public void OnPointerClick(PointerEventData eventData) //�ٿ����Ʈ. ���� �ٸ����� Ŀ���θ� ȣ��ȵ�.
    {
        Debug.Log($"{gameObject.name} Click");
        ren.material.color = Color.black;
    }


}
