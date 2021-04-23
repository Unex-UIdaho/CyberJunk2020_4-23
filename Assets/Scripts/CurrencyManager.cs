using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyManager : MonoBehaviour
{
    public static CurrencyManager Instance { get; private set; }
    public int availableMoney;
    GameObject currencyBanner;
    GameObject cash;
    Text banner;
    Text cashOnHand;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            //Initialize all variable values
            availableMoney = 0;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        currencyBanner = GameObject.Find("CurrencyBanner");
        cash = GameObject.Find("CashOnHand");
        banner = currencyBanner.GetComponent<Text>();
        cashOnHand = cash.GetComponent<Text>();
    }

    void Update()
    {
        cashOnHand.text = availableMoney.ToString();
    }
}