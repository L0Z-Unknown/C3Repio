using UnityEngine;
using TMPro;
using System.Xml.Schema;
public class GetInputFieldValue : MonoBehaviour
{
    [SerializeField]
    TMP_InputField field;
    [SerializeField]
    TMP_InputField i_flourAmt;
    [SerializeField]
    TMP_InputField i_flourCost;
    [SerializeField]
    TMP_InputField i_sugarAmt;
    [SerializeField]
    TMP_InputField i_sugarCost;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            cal();
        }
    }
    public void cal()
    {

        float flourCost = -1;
        Debug.Log(i_flourAmt.text);
        Debug.Log(float.TryParse(i_flourCost.text, out flourCost));
        float flourAmt = -1;
        Debug.Log(float.TryParse(i_flourAmt.text, out flourAmt));

        float sugarCost = -1;
        Debug.Log(i_flourAmt.text);
        Debug.Log(float.TryParse(i_sugarCost.text, out sugarCost));
        float sugarAmt = -1;
        Debug.Log(float.TryParse(i_sugarAmt.text, out sugarAmt));
        Debug.Log(flourAmt * flourCost + sugarAmt * sugarCost);

        
    }
}
