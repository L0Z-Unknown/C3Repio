using UnityEngine;
using TMPro;

public class Get : MonoBehaviour
{
    [SerializeField]
    TMP_InputField markup;
    [SerializeField]
    TMP_InputField Price;
    [SerializeField]
    TMP_InputField field;
    [SerializeField]
    TMP_InputField i_flourAmt;
    [SerializeField]
    TMP_InputField i_flourCost;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float flourCost = -1;
            Debug.Log(i_flourAmt.text);
            Debug.Log(float.TryParse(i_flourCost.text, out flourCost));
            float flourAmt = -1;
            Debug.Log(float.TryParse(i_flourAmt.text, out flourAmt));
            Debug.Log(flourAmt * flourCost);
        }
    }
}
