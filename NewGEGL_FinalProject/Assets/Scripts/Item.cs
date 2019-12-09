using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item : MonoBehaviour
{
    public Image itemIcon;
    public Text itemNameText;

    public void Init(ItemSO data)
    {
        this.itemIcon.sprite = data.itemIcon;
        this.itemNameText.text = data.name;
    }
}
