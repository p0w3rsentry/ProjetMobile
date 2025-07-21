using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DZCollision : MonoBehaviour
{
    public GameObject theEnnemy;
    public Transform spawnPoint;
    public GameObject deathMenu;
    public static bool revivePressed = false;
    public AudioSource audioSource;
    public AudioSource background;
    public Transform revivePoint1;
    private static GameObject Player;




    void Start()
    {
        Invoke("FindPlayer", 0.2f);
        Time.timeScale = 1f;
    }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            deathMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            collectibles.DoublePoints = false;
            audioSource.Play();
            background.Stop();
        }

        if (other.gameObject.CompareTag("enemies"))
        {
            //destroyGameObject();
            Destroy(other.gameObject);
            //theEnnemy.transform.position = spawnPoint.transform.position;
            Debug.Log("Ennemy Dead");
            
            WaveSysteme.enemiesCounter--;
        }

    }
    void destroyGameObject()
    {
        //Destroy(other.gameObject);
    }

    void Update()
    {
        theEnnemy = GameObject.FindGameObjectWithTag("enemies");
        if (revivePressed == true)
        {
            
            Revive2(); 
            
            
        }
    }

    void Revive2()
    {

        background.Play();
        deathMenu.SetActive(false);
        Player.transform.position = revivePoint1.transform.position; 
        Time.timeScale = 1f;
        revivePressed = false;
        WaveSysteme.roundCounter = WaveSysteme.roundCounter-1;
        WaveSysteme.waveNumber--;
        Destroy(GameObject.Find("enemie 1(Clone)"));
        WaveSysteme.enemiesCounter = 0;
    }

    void FindPlayer()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
}