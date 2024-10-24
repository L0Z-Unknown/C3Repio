using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Math : MonoBehaviour
{
    [SerializeField]
    TMP_Text textDisplay;
    [SerializeField]
    TMP_InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] amounts = GameObject.FindGameObjectsWithTag("Amt");
        GameObject[] price = GameObject.FindGameObjectsWithTag("Price");
        float sum = 0;
            for (int i = 0; i < amounts.Length; i++)
            {
                float amt = 0;
                float.TryParse(amounts[i].GetComponent<TMP_InputField>().text, out amt);
                float pri = 0;
                float.TryParse(price[i].GetComponent<TMP_InputField>().text, out pri);
                sum += amt * pri;
            }
    }
}