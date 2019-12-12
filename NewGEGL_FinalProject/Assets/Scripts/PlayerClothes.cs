using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClothes : MonoBehaviour
{
    public List<GameObject> heads;
    public List<GameObject> shields;
    public List<GameObject> weapons;

    public EndGameCut endScript;

    private void Awake()
    {
        endScript = FindObjectOfType<EndGameCut>();
    }

    public void EnableItem(BodyPart bodyPart, int id)
    {
        endScript.UpdateItem(bodyPart, id);
        switch (bodyPart)
        {
            case BodyPart.Head:
                EquipSequence(heads, id);
                break;
            case BodyPart.Weapons:
                EquipSequence(weapons, id);
                break;
            case BodyPart.Shield:
                EquipSequence(shields, id);
                break;
        }
    }

    void EquipSequence(List<GameObject> typeList, int inId)
    {
        for (int i = 0; i < typeList.Count; i++)
        {
            typeList[i].SetActive(false);
        }

        for (int i = 0; i < typeList.Count; i++)
        {
            if (typeList[i].GetComponent<ItemID>().id == inId)
            {
                typeList[i].SetActive(true);
            }
        }
    }
}
