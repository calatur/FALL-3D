using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class weapon : MonoBehaviour
{
    public int[] eh;
       public int b, w, a;
    public Text eht;
    public Animator aniim;
    private void Update()
    {
        b = 0;
        w = 0;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            b = 1;
        }
        if((Input.GetKey(KeyCode.W))||(Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.A)) ||
            (Input.GetKey(KeyCode.D)))
        {
            w = 1;
        }
        if (aniim.GetCurrentAnimatorStateInfo(0).IsName("light attack"))
        {
            a = 1;
        }
        else a = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
       if ((other.gameObject.tag == "enemy")&&(b ==0) && (w ==0) && (a ==1) )
        {
            eh[0] = eh[0] - 12;
            eht.text = "Enemy: " + eh[0].ToString();
            if (eh[0] <= 0) 
            {
                eht.text = "";
                Destroy(other.gameObject);
            }
        }    
       if ((other.gameObject.tag == "e1")&&(b ==0) && (w ==0) && (a == 1))
        {
            eh[1]= eh[1] - 12;
            eht.text = "Enemy: " + eh[1].ToString();
            if (eh[1] <= 0)
            {
                eht.text = "";
                Destroy(other.gameObject);
            }
        }
        if ((other.gameObject.tag == "e2") && (b == 0) && (w == 0) && (a == 1))
        {
            eh[2] = eh[2] - 12;
            eht.text = "Enemy: " + eh[2].ToString();
            if (eh[2] <= 0)
            {
                eht.text = "";
                Destroy(other.gameObject);
            }
        }
        if ((other.gameObject.tag == "e3") && (b == 0) && (w == 0) && (a == 1))
        {
            eh[3] = eh[3] - 12;
            eht.text = "Enemy: " + eh[3].ToString();
            if (eh[3] <= 0)
            {
                eht.text = "";
                Destroy(other.gameObject);
            }
        }
        if((other.gameObject.tag == "e4") && (b == 0) && (w == 0) && (a == 1))
        {
            eh[4] = eh[4] - 12;
            eht.text = "Enemy: "+ eh[4].ToString();
            if (eh[4]<=0)
            {
                eht.text = "";
                Destroy(other.gameObject);
            }
        }
    if ((other.gameObject.tag == "e5") && (b == 0) && (w == 0) && (a == 1)) 
        {
            eh[5] = eh[5] - 12;
            eht.text = "Enemy: " + eh[5].ToString();
            if (eh[5]<=0) 
            {
                eht.text = "";
                Destroy(other.gameObject);
            }
        }




}
}
