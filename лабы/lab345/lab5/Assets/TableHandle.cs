using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TableHandle : MonoBehaviour
{
    public int stepNum = 1;
    [SerializeField]
    InputField textInput;

    [SerializeField]
    Text I1Pr;
    [SerializeField]
    Text U1Pr;
    [SerializeField]
    Text Rst1Pr;
    [SerializeField]
    Text Rd1Pr;
    [SerializeField]
    Text rb1Pr;
    [SerializeField]
    Text U1Obr;
    [SerializeField]
    Text I1Obr;
    [SerializeField]
    Text Rst1Obr;
    [SerializeField]
    Text Rd1Obr;
    [SerializeField]
    Text K1;

    [SerializeField]
    Text I2Pr;
    [SerializeField]
    Text U2Pr;
    [SerializeField]
    Text Rst2Pr;
    [SerializeField]
    Text Rd2Pr;
    [SerializeField]
    Text rb2Pr;
    [SerializeField]
    Text U2Obr;
    [SerializeField]
    Text I2Obr;
    [SerializeField]
    Text Rst2Obr;
    [SerializeField]
    Text Rd2Obr;
    [SerializeField]
    Text K2;

    [SerializeField]
    Text I3Pr;
    [SerializeField]
    Text U3Pr;
    [SerializeField]
    Text Rst3Pr;
    [SerializeField]
    Text Rd3Pr;
    [SerializeField]
    Text rb3Pr;
    [SerializeField]
    Text U3Obr;
    [SerializeField]
    Text I3Obr;
    [SerializeField]
    Text Rst3Obr;
    [SerializeField]
    Text Rd3Obr;
    [SerializeField]
    Text K3;

    public ScreenText Script;
    public async void OnNextStep()
    {
      
        Debug.Log(stepNum);
        if (stepNum==1&&!String.IsNullOrWhiteSpace(textInput.text))
        {
            U1Pr.text = Script.U;
            I1Pr.text = textInput.text;
            await Task.Delay(500);
            double res = Convert.ToDouble(U1Pr.text) / Convert.ToDouble(I1Pr.text);
            Rst1Pr.text = Convert.ToString(res);
            await Task.Delay(500);
            res = (Convert.ToDouble(U1Pr.text) - 0) / (Convert.ToDouble(I1Pr.text) - 0);
            Rd1Pr.text = Convert.ToString(res);
            await Task.Delay(500);
            res = (Convert.ToDouble(U1Pr.text) - 0) / (Convert.ToDouble(I1Pr.text) - 0);
            rb1Pr.text = Convert.ToString(res);
            stepNum++;
            Debug.Log(stepNum);
            return;
        }
        else if (stepNum == 2 && !String.IsNullOrWhiteSpace(textInput.text))
        {
            U2Pr.text = Script.U;
            I2Pr.text = textInput.text;
            await Task.Delay(500);
            double res = Convert.ToDouble(U2Pr.text) / Convert.ToDouble(I2Pr.text);
            Rst2Pr.text = Convert.ToString(res);
            await Task.Delay(500);
            res = (Convert.ToDouble(U2Pr.text) - Convert.ToDouble(U1Pr.text)) /
                  (Convert.ToDouble(I2Pr.text) - Convert.ToDouble(I1Pr.text));
            Rd2Pr.text = Convert.ToString(res);
            await Task.Delay(500);
            res = (Convert.ToDouble(U2Pr.text) - Convert.ToDouble(U1Pr.text)) /
                  (Convert.ToDouble(I2Pr.text) - Convert.ToDouble(I1Pr.text));
            rb2Pr.text = Convert.ToString(res);
            stepNum++;
            Debug.Log(stepNum);
            return;
        }
        else if (stepNum == 3 && !String.IsNullOrWhiteSpace(textInput.text))
        {
            U3Pr.text = Script.U;
            I3Pr.text = textInput.text;
            await Task.Delay(500);
            double res = Convert.ToDouble(U3Pr.text) / Convert.ToDouble(I3Pr.text);
            Rst3Pr.text = Convert.ToString(res);
            await Task.Delay(500);
            res = (Convert.ToDouble(U3Pr.text) - Convert.ToDouble(U2Pr.text)) /
                  (Convert.ToDouble(I3Pr.text) - Convert.ToDouble(I2Pr.text));
            Rd3Pr.text = Convert.ToString(res);
            await Task.Delay(500);
            res = (Convert.ToDouble(U3Pr.text) - Convert.ToDouble(U2Pr.text)) /
                  (Convert.ToDouble(I3Pr.text) - Convert.ToDouble(I2Pr.text));
            rb3Pr.text = Convert.ToString(res);
            stepNum++;
            Debug.Log(stepNum);
            return;
        }
        else if (stepNum == 4 && !String.IsNullOrWhiteSpace(textInput.text))
        {
            Debug.Log(stepNum);
            U1Obr.text = Script.U;
            I1Obr.text = textInput.text;
            await Task.Delay(500);
            double res = Convert.ToDouble(U1Obr.text) / Convert.ToDouble(I1Obr.text);
            Rst1Obr.text = Convert.ToString(res);
            await Task.Delay(500);
            res = (Convert.ToDouble(U1Obr.text) - 0) /
                  (Convert.ToDouble(I1Obr.text) - 0);
            Rd1Obr.text = Convert.ToString(res);
            await Task.Delay(500);
            res = Convert.ToDouble(I1Pr.text) / Convert.ToDouble(I1Obr.text);
            K1.text = Convert.ToString(res);
            stepNum++;
            return;
        }
        else if (stepNum == 5 && !String.IsNullOrWhiteSpace(textInput.text))
        {
            Debug.Log(stepNum);
            U2Obr.text = Script.U;
            I2Obr.text = textInput.text;
            await Task.Delay(500);
            double res = Convert.ToDouble(U2Obr.text) / Convert.ToDouble(I2Obr.text);
            Rst2Obr.text = Convert.ToString(res);
            await Task.Delay(500);
            res = (Convert.ToDouble(U2Obr.text) - Convert.ToDouble(U1Obr.text)) /
                  (Convert.ToDouble(I2Obr.text) - Convert.ToDouble(U1Obr.text));
            Rd2Obr.text = Convert.ToString(res);
            await Task.Delay(500);
            res = Convert.ToDouble(I2Pr.text) / Convert.ToDouble(I2Obr.text);
            K2.text = Convert.ToString(res);
            stepNum++;
            return;
        }
        else if (stepNum==6 && !String.IsNullOrWhiteSpace(textInput.text))
        {
            Debug.Log(stepNum);
            U3Obr.text = Script.U;
            I3Obr.text = textInput.text;
            await Task.Delay(500);
            double res = Convert.ToDouble(U3Obr.text) / Convert.ToDouble(I3Obr.text);
            Rst3Obr.text = Convert.ToString(res);
            await Task.Delay(500);
            res = (Convert.ToDouble(U3Obr.text) - Convert.ToDouble(U2Obr.text)) /
                  (Convert.ToDouble(I3Obr.text) - Convert.ToDouble(U2Obr.text));
            Rd3Obr.text = Convert.ToString(res);
            await Task.Delay(500);
            res = Convert.ToDouble(I3Pr.text) / Convert.ToDouble(I3Obr.text);
            K3.text = Convert.ToString(res);
            stepNum = 1;
            return;
        }

    }

    public void Clear()
    {
        I1Pr.text = "";
        U1Pr.text = "";
        Rst1Pr.text = "";
        Rd1Pr.text = "";
        rb1Pr.text = "";
        I1Obr.text = "";
        U1Obr.text = "";
        Rst1Obr.text = "";
        Rd1Obr.text = "";
        K1.text = "";

        I2Pr.text = "";
        U2Pr.text = "";
        Rst2Pr.text = "";
        Rd2Pr.text = "";
        rb2Pr.text = "";
        I2Obr.text = "";
        U2Obr.text = "";
        Rst2Obr.text = "";
        Rd2Obr.text = "";
        K2.text = "";

        I3Pr.text = "";
        U3Pr.text = "";
        Rst3Pr.text = "";
        Rd3Pr.text = "";
        rb3Pr.text = "";
        I3Obr.text = "";
        U3Obr.text = "";
        Rst3Obr.text = "";
        Rd3Obr.text = "";
        K3.text = "";
    }
}
