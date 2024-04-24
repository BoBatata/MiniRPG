using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI vidaText;
    [SerializeField] private TextMeshProUGUI nivelText;
    [SerializeField] private TextMeshProUGUI xpText;

    private float vida;
    private float xpAtual;
    private float xpParaUpar;
    private int nivel;

    private void Update()
    {
        vida = Health.instance.GetPlayerHeath();
        xpAtual = XPHandler.instance.GetXPAtual();
        nivel = XPHandler.instance.GetNivel();
        xpParaUpar = XPHandler.instance.GetXPParaUpar();

        vidaText.text = "Vida: " + vida;
        nivelText.text = "Nível: " + nivel;
        xpText.text = xpAtual + "/" + xpParaUpar;
    }
}
