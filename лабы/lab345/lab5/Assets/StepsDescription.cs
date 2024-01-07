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
        _text.text = "�������� ��������, \n ������� �������� \n � �������� ���";
    }

    public void Step1()
    {
        _text.text =
            "��������� �������� ��������� R1 � R2\r\n� ������� ��������� ������ ���� ������� �������, ��� ������������� �������� ���������� � ������������� ����";
    }

    public void Step2()
    {
        _text.text = "������������� �1\r\n���������� � ��������� 1";
    }
    public void Step3()
    {
        _text.text = "��� ������ ������������� �2 �������� � ������������� ����� ����������� ����";
    }
    public void Step4()
    {
        _text.text = "� ���������� ������������� ���\r\n��������� �������� ���������";
    }

    public void Step5()
    {
        _text.text = "������� ��� ������ �������� R1 ������ ���������� U �� �����, �������� ��������������� �������� ���� ���� I";
    }
    public void Step6()
    {
        _text.text = "������������� �1 ���������� � ��������� 2";
    }
    public void Step7()
    {
        _text.text = "������� ��������� R1 ����������\r\n���������� U �� ����� , �������� ��������������� �������� ���� ���� I";
    }
    public void Step8()
    {
        _text.text = "��������� ���������";
    }

    public void Reset()
    {
        _text.text = "�������� ��������, \n ������� �������� \n � �������� ���";
    }
}
