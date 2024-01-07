using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSteps : MonoBehaviour
{
    [SerializeField] public GameObject step1;
    [SerializeField] public GameObject step2;
    [SerializeField] public GameObject step3;
    [SerializeField] public GameObject step4;
    [SerializeField] public GameObject step5;
    [SerializeField] public GameObject step6;
    [SerializeField] public GameObject step7;
    [SerializeField] public GameObject step8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Step1()
    {
        step1.GetComponent<Animator>().SetBool("animGo",true);
    }
    public void Step2()
    {
        step2.GetComponent<Animator>().SetBool("animGo", true);
    }
    public void Step3()
    {
        step3.GetComponent<Animator>().SetBool("animGo", true);
    }
    public void Step4()
    {
        step4.GetComponent<Animator>().SetBool("animGo", true);
    }
    public void Step5()
    {
        step5.GetComponent<Animator>().SetBool("animGo", true);
    }
    public void Step6()
    {
        step6.GetComponent<Animator>().SetBool("animGo", false);
        step6.GetComponent<Animator>().SetBool("animGo2", true);
    }
    public void Step7()
    {
        step7.GetComponent<Animator>().SetBool("animGo", true);
    }
    public void Step8()
    {
        step8.GetComponent<Animator>().SetBool("animGo", false);
        step8.GetComponent<Animator>().SetBool("animGo2", true);
    }

}
