using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class rebound_Enemie : MonoBehaviour
{

    public Transform enemie;
    private Rigidbody rb;
    public static float forceMultiplier = 10;
    //Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    //Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            ContactPoint contact = collision.contacts[0];
        Shoot((rb.transform.position - contact.point) *80);
        print("ECollision is working!");
        }
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
    void Update()
    {
        
        // float bounce = 6f; //amount of force to apply
        // rb.AddForce(3,3,3 * bounce);
    }
}