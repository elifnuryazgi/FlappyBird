using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    private void Start()
    {
        Destroy(gameObject,10);//10 sn sonra borulari yok et
    }
    private void FixedUpdate()
    {
        transform.position+=Vector3.left*speed*Time.deltaTime;
    }
}
