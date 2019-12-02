using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] float Speed = 20f;
    private Rigidbody Enemyrb;
    private GameObject Player; 

    // Start is called before the first frame update
    void Start()
    {
        Enemyrb = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        /* if(if player is within certain distance of enemy)
         {
             FollowPlayer();
         }*/
        FollowPlayer();
    }

    void FollowPlayer()
    {
        Vector3 FollowDirection = (Player.transform.position - transform.position).normalized;
        Enemyrb.AddForce(FollowDirection * Speed);
    }
}
