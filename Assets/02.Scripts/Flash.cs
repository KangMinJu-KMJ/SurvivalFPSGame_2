using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    public Light flashLight;
    public AudioSource a_source;//소리나게하는거
    public AudioClip flashSound;//소리파일
    void Start()
    {
        
    }

    
    void Update()
    {//만약 f키를 눌렀다면 light를 켜라.
        if(Input.GetKeyDown(KeyCode.F))
        {
            flashLight.enabled = !flashLight.enabled;
            //enable = 라이트 껐다켰다하는거(유니티에서)
            // !flash~ => 다를때 !
            a_source.PlayOneShot(flashSound, 1.0f);
        }



    }
}
