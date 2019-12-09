﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Podium : MonoBehaviour
{
    public GameObject player;
    public Transform podiumPosition;
    public Dictionary<BodyPart, List<ItemSO>> items;
    public List<ItemSO> allList;
    
    private UIController _uiScript;
    private CameraManager _cameraManager;
    
    public delegate void OnIntract();
    public delegate void OnExit();
    public OnIntract onIntractEvent;
    public OnExit onExitEvent;
    
    private void Awake()
    {
        InitializeDictonary();
        _uiScript = GetComponentInChildren<UIController>();
        _cameraManager = GetComponent<CameraManager>();
    }

    void InitializeDictonary()
    {
        items.Add(BodyPart.Body, new List<ItemSO>());
        items.Add(BodyPart.Feet, new List<ItemSO>());
        items.Add(BodyPart.Hands, new List<ItemSO>());
        items.Add(BodyPart.Head, new List<ItemSO>());
        items.Add(BodyPart.Weapons, new List<ItemSO>());
        
        foreach (var item in allList)
        {
            items[item.BodyPart].Add(item);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        foreach (var item in items)
        {
            _uiScript.CreatePanelItem(item.Key, item.Value);
        }
    }
}
