using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UIElements.Image;
using Random = UnityEngine.Random;

public class ScreenText : MonoBehaviour
{
    public GameObject R1;
    private double num;
    public MoveResistor script;
    public double koff=1;
    public string U;
    public GameObject table;

    public TableHandle tableScript;
    // Start is called before the first frame update
    [SerializeField] public TextMeshProUGUI textField;
    void Start()
    {
        textField.text =DoFormatText(0);
        script=R1.GetComponent<MoveResistor>();
        tableScript = table.GetComponent<TableHandle>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (script.Resistanse <= 0)
        {
            num = 0;
            ChangeText(num);
            return;
        }

        if (num != script.Resistanse)
        {
            if (tableScript.stepNum > 3)
            {
                koff = 1.6;
            }
            if (tableScript.stepNum <= 3)
            {
                koff = 1.3;
            }
            ChangeText((Math.Exp(Math.Clamp(script.Resistanse / 1000, 0, 1)) - 1)*koff);
        }

        num = script.Resistanse;


    }

    public string DoFormatText(double num)
    {
        string I = string.Format("{0:0.00}", num);
        U = string.Format("{0:0.00}", Math.Clamp(script.Resistanse/1000, 0, 1));
        return $"I: {I} \n U: {U}";
    }
    public void ChangeText(double num)
    {
        textField.text = DoFormatText(num);
    }
}
