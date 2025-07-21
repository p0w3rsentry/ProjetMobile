using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaManager : MonoBehaviour
{
    public static int MassCounter = 0;
    public static int bumpCounter = 0;
    public static int BossCounter = 0;
    public static int doubleCounter = 0;

    public static int G_Mass;
    public static int G_Bump;
    public static int G_Boss;
    public static int G_DP;

    public static int Double_Points;

    void Start()
    {
        G_Mass = PlayerPrefs.GetInt("Mass");
        G_Bump = PlayerPrefs.GetInt("Bump");
        G_Boss = PlayerPrefs.GetInt("Boss");
        G_DP = PlayerPrefs.GetInt("DP"); 

        Double_Points = PlayerPrefs.GetInt("DoublePoints");
    }




    void Update()
    {
        if(PlayerPrefs.GetInt("Mass") != 0)
        {
            Mass();
        }

        if (PlayerPrefs.GetInt("Bump") != 0)
        {
            Bump();
        }

        if (PlayerPrefs.GetInt("Boss") != 0)
        {
            Boss();
        }

        if (PlayerPrefs.GetInt("DP") != 0)
        {
            DoublePoint();
        }
    }






    void Mass()
    {
        rebound.forceMultiplier = 30;
        MassCounter--;
        Debug.Log("reduce ally bump for next game");
        //reduce ally bump for next game
    }
    void Bump()
    {
        bumpCounter--;
        rebound_Enemie.forceMultiplier = 15;
        Debug.Log("augment enemie bump for next game");
        // augment enemie bump for next game
    }
    void Boss()
    {
        BossCounter--;
        WaveSysteme.roundCounter = 10;
        Debug.Log("start at round 10");
        //start at round 10
    }
    void DoublePoint()
    {
        PlayerPrefs.SetInt("DoublePoints", 1);
        G_Bump = PlayerPrefs.GetInt("DoublePoints");
        Debug.Log("collectible worth double");
        // collectible worth double
    }
}
