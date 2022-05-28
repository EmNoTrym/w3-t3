using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    public Item item;

    public Image icon;
    public TextMeshProUGUI quantity = null;

    public CanvasGroup canvasGroup;


    void Update()
    {
        if (item != null)
        {
            icon.sprite = item.icon;
            if (quantity != null)
            {
                if (item.quantity != 0)
                {
                    quantity.text = item.quantity.ToString();
                }
                else
                {
                    quantity.text = "";
                }
            }
        }
        else
        {
            canvasGroup.alpha = 0f;
        }
    }
}
