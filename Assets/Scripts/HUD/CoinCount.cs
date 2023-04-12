using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CoinCount : MonoBehaviour
{
    public int coins = 0;
    public TMP_Text texto;
    void Update()
    {
        texto.text = "Points "+coins.ToString();
        Debug.Log(coins);
    }
}
