using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveResistor : MonoBehaviour
{
    public double Resistanse=0;
    public float rotationSpeed = 1f; // �������� �������� �������
    private bool isRotating = false; // ����, �����������, ��������� �� ������ � ������ ������
    private Vector3 mouseOrigin; // �������� ������� ���� ��� ������ ��������
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
                Debug.Log("rota");
                // ��������� �������� ���� ������������ �������� �������
                Vector3 mouseOffset = Input.mousePosition - mouseOrigin;
                Resistanse += mouseOffset.x;
                Debug.Log("current"+transform.rotation.normalized);
                transform.Rotate(new Vector3(mouseOffset.x*rotationSpeed,0),Space.World);

                Debug.Log("after" + transform.rotation);
                // ��������� �������� ������� ���� ��� ���������� �����
                mouseOrigin = Input.mousePosition;
        }
    }

    void OnMouseDown()
    {
        // ���������, ���� �� ������ ����� ������ ����
        if (Input.GetMouseButton(0))
        {
            // ���������� �������� ������� ����
            mouseOrigin = Input.mousePosition;
            isRotating = true; // ������������� ���� �������� � true
        }
        Debug.Log(isRotating);
    }
    void OnMouseUp()
    {
        isRotating = false; // ������������� ���� �������� � false
    }
}
