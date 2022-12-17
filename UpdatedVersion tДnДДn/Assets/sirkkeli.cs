using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sirkkeli : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject GameManager;
    void Start()
    {
        //PlayerPrefs.SetInt("Level", 1);
        //Debug.Log("moi");
        //Debug.Log(PlayerPrefs.GetInt("Level"));
        //SceneManager.LoadScene(PlayerPrefs.GetInt("Level", 1));
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hello");
        if (collision.CompareTag("Player"))
        {

            GameManager.GetComponent<PauseMenu>().GameEnds();
           
        }
    }
}
