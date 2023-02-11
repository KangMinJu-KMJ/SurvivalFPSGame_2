using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePos : MonoBehaviour
{
    public AudioSource source;
    public AudioClip firesound;
    public GameObject bulletprefab;
    public Transform fire_pos;
    public Animation ani;

    void Start()
    {
        
    }
       
    void Update()
    {   //마우스 왼쪽 버튼을 눌렀다면? 1 오른쪽버튼 2는 휠 버튼
        if(Input.GetMouseButtonDown(0))
        {
            if (Hand.isrun == false)
            {
                Fire();
                if (Hand.ishavem4a1 == true)
                {
                    StartCoroutine(FastShotFire());//StartCoroutine : 여러 번 반복한다.
                }
            }
        }
    }

    void Fire()
    {               //what          where              how rotation
        Instantiate(bulletprefab, fire_pos.position, fire_pos.rotation);
        //동적 생성 함수 : 오브젝트를 필요할 때 생성
        source.PlayOneShot(firesound,1.0f);
        if (Hand.ishavem4a1)
        {
            ani.Play("aimFire");
        }
        else
            ani.Play("fire");
       }
    IEnumerator FastShotFire()
    {
        Fire();
        yield return new WaitForSeconds(0.25f);
        Fire();
        yield return new WaitForSeconds(0.25f);
        Fire();
        yield return new WaitForSeconds(0.25f);
        Fire();
    }
}
