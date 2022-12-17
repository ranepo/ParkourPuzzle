using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yeeeeeeeeet : MonoBehaviour
{
    public GameObject SceneManager;
    // Start is called before the first frame update


    // Update is called once per frame
     void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.GetComponent<Scenes>().LoadNewScene();
    }
}
