using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    
    public float cash = 1000;
    public float maxCredit = 1000;
    public TMP_Text cashText;
    
    float credit = 0;
    float creditAPR = 0.1f;
    float owed = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cashText.text = "Money: " + cash;
    }

    public void addCash(float add)
    {
        cash+=add;
        cashText.text = "Money: " + cash;
    }

    public void removeCash(float remove)
    {
        cash-=remove;
        cashText.text = "Money: " + cash;
    }

    public void nextMonth()
    {
        owed+=credit*creditAPR;
        cashText.text = "Money: " + cash;
    }
}
