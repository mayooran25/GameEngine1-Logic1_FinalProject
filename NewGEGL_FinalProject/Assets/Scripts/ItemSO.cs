using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public enum BodyPart
{
    Head, Body, Weapons, Hands, Feet
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
          


}

