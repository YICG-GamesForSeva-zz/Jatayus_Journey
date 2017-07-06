using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDescriptionBehavior : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log("Hit!"); 
    }

    public void progressTrigger(int ind)
    {
        switch (ind)
        {
            case (0):
                SceneManager.LoadScene("Main");
                break;
            case (1):
                SceneManager.LoadScene("Menu");
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}