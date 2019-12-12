using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGameCut : MonoBehaviour
{
    public GameObject blackOutPanel;

    public Animator anim;

    public ItemSO finalHead;
    public ItemSO finalShield;
    public ItemSO finalWeapon;

    TextMeshProUGUI _headText;
    TextMeshProUGUI _weaponText;
    TextMeshProUGUI _shieldText;

    private void Awake()
    {
        
        anim = GetComponent<Animator>();
    }

    public void EndStats()
    {
        
    }
}
