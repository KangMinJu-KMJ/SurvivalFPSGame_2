using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairLight : MonoBehaviour
{
    public Light s_light;
    public AudioSource source;
    public AudioClip lightSound;
    //유니티에서 지원하는 함수. isTrigger체크시 충돌감지 하는 함수
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            s_light.enabled = true;
            source.PlayOneShot(lightSound, 1.0f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            s_light.enabled = false;
            source.PlayOneShot(lightSound, 1.0f);
        }
    }
}
