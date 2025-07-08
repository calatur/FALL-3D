using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playermove : MonoBehaviour
{
    public Animator anim;
    public CharacterController player;
    public Transform pl, tr, en, cof;
    public float rspeed = 0.3f;
    float x, y;
    int i=0;
    public int ph = 1200, index = 600;
    public Text hp, pht;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;       
    }
    void Update()
    {   hp.text = "Heal Points: " + index.ToString();
        pht.text = "HP: " + ph.ToString();

        tr.transform.position = new Vector3(pl.transform.position.x, pl.transform.position.y+1.64f , pl.transform.position.z);
        
        anim.SetFloat("vertical", Input.GetAxis("Vertical"));

        if (Input.GetKey(KeyCode.L)){
            i = 1;
        }
        if (Input.GetKey(KeyCode.U)) {
            i = 0;
            Debug.Log(i);
        }

        anim.SetFloat("block", 0);
        //anim.SetFloat("light", 0);
        anim.SetFloat("heavy", 0);
        anim.SetFloat("roll", 0);
        move();
        attack();
    }
     
    public void move()
    {
        if (i == 1)
        {
            player.transform.rotation = Quaternion.Euler(0, x, 0);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Rotate(Vector3.up * 2.5f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Rotate(Vector3.down * 2.5f);
        }
        
        if ((Input.GetKey(KeyCode.W)) && (Input.GetKey(KeyCode.D)))
        {
            anim.SetFloat("vertical", 1);
            player.transform.Rotate(Vector3.up * 1.5f);
        }
        if ((Input.GetKey(KeyCode.W)) && (Input.GetKey(KeyCode.A)))
        {
            player.transform.Rotate(Vector3.down * 1.5f);
        }
        if ((Input.GetKey(KeyCode.S)) && (Input.GetKey(KeyCode.D)))
        {
            player.transform.Rotate(Vector3.up * 1.5f);
        }
        if ((Input.GetKey(KeyCode.S)) && (Input.GetKey(KeyCode.A)))
        {
            player.transform.Rotate(Vector3.down * 1.5f);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetFloat("block", 1);
            player.transform.rotation = Quaternion.Euler(0, x, 0);
        }
        if (Input.GetKey(KeyCode.R))
        {
            anim.SetFloat("roll", 1);
        }
    }
    public void attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetFloat("light", 7);
        }
        if (Input.GetMouseButtonDown(1))
        {
            anim.SetFloat("heavy", 2);
        }
    }
    private void LateUpdate()
    {
        anim.SetFloat("light", 0);
        x += Input.GetAxis("Mouse X") * rspeed;
        y += Input.GetAxis("Mouse Y") * rspeed;

        Camera.main.transform.LookAt(tr);
          tr.rotation = Quaternion.Euler(0, x, 0);     
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("Ascend");
        }
    }

}
