using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPHandler : MonoBehaviour
{
    public static XPHandler instance;

    private float xpAtual;
    private float xpParaUpar = 100;
    [SerializeField]private int nivel = 0;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        print("XP Atual = " + xpAtual);
        print(nivel);

        if(xpAtual >= xpParaUpar)
        {
            xpParaUpar += 50;
            xpAtual = 0;
            nivel++;
        }
    }

    public float GetXPAtual()
    {
        return xpAtual;
    }

    public float GetXPParaUpar()
    {
        return xpParaUpar;
    }

    public int GetNivel()
    {
        return nivel;
    }

    public float XPAdicionado(float xpDropado)
    {
        xpAtual += xpDropado;
        return xpAtual;
    }


}
