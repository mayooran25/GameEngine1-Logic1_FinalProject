using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonManager<T> : MonoBehaviour where T : SingletonManager<T>
{
    //local variable instance (referencing itself)
    private static T _instance;

    public static T Instance
    {
        get
        {

            if (_instance == null)
            {
                Debug.Log("CAN YOU FIND THE INSTANCE OF THIS OBJECT");
                _instance = GameObject.FindObjectOfType<T>();
                if (_instance == null)
                {
                    Debug.Log("Create new object instance");
                    GameObject go = new GameObject("[Singleton] ? Manager");
                    _instance = go.AddComponent<T>();

                }
            }
            return _instance;
        }

    }

    protected virtual void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
