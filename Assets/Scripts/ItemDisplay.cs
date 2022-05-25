using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    public Item item;

    public Image icon;
    public TextMeshProUGUI quantity;
    void Start()
    {
        icon.sprite = item.icon;
        quantity.text = item.quantity.ToString();
    }
}
