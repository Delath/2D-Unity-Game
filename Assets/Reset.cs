using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Reset started");
        Invoke("GoToMenu", 2.5f);
    }

    void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
