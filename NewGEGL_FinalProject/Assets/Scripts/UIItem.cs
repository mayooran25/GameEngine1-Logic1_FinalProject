using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIItem : MonoBehaviour
{
    public Image itemIcon;
    public TextMeshProUGUI itemNameText;
    public ItemSO itemData;
    public Podium podium;
    public bool isInitialized;

    public void Init(ItemSO data)
    {
        this.itemIcon.sprite = data.itemIcon;
        this.itemNameText.text = data.itemName;
        isInitialized = true;
    }

    public void Onclick()
    {
        podium.EquipItem(itemData.BodyPart, itemData.id);
    }
}
