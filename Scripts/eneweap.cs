using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class eneweap : MonoBehaviour
{
    public playermove playermove;
    public int ph, b;
    public Text hp, pht;
    void Start()
    {
        playermove = FindObjectOfType<playermove>();
    }

    void Update()
    {
        
        b = 0;
            
        if (Input.GetKey(KeyCode.LeftShift))
        {
            b = 1;
        }
        if((Input.GetKey(KeyCode.H))&& (playermove.index > 0))
        {
            if (playermove.ph < 1200)
            {
                playermove.ph++;

                playermove.index = playermove.index - 1;
            }           
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player") && (b == 0))
        {
            playermove.ph = playermove.ph - 50;
            
            if (playermove.ph <= 0) {
                Destroy(other.gameObject);
                SceneManager.LoadScene("Death");
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
}
