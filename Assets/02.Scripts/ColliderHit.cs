using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderHit : MonoBehaviour
{
    public AudioSource source;
    public AudioClip hitSound;
    public GameObject effect;
                    //OnTriggerEnter(Collider other) : 통과하고 충돌감지하는놈
    private void OnCollisionEnter(Collision collision)//통과안하고 충돌감지함
        //스스로 호출하는 친구. 홀백함수?...라고함
    {
        if (collision.gameObject.tag == "BULLET")//collision : 충돌 구조체
        {
            Destroy(collision.gameObject);//충돌한 게임 오브젝트가 사라진다.
            source.PlayOneShot(hitSound, 1.0f);
            GameObject eff = Instantiate(effect,
                collision.transform.position, Quaternion.identity);
            //Instantiate : 동적할당 함수
            //지역변수에 이펙트를 반환. 맞은위치.
            Destroy(eff, 1.0f);//eff가 계속 있으면 곤란하니 2.8초후에 삭제
            //effect를 지우면 원본이 삭제되기에 사본만 없어지는 것.
        }
    }
}
