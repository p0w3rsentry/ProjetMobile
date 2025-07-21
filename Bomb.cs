using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    //public GameObject exp;
    public float expForce, radius;
    public AudioSource audioSource;

    public MeshRenderer PLS;

    private void OnTriggerEnter(Collider other)
    {
       if( other.gameObject.CompareTag("Player"))
        {
            //GameObject _exp = Instantiate(exp, transform.position, transform.rotation);
            //Destroy(_exp, 3);
            knockBack();
            //gameObject.SetActive(false);
            //Invoke("dest", 1f);
            WaveSysteme.bombCounter--;
            audioSource.Play();
            Invoke("dest", 1f);
            PLS.enabled = false; 
        }

    }
    void dest()
    {
        Destroy(gameObject);
    }
    void knockBack()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius); 

        foreach (Collider nearby in colliders)
        {
            Rigidbody rigg = nearby.GetComponent<Rigidbody>(); 
            if(rigg != null)
            {
               rigg.AddExplosionForce(expForce, transform.position, radius);
            }
        }
    }
}
