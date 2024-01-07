using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StepsDescription : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public Text _text;
    void Start()
    {
        _text.text = "Описание практики, \n нажмите практика \n и выберите шаг";
    }

    public void Step1()
    {
        _text.text =
            "Поверните рукоятки реостатов R1 и R2\r\nв крайнее положение против хода часовой стрелки, что соответствует нулевому напряжению в измерительной цепи";
    }

    public void Step2()
    {
        _text.text = "Переключатель П1\r\nустановите в положение 1";
    }
    public void Step3()
    {
        _text.text = "При помощи переключателя П2 включите в измерительную схему исследуемый диод";
    }
    public void Step4()
    {
        _text.text = "С разрешения преподавателя или\r\nлаборанта включите установку";
    }

    public void Step5()
    {
        _text.text = "Изменяя при помощи реостата R1 прямое напряжение U на диоде, измерьте соответствующие значения силы тока I";
    }
    public void Step6()
    {
        _text.text = "Переключатель П1 переведите в положение 2";
    }
    public void Step7()
    {
        _text.text = "Изменяя реостатом R1 запирающее\r\nнапряжение U на диоде , измерьте соответствующие значения силы тока I";
    }
    public void Step8()
    {
        _text.text = "Выключите установку";
    }

    public void Reset()
    {
        _text.text = "Описание практики, \n нажмите практика \n и выберите шаг";
    }
}
