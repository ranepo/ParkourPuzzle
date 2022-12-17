using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    //public GameObject player;
    public Vector2 xvelocity;
    public Vector2 yvelocity;
    public float voidi = -5;
    //bool IsInMotion = false;
    public GameObject Manager;

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1f)
        {
            //Debug.Log(rb.velocity.y);
            if (Input.GetKey("a"))
            {
                rb.AddForce(-xvelocity, 0);
            }
            if (Input.GetKey("d"))
            {
                rb.AddForce(xvelocity, 0);
            }
            if(transform.position.y < voidi)
            {
                Manager.GetComponent<PauseMenu>().GameEnds();
            }
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        //IsInMotion = false;
        //if(rb.velocity.y != 0.0f)
        //{
        //    IsInMotion = true;
        //}
        if (collision.collider.tag == "Ground")
        {
            // if (IsInMotion == false)
            if (rb.velocity.y == 0.0f)
            {
                if (Input.GetKey("space"))
                {
                    rb.AddForce(yvelocity, 0);
                }
            }

        }
    }
}