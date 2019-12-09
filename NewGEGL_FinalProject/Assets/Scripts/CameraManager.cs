using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private Podium _podium;

    private void Awake()
    {
        _podium = GetComponent<Podium>();
    }

    private void OnEnable()
    {
        _podium.onIntractEvent += MoveCameraToLocation;
    }

    void MoveCameraToLocation()
    {
        
    }

    void MoveCameraBack()
    {
        
    }
    
    private void OnDisable()
    {
        _podium.onIntractEvent -= MoveCameraToLocation;
    }
    
}
