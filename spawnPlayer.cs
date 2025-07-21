using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlayer : MonoBehaviour
{
     public static int characterSelected = 10; 

     public GameObject character1;
     public GameObject character2;
     public GameObject character3;
     public GameObject character4;
     public GameObject character5;
     public GameObject character6;
     public GameObject character7;
     public GameObject character8;
     public GameObject character9;

    void Start()
    {
        characterSelected = PlayerPrefs.GetInt("selectCharacter");

        Debug.Log(characterSelected);

        if (characterSelected == 0)
        {
            Instantiate(character1, this.transform.position, Quaternion.identity);
        }


        else if (characterSelected == 1)
        {
            Instantiate(character2, this.transform.position, Quaternion.identity);
        }

        else if (characterSelected == 2)
        {
            Instantiate(character3, this.transform.position, Quaternion.identity);
        }

        else if (characterSelected == 3)
        {
            Instantiate(character4, this.transform.position, Quaternion.identity);
        }

        else if (characterSelected == 4)
        {
            Instantiate(character5, this.transform.position, Quaternion.identity);
        }

        else if (characterSelected == 5)
        {
            Instantiate(character6, this.transform.position, Quaternion.identity);
        }

        else if (characterSelected == 6)
        {
            Instantiate(character7, this.transform.position, Quaternion.identity);
        }

        else if (characterSelected == 7)
        {
            Instantiate(character8, this.transform.position, Quaternion.identity);
        }

        else if (characterSelected == 8)
        {
            Instantiate(character9, this.transform.position, Quaternion.identity);
        }
    }
}
