using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class enemy : MonoBehaviour
{
    private Transform player;
    private Rigidbody rb;
    public float thrust = -20;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody>();
        // rb.AddForce(thrust,0, 0, ForceMode.Impulse);
        InvokeRepeating("DoIt", 2.0f, 2.0f);


    }
    public float forceMultiplier = 30;

    void DoIt()
    {
        
         
            Shoot((player.position - rb.transform.position) * 22);
        
        //transform.Rotate(player.position, Space.Self); 
    }
    void Shoot(Vector3 Force)
    {


        rb.AddForce(new Vector3(Force.x, Force.y, Force.z) * forceMultiplier);
        //isShoot = true;
        // if(isShoot == true)
        // {
        // isShoot = false;
        //}
    }
    // Update is called once per frame
    void Update()
    {
       // Vector3 lookVector = player.transform.position - transform.position;
        //lookVector.y = transform.position.y;
        //Quaternion rot = Quaternion.LookRotation(lookVector);
       // transform.rotation = Quaternion.Slerp(transform.rotation, rot, 1);
    }
}