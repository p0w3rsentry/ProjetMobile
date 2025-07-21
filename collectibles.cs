using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibles : MonoBehaviour
{
    public static bool DoublePoints = false;
    public int Coins;
    public AudioSource audioSource;

    public MeshRenderer PLS;


    void Start()
    {
        Coins = PlayerPrefs.GetInt("Coins");
        PLS.enabled = true;
        //CoinsText.text = Coins.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audioSource.Play();

            PlayerPrefs.SetInt("Coins", Coins + 10);

            Coins = PlayerPrefs.GetInt("Coins");

            WaveSysteme.collectibleCounter--;

            //CoinsText.text = Coins.ToString();

            if (DoublePoints)
            {
                PlayerPrefs.SetInt("Coins", Coins + 10);

                Coins = PlayerPrefs.GetInt("Coins");

                ///CoinsText.text = Coins.ToString();
            }

            PLS.enabled = false; 
            Invoke("Respawn", 0.5f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void Respawn()
    {
        Destroy(gameObject);
    }
}
