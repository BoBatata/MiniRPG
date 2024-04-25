using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public InputManager inputManager;

    private void Awake()
    {
        if(Instance != null) Destroy(this.gameObject);
        
        Instance = this;
        inputManager = new InputManager();
    }

    public void MenuGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
