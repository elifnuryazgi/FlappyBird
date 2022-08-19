using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdController : MonoBehaviour
{
    public bool isDead;//default false
    public float velocity = 3f;
    public Rigidbody2D rb;
    public GameManager manager;
    public GameObject deadScreen;
   
    void Start()
    {
        Time.timeScale = 1;     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//sol tik demek
        {
            rb.velocity=Vector2.up*velocity;//kusu ziplatma
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "scoreArea")
        {
            manager.updateScore();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "deadarea")
        {
            isDead = true;
            Time.timeScale = 0;
            deadScreen.SetActive(true);
        }
    }
}
