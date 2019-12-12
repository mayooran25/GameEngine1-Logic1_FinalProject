using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class EndGameCut : MonoBehaviour
{
    public GameObject blackOutPanel;

    private Podium _podium;
    public Animator anim;

    public ItemSO finalHead;
    public ItemSO finalShield;
    public ItemSO finalWeapon;

    public TextMeshProUGUI _headText;
    public TextMeshProUGUI _weaponText;
    public TextMeshProUGUI _shieldText;
    public TextMeshProUGUI _EndMissionStatement;

    private void Awake()
    {
        _podium = FindObjectOfType<Podium>();
        //anim = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        EndStats();
    }

    public void UpdateItem(BodyPart part,int inId)
    {
        for (int i = 0; i < _podium.allList.Count; i++)
        {
            if (part == BodyPart.Head)
            {
                if (inId == _podium.allList[i].id)
                {            Debug.Log(_podium.allList[i]);

                    finalHead = _podium.allList[i];
                }
            }
            else if (part == BodyPart.Shield)
            {
                if (inId == _podium.allList[i].id)
                {            Debug.Log(_podium.allList[i]);

                    finalShield = _podium.allList[i];
                }
            }
            else if (part == BodyPart.Weapons)
            {
                if (inId == _podium.allList[i].id)
                {
                    Debug.Log(_podium.allList[i]);

                    finalWeapon = _podium.allList[i];
                }
            }
        }
        
    }

    public void EndStats()
    {
        _podium.DisablePlayer();
        blackOutPanel.SetActive(true);
        bool hasHead = HasItem(finalHead);
        bool hasShield = HasItem(finalShield);
        bool hasWeapon = HasItem(finalWeapon);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        _headText.text = finalHead.itemName+ " " + finalHead.itemEndStatement;
        _weaponText.text = finalShield.itemName+ " " + finalShield.itemEndStatement;
        _shieldText.text = finalWeapon.itemName+ " " + finalWeapon.itemEndStatement;

        if (hasHead && hasShield && hasWeapon)
        {
            _EndMissionStatement.text = "Fully prepared for his journey, our hero makes haste through the forest, nothing can stand in his way!";
        }
        else if (!hasHead && hasShield && hasWeapon)
        {
            _EndMissionStatement.text = "With no extra weight holding our hero back, he is able to make quick work of all that stand in his path. An archer snipes him from afar 'Headshot'";
        }
        else if (hasHead && !hasShield && hasWeapon)
        {
            _EndMissionStatement.text = "After fighting for several hours, our hero finds himself cornered with his back against the wall. Only way through is forward.";
        }
        else if (hasHead && hasShield && !hasWeapon)
        {
            _EndMissionStatement.text = "Barely making past the forest, our hero escapes with his life. A lesson learned, never bring a fist to a sword fight";
        }
        else if (!hasHead && !hasShield && hasWeapon)
        {
            _EndMissionStatement.text = "Only with a" + finalWeapon.itemName + "in hand, our hero fights valiantly and kills a few snakes, when his back was turned, he was slain by squirrel";
        }
        else if (!hasHead && hasShield && !hasWeapon)
        {
            _EndMissionStatement.text = "Only with a" + finalShield.itemName + "in hand, our hero joins a group of armadillos and curls up at the 1st sigh of a fight... He's killed by the 1st warrior he meets.";
        }
        else if (hasHead && !hasShield && !hasWeapon)
        {
            _EndMissionStatement.text = "Only equipped with a " + finalHead.itemName + ", our hero charges head first into battle... and dies.";
        }
        else
        {
            _EndMissionStatement.text = "Too full of himself our hero decides to go into battle empty handed and is killed instantly...";
        }
    }

    bool HasItem(ItemSO item)
    {
        if (item.itemName != "None")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
