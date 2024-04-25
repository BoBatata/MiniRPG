using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    public InputManager inputManager;

    [SerializeField] private float health;

    private void Awake()
    {
        if (instance != null) Destroy(this.gameObject);

        instance = this;
        inputManager = new InputManager();
        DontDestroyOnLoad(this.gameObject);
    }

    public float HeathPlayer()
    {  
        return health;
    }
            
    public void MenuGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
