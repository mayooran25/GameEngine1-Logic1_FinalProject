﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Podium : MonoBehaviour
{
    PlayerClothes _player;
    public Transform podiumPosition;
    public Dictionary<BodyPart, List<ItemSO>> items;
    public List<ItemSO> allList;
    
    private UIController _uiScript;
    
    private bool _inMenu = false;
    public TextMeshProUGUI instructionText;
    private void Awake()
    {
        InitializeDictonary();
        _uiScript = GetComponentInChildren<UIController>();
    }

    void InitializeDictonary()
    {
        
        //items.Add(BodyPart.Feet, new List<ItemSO>());
        items = new Dictionary<BodyPart, List<ItemSO>>()
        {
            {BodyPart.Shield, new List<ItemSO>()},
            {BodyPart.Head, new List<ItemSO>()},
            {BodyPart.Weapons, new List<ItemSO>()},
        };
    
        foreach (var item in allList)
        {
            items[item.BodyPart].Add(item);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        _player = FindObjectOfType<PlayerClothes>();
        foreach (var item in items)
        {
            _uiScript.CreatePanelItem(item.Key, item.Value);
        }
    }

    public void EquipItem(BodyPart part, int inId)
    {
        foreach (var item in items[part])
        {
            if (item.id == inId)
            {
                _player.EnableItem(part, item.id);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!_inMenu )
            {
                instructionText.text = "Press E to Customize";
                if(Input.GetKeyDown(KeyCode.E))
                {
                    //onIntractEvent.Invoke();
                    _uiScript.canvas.SetActive(true);
                    _player.GetComponent<PlayerMovement>().enabled = false;
                    _player.GetComponent<PlayerMovement>().cam.enabled = false;
                    //_player.GetComponent<PlayerMovement>().enabled = false;
                    other.GetComponent<Animator>().SetBool("podium", true);
                    _inMenu = true;
                }
            }
            else
            {
                instructionText.text = "Press Esc to Exit";
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    //onExitEvent.Invoke();
                    _uiScript.canvas.SetActive(false);
                    _player.GetComponent<PlayerMovement>().enabled = true;
                    _player.GetComponent<PlayerMovement>().cam.enabled = true;

                    _inMenu = false;
                    other.GetComponent<Animator>().SetBool("podium", false);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            instructionText.text = null;
        }
    }
}
