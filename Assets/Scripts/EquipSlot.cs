using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EquipSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (gameObject.transform.Find("ItemButton"))
        {
            Transform itemButton = gameObject.transform.Find("ItemButton");
            itemButton.GetComponent<RectTransform>().anchoredPosition = eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition;
            itemButton.SetParent(eventData.pointerDrag.transform.parent);
            itemButton.localPosition = gameObject.transform.Find("EmptyButton").GetComponent<RectTransform>().localPosition;
        }
        eventData.pointerDrag.transform.SetParent(transform);
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        eventData.pointerDrag.GetComponent<RectTransform>().localPosition = Vector3.zero;
    }
}
