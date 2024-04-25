using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{  
    [SerializeField] private TextMeshProUGUI nivelText;
    [SerializeField] private TextMeshProUGUI xpText;
    [SerializeField] private Slider sliderLife;
    [SerializeField] private Slider sliderXP;

    private float vida;
    private float xpAtual;
    private float xpParaUpar;
    private int nivel;

    private void Awake()
    {
        vida = Health.instance.GetPlayerHeath();
        xpParaUpar = XPHandler.instance.GetXPParaUpar();
        sliderLife.maxValue = vida;
        sliderXP.maxValue = xpParaUpar;
    }

    private void Update()
    {
        vida = Health.instance.GetPlayerHeath();
        xpAtual = XPHandler.instance.GetXPAtual();
        nivel = XPHandler.instance.GetNivel();
        xpParaUpar = XPHandler.instance.GetXPParaUpar();
    
        sliderLife.value = vida;
        sliderXP.value = xpAtual;
        nivelText.text = nivel.ToString();
        xpText.text = xpAtual + "/" + xpParaUpar;
    }
}
