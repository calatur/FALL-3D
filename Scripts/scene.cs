using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scene : MonoBehaviour
{

    void Start()
    {

    }
 public void playst()
    {
        SceneManager.LoadScene("SampleScene");
    }

public void controls()
    {
        SceneManager.LoadScene("Controls");
    }
public void bain()
    {
        SceneManager.LoadScene("Main");
    }
    public void Quit()
    {
        Application.Quit();
    }
}

