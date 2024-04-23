using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPHandler : MonoBehaviour
{
    public static XPHandler instance;

    private float xpAtual;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        print("XP Atual = " + xpAtual);
    }

    public float XPAdicionado(float xpDropado)
    {
        xpAtual += xpDropado;
        return xpAtual;
    }


}
