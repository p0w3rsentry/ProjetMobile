using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gachaWheel : MonoBehaviour
{
    [SerializeField]
    Text CoinsText;

    public int SpinResult;


    public static int G_Mass;
    public static int G_Bump;
    public static int G_Boss;
    public static int G_DP;

    public int Coins;

    void Start()
    {
        Coins = PlayerPrefs.GetInt("Coins");
        CoinsText.text = Coins.ToString();

        G_Mass = PlayerPrefs.GetInt("Mass");
        G_Bump = PlayerPrefs.GetInt("Bump");
        G_Boss = PlayerPrefs.GetInt("Boss");
        G_DP = PlayerPrefs.GetInt("DP");
    }


    public void Spin()
    {
        SpinResult = Random.Range(1, 5);

        

        Coins = PlayerPrefs.GetInt("Coins");


        if (PlayerPrefs.GetInt("Coins", Coins) >= 100)
        {
            PlayerPrefs.SetInt("Coins", Coins + 100);
            Coins = PlayerPrefs.GetInt("Coins");
            CoinsText.text = Coins.ToString();


            if (SpinResult == 1)
            {
                PlayerPrefs.SetInt("Mass", 1);
                G_Mass = PlayerPrefs.GetInt("Mass");

                PlayerPrefs.SetInt("Bump", 0);
                G_Bump = PlayerPrefs.GetInt("Bump");

                PlayerPrefs.SetInt("Boss", 0);
                G_Boss = PlayerPrefs.GetInt("Boss");

                PlayerPrefs.SetInt("DP", 0);
                G_DP = PlayerPrefs.GetInt("DP");
            }
            if (SpinResult == 2)
            {
                PlayerPrefs.SetInt("Mass", 0);
                G_Mass = PlayerPrefs.GetInt("Mass");

                PlayerPrefs.SetInt("Bump", 1);
                G_Bump = PlayerPrefs.GetInt("Bump");

                PlayerPrefs.SetInt("Boss", 0);
                G_Boss = PlayerPrefs.GetInt("Boss");

                PlayerPrefs.SetInt("DP", 0);
                G_DP = PlayerPrefs.GetInt("DP");
            }
            if (SpinResult == 3)
            {
                PlayerPrefs.SetInt("Mass", 0);
                G_Mass = PlayerPrefs.GetInt("Mass");

                PlayerPrefs.SetInt("Bump", 0);
                G_Bump = PlayerPrefs.GetInt("Bump");

                PlayerPrefs.SetInt("Boss", 1);
                G_Boss = PlayerPrefs.GetInt("Boss");

                PlayerPrefs.SetInt("DP", 0);
                G_DP = PlayerPrefs.GetInt("DP");
            }
            if (SpinResult == 4)
            {
                PlayerPrefs.SetInt("Mass", 0);
                G_Mass = PlayerPrefs.GetInt("Mass");

                PlayerPrefs.SetInt("Bump", 0);
                G_Bump = PlayerPrefs.GetInt("Bump");

                PlayerPrefs.SetInt("Boss", 0);
                G_Boss = PlayerPrefs.GetInt("Boss");

                PlayerPrefs.SetInt("DP", 1);
                G_DP = PlayerPrefs.GetInt("DP");
            }

            print(SpinResult);

        }
        else
        {
            print("Pas de $$$$");
        }
    }
}
