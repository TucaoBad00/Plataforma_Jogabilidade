using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBase : MonoBehaviour
{
    public string _CompareTag = "Player";
    public GameObject contador;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag(_CompareTag))
        {
            colected();
        }
    }
    public void colected()
    {
        gameObject.SetActive(false);
        contador.GetComponent<CoinCount>().coins = contador.GetComponent<CoinCount>().coins + 1;
        }
}
