using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public Animation ani;
    public SkinnedMeshRenderer spas12;
    public MeshRenderer[] Ak47;
    public MeshRenderer[] M4A1;
    public static bool ishavem4a1 = false; //ishavem4a1 : m4a1을 가지고있어 ?
    public static bool isrun = false;

    void Start()
    {
        
    }

    void Update()
    {
        HandAni();
        
        WeaponChange();
        
    }
    void HandAni()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))//shift+w를 입력중일때
        {
            ani.Play("running");
            isrun = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))//shift를 뗐을때
        {
            ani.Play("runStop");
            isrun = false;
        }
    }
    void WeaponChange()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))//alpha1 : 키보드의 넘버1
        {
            for (int i = 0; i < 3; i++)
                Ak47[i].enabled = true;//false를 true화함
            spas12.enabled = false;
            for (int i = 0; i < 3; i++)
                M4A1[i].enabled = false;

            ani.Play("draw");
            ishavem4a1 = false;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (int i = 0; i < 3; i++)
                Ak47[i].enabled = false;
            spas12.enabled = true;
            for (int i = 0; i < 3; i++)
                M4A1[i].enabled = false;

            ani.Play("draw");
            ishavem4a1 = false;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            for (int i = 0; i < 3; i++)
                Ak47[i].enabled = false;
            spas12.enabled = false;
            for (int i = 0; i < 3; i++)
                M4A1[i].enabled = true;
           

            ani.Play("draw");
            ishavem4a1 = true;
        }
    }
}
