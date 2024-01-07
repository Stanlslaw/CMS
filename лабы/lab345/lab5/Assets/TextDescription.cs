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
        message.text = "Описание";
    }

    // Update is called once per frame
    public void OnExit()
    {
        gameObject.SetActive(false);
        message.text = "Описание";
    }

    public void ShowCorpusText()
    {
        gameObject.SetActive(true);
        message.text = "Корпус";
    }

    public void ShowVoltText()
    {
        gameObject.SetActive(true);
        message.text = "Вольтметр";
    }

    public void ShowAmperText()
    {
        gameObject.SetActive(true);
        message.text = "Амперметр";
    }

    public void ShowR1Text()
    {
        gameObject.SetActive(true);
        message.text = "Резистор1";
    }

    public void ShowR2Text()
    {
        gameObject.SetActive(true);
        message.text = "Резистор2";
    }

    public void ShowSwitch1Text()
    {
        gameObject.SetActive(true);
        message.text = "Переключатель1";
    }
    public void ShowSwitch2Text()
    {
        gameObject.SetActive(true);
        message.text = "Переключатель2";
    }

}
