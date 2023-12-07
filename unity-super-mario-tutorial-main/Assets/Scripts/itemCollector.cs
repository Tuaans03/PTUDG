using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class itemCollector : MonoBehaviour
{
    private int Coins = 0;
    public int CCoins= 15;

    [SerializeField] private Text CoinText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coinns"))
        {
            Destroy(collision.gameObject);
            Coins++;
            CCoins--;
            CoinText.text = "coins:" + Coins;
            
        }

    }
}
