using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDescription : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public Text message;
    public void Start()
    {
        gameObject.SetActive(false);
        message.text = "��������";
    }

    // Update is called once per frame
    public void OnExit()
    {
        gameObject.SetActive(false);
        message.text = "��������";
    }

    public void ShowCorpusText()
    {
        gameObject.SetActive(true);
        message.text = "������";
    }

    public void ShowVoltText()
    {
        gameObject.SetActive(true);
        message.text = "���������";
    }

    public void ShowAmperText()
    {
        gameObject.SetActive(true);
        message.text = "���������";
    }

    public void ShowR1Text()
    {
        gameObject.SetActive(true);
        message.text = "��������1";
    }

    public void ShowR2Text()
    {
        gameObject.SetActive(true);
        message.text = "��������2";
    }

    public void ShowSwitch1Text()
    {
        gameObject.SetActive(true);
        message.text = "�������������1";
    }
    public void ShowSwitch2Text()
    {
        gameObject.SetActive(true);
        message.text = "�������������2";
    }

}
