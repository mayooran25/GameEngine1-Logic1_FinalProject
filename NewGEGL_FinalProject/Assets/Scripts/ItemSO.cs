using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public enum BodyPart
{
    Head, Shield, Weapons, Feet
}


[System.Serializable]

[CreateAssetMenu(menuName = "ItemSO", fileName = "ItemSO", order = 1)]
public class ItemSO : ScriptableObject
{
    public Sprite itemIcon;
    public string itemName;
    public List<GameObject> itemPrefab;
    public Vector3 position;
    public Vector3 rotation;
    public BodyPart BodyPart;
    public int id;

    private void Awake()
    {
        //itemPrefab[0].GetComponent<ItemID>().id = id;
        //Debug.Log("id Changed");
    }
    
}

