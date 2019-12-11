using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClothes : MonoBehaviour
{
    public List<GameObject> heads;
    public List<GameObject> feets;
    public List<GameObject> shields;
    public List<GameObject> weapons;

    public void EnableItem(BodyPart bodyPart, int id)
    {
        if (bodyPart == BodyPart.Feet)
        {
            EquipSequence(feets, id);
        }
        else if (bodyPart == BodyPart.Head)
        {
            EquipSequence(heads, id);
        }
        else if (bodyPart == BodyPart.Weapons)
        {
            EquipSequence(weapons, id);
        }
        else if (bodyPart == BodyPart.Shield)
        {
            EquipSequence(shields, id);
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
