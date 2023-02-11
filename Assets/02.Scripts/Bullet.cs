using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 250.0f;
    public Rigidbody rbody;

    void Start()
    {                   //velocity = 방향 * 속도
        rbody.AddForce(transform.forward * speed);//transform 대신 vector3쓰면..
        //몸돌렸을때 총알이 요상하게나감
        Destroy(gameObject, 3.0f);

    }

    
}
