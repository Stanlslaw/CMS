using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1SwitcherAnim : MonoBehaviour
{
    [SerializeField] public Animator anim;

    private bool flag = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("a");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("a");
        if (Input.GetMouseButton(0))
        {
            Debug.Log("animGo");
            if (flag)
            {
                flag=!flag;
                anim.SetBool("animGo", true);
                anim.SetBool("animGo2", false);
            }
            else
            {
                flag = !flag;
                anim.SetBool("animGo2", true);
            }
        }
      
    }


}
