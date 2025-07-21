using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class rebound : MonoBehaviour
{
    public AudioSource audioSource;
    public ParticleSystem ps;
    public Transform enemie;
    private Rigidbody rb;
    public static float forceMultiplier = 35;
    //Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
        ParticleSystem ps = GameObject.Find("FX_CRASH").GetComponent<ParticleSystem>();
        ps.Stop();
    }

    //Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("enemies"))
        
        {
            audioSource.Play();
            ContactPoint contact = collision.contacts[0];
        Shoot((rb.transform.position - contact.point)*40);
        print("Collision is working!");
            ps.Play();
            StartCoroutine(ExecuteAfterTime(1f));
            IEnumerator ExecuteAfterTime(float time)
            {
                yield return new WaitForSeconds(time);
                ps.Stop();
                // Code to execute after the delay
            }
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
        enemie = GameObject.FindGameObjectWithTag("enemies").transform;
        // float bounce = 6f; //amount of force to apply
        // rb.AddForce(3,3,3 * bounce);
    }
}
