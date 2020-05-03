using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    private static gameManager _gameManager;


    public static gameManager Instance
    {
        get
        {
            if(_gameManager == null)
            {
                GameObject g = new GameObject();
                g.AddComponent<gameManager>();
            }
            return _gameManager;
        }

    }

    public float Health { get; set; }
    public float Stamina { get; set; }

    public void Awake()
    {
        _gameManager = this;
    }




}
