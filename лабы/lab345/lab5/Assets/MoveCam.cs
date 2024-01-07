using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{

    bool move = false;
    float speed = 0.01f;
    float offset = 0;
    Vector3 startPosition;
    Vector3 needPosition;
    Quaternion startRotation;
    Quaternion needRotaton;
    public void MoveStart()     //функция для начального положения
    {
        move = true;
        startPosition = transform.position;
        startRotation = transform.rotation;
        needPosition = new Vector3(7.91f, 3.92f, 0);
        needRotaton=Quaternion.Euler(new Vector3(11.047f, -90f,0));
    }
    public void MoveVoltmetr()         //функция для просмотра Вольтметра
    {
        move = true;
        startPosition = transform.position;
        startRotation = transform.rotation;
        needPosition = new Vector3(1.814f, 2.693f, 1.32f);
        needRotaton = Quaternion.Euler(new Vector3(6.28f, -90f, 0));
    }
   
    public void MoveAmpermetr()     //функция для просмотра Амперметра
    {
        move = true;
        startPosition = transform.position;
        startRotation = transform.rotation;
        needPosition = new Vector3(1.09f, 2.517f, -1.39f);
        needRotaton = Quaternion.Euler(new Vector3(6.28f, -90f, 0));
    }
    public void MoveCorpus()     //функция для просмотра ЛАТР
    {
        move = true;
        startPosition = transform.position;
        startRotation = transform.rotation;
        needPosition = new Vector3(1.09f, 2.613f, 0);
        needRotaton = Quaternion.Euler(new Vector3(6.28f, -90f, 0));
    }
    public void MoveR1()     //функция для просмотра Лампы
    {
        move = true;
        startPosition = transform.position;
        startRotation = transform.rotation;
        needPosition = new Vector3(0.71f, 2.28f, -0.07f);
        needRotaton = Quaternion.Euler(new Vector3(10.429f, -90f, 0));
    }

    public void MoveR2()     //функция для просмотра Лампы
    {
        move = true;
        startPosition = transform.position;
        startRotation = transform.rotation;
        needPosition = new Vector3(0.71f, 2.28f, 0.08f);
        needRotaton = Quaternion.Euler(new Vector3(10.429f, -90f, 0));
    }

    public void MoveSwitch1()     //функция для просмотра Лампы
    {
        move = true;
        startPosition = transform.position;
        startRotation = transform.rotation;
        needPosition = new Vector3(0.58f, 2.69f, -0.39f);
        needRotaton = Quaternion.Euler(new Vector3(10.429f, -90f, 0));
    }

    public void MoveSwitch2()     //функция для просмотра Лампы
    {
        move = true;
        startPosition = transform.position;
        startRotation = transform.rotation;
        needPosition = new Vector3(0.54f, 2.43f, 0f);
        needRotaton = Quaternion.Euler(new Vector3(0, -90f, 0));
    }


    void Update()
    {
        if (move)
        {
            offset += speed;
            transform.position = Vector3.Lerp(startPosition, needPosition, offset);
            transform.rotation = Quaternion.Slerp(startRotation, needRotaton, offset);
            if (offset >= 1)
            {
                move = false;
                offset = 0;
            }
        }
    }

}
