using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupWorking : MonoBehaviour
{
    bool Pressed = false;
    public GameObject Player;
    public float maxdist;

    void OnMouseDown()
    {
        Pressed = true;
        GetComponent<Rigidbody2D>().isKinematic = true;
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

    void OnMouseUp()
    {
        Pressed = false;
        GetComponent<Rigidbody2D>().isKinematic = false;
        GetComponent<BoxCollider2D>().isTrigger = false;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("koska jolo");
        Pressed = false;
        GetComponent<Rigidbody2D>().isKinematic = false;
        GetComponent<BoxCollider2D>().isTrigger = false;
    }

    /*void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("moi moi");
        OnMouseUp();
        //Pressed = false;
        //GetComponent<Rigidbody2D>().isKinematic = false;
        //GetComponent<BoxCollider2D>().isTrigger = false;
    } */
    // Update is called once per frame

    void Update()
    {
        if (Pressed)
        {
            float distx = transform.position.x - Player.transform.position.x;
            float disty = transform.position.y - Player.transform.position.y;

            if (distx < maxdist & distx > -maxdist & disty < maxdist & disty > -maxdist)
            {
                Vector2 mousePos = UnityEngine.Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = mousePos;
            } else
            {
                Pressed = false;
                GetComponent<Rigidbody2D>().isKinematic = false;
                GetComponent<BoxCollider2D>().isTrigger = false;
            }
        }
    }
}