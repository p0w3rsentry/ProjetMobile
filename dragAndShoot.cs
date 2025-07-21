using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class dragAndShoot : MonoBehaviour
{
    public AudioSource audioTheSource;
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;
    public float torque;
    private Rigidbody rb;

    //private bool isShoot;


    void Start()
    {

        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        mousePressDownPos = Input.mousePosition;
    }

    private void OnMouseUp()
    {
        audioTheSource.Play();
        // DrawTrajectory.Instance.HideLine();
        mouseReleasePos = Input.mousePosition;
        Shoot(mousePressDownPos - mouseReleasePos);
    }
    private void OnMouseDrag()
    {
        Vector3 forceInit = (Input.mousePosition - mousePressDownPos);
        Vector3 forceV = (new Vector3(forceInit.x, forceInit.y, forceInit.y)) * forceMultiplier;
        //if(!isShoot)
        //{
            //DrawTrajectory.Instance.UpdateTrajectiory(forceV, rb, transform.position);
        //}
    }

    private float forceMultiplier = 10;
    void Shoot(Vector3 Force)
    {
        

        rb.AddForce(new Vector3(Force.x, Force.z, Force.y) * forceMultiplier);
        //isShoot = true;
           // if(isShoot == true)
       // {
           // isShoot = false;
        //}
    }
    void update()
    {
        //float turn = Insput.GetAxis("Horizontal");
        rb.AddTorque(5,5,5 * torque);
        if (Input.touchCount >0)
        {
            
          Touch currentTouch = Input.touches[0];
    if(currentTouch.phase == TouchPhase.Began)
        {
        print("Touch down");
        }
else if(currentTouch.phase == TouchPhase.Ended)
{
    print("touch up");
}
}
    }
}