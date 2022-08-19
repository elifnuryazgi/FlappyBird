using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public birdController birdScript;
    public GameObject borular;
    public float height;
    public float time;

    void Start()
    {
        StartCoroutine(spawnObject(time));
    }

    public IEnumerator spawnObject(float time)
    {
        while (!birdScript.isDead)
        {
            Instantiate(borular,new Vector3(3,Random.Range(-height,height),0),Quaternion.identity);
            yield return new WaitForSeconds(time);//1sn bekle demek


        }
    }
}
