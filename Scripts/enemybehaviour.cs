using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemybehaviour : MonoBehaviour

{   public int[] ehe;
    public Animator enim;
    private NavMeshAgent enemy;
    public Transform[] patrol;
    public Transform player, en;
    public bool IsChasing, IsAttack;
    public int index;
    public int eh = 100;
    

    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        enim.SetFloat("pat", 1);
    }

    // Update is called once per frame
    void Update()
    {
        enim.SetFloat("distance", 0);
        Chase();
        Patrol();
        Attack();
        //weapon.instance.OnTriggerEnter(player);
    }
    void Chase()
    {
        if (Vector3.Distance(transform.position, player.position) < 10)
        {
            
            enim.SetFloat("pat", 0);
            IsChasing = true;
           
            if (Vector3.Distance(transform.position, player.position) < 2.0f)
            {
                enemy.isStopped = true;
            }
            else
            {
               enemy.isStopped = false;
                enemy.SetDestination(new Vector3(player.transform.position.x+1, player.transform.position.y, player.transform.position.z));
            }
            
           
        }
        else if (Vector3.Distance(transform.position, patrol[index].position) > 10)
        {
            enim.SetFloat("pat", 1);
;            IsChasing = false;
            enemy.SetDestination(patrol[index].position);
        }
    }

    void Patrol()
    {
        if(IsChasing == false)
        {
            enim.SetFloat("pat", 1);
            if(Vector3.Distance(transform.position , patrol[index].position)<2)
            {
                index++;
                if (index >= 2)
                {
                    index = 0;
                }
                enemy.SetDestination(patrol[index].position);
            }
        }
    }
    void Attack()
    {
        if (Vector3.Distance(transform.position, player.position) < 5)
        {
            en.transform.LookAt(new Vector3(player.transform.position.x , transform.position.y, player.transform.position.z));
            
            enim.SetFloat("distance", 1);

        }
        
    }
   
}
