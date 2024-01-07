using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveResistor : MonoBehaviour
{
    public double Resistanse=0;
    public float rotationSpeed = 1f; // Скорость вращения объекта
    private bool isRotating = false; // Флаг, указывающий, вращается ли объект в данный момент
    private Vector3 mouseOrigin; // Исходная позиция мыши при начале вращения
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
                // Вычисляем смещение мыши относительно исходной позиции
                Vector3 mouseOffset = Input.mousePosition - mouseOrigin;
                Resistanse += mouseOffset.x;
                Debug.Log("current"+transform.rotation.normalized);
                transform.Rotate(new Vector3(mouseOffset.x*rotationSpeed,0),Space.World);

                Debug.Log("after" + transform.rotation);
                // Обновляем исходную позицию мыши для следующего кадра
                mouseOrigin = Input.mousePosition;
        }
    }

    void OnMouseDown()
    {
        // Проверяем, была ли нажата левая кнопка мыши
        if (Input.GetMouseButton(0))
        {
            // Запоминаем исходную позицию мыши
            mouseOrigin = Input.mousePosition;
            isRotating = true; // Устанавливаем флаг вращения в true
        }
        Debug.Log(isRotating);
    }
    void OnMouseUp()
    {
        isRotating = false; // Устанавливаем флаг вращения в false
    }
}
