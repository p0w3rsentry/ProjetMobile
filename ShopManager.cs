using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
    [SerializeField]
    Text CoinsText;
    [SerializeField]
    Text HRCoinsText;



    public static bool ReviveClick = true; 

    /// WHEEL ///
   
    public GameObject DB_Panel;
    public GameObject Heavier_Panel;
    public GameObject HeadStart_Panel;
    public GameObject DC_Panel;





    /// LEVELS ///

    public static int Level_1;
    public static int Level_2;
    public static int Level_3;
    public static int Level_4;
    public static int Level_5;
    public static int Level_6;

    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;
    public GameObject level6;



    /// SKINS ///
    
    public static int Skin_1;
    public static int Skin_2;
    public static int Skin_3;
    public static int Skin_4;
    public static int Skin_5;
    public static int Skin_6;
    public static int Skin_7;
    public static int Skin_8;
    public static int Skin_9;

    public GameObject skin1;
    public GameObject skin2;
    public GameObject skin3;
    public GameObject skin4;
    public GameObject skin5;
    public GameObject skin6;
    public GameObject skin7;
    public GameObject skin8;
    public GameObject skin9;

    public int Coins;

    

    public int HRCoins;

    public int SpinResult;


    public static int G_Mass;
    public static int G_Bump;
    public static int G_Boss;
    public static int G_DP;


    void Start()
    {
        Coins = PlayerPrefs.GetInt("Coins");

        HRCoins = PlayerPrefs.GetInt("HRCoins");

        CoinsText.text = Coins.ToString();

        HRCoinsText.text = HRCoins.ToString();


        /// SKINS ///
        Skin_1 = PlayerPrefs.GetInt("Skin1");

        Skin_2 = PlayerPrefs.GetInt("Skin2");

        Skin_3 = PlayerPrefs.GetInt("Skin3");

        Skin_4 = PlayerPrefs.GetInt("Skin4");

        Skin_5 = PlayerPrefs.GetInt("Skin5");

        Skin_6 = PlayerPrefs.GetInt("Skin6");

        Skin_7 = PlayerPrefs.GetInt("Skin7");

        Skin_8 = PlayerPrefs.GetInt("Skin8");

        Skin_9 = PlayerPrefs.GetInt("Skin9");

        skin1 = GameObject.Find("Skin1Button");
        skin2 = GameObject.Find("Skin2Button");
        skin3 = GameObject.Find("Skin3Button");
        skin4 = GameObject.Find("Skin4Button");
        skin5 = GameObject.Find("Skin5Button");
        skin6 = GameObject.Find("Skin6Button");
        skin7 = GameObject.Find("Skin7Button");
        skin8 = GameObject.Find("Skin8Button");
        skin9 = GameObject.Find("Skin9Button");

        PlayerPrefs.SetInt("Skin1", 1);

        Skin_1 = PlayerPrefs.GetInt("Skin1");

        if (Skin_2 != 0)
        {
            skin2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        else
        {
            skin2.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }

        if (Skin_3 != 0)
        {
            skin3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        else
        {
            skin3.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }

        if (Skin_4 != 0)
        {
            skin4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        else
        {
            skin4.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }

        if (Skin_5 != 0)
        {
            skin5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        else
        {
            skin5.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }

        if (Skin_6 != 0)
        {
        skin6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        else
        {
        skin6.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }

        if (Skin_7 != 0)
        {
            skin7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        else
        {
            skin7.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }

        if (Skin_8 != 0)
        {
            skin8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        else
        {
            skin8.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }

        if (Skin_9 != 0)
        {
            skin9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        else
        {
            skin9.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }

        //if (Skin_10 != 0)
        //{
            //skin10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        //}
        //else
        //{
            //skin10.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        //}

        /// LEVELS ///

        Level_1 = PlayerPrefs.GetInt("Level1");

        Level_2 = PlayerPrefs.GetInt("Level2");

        Level_3 = PlayerPrefs.GetInt("Level3");

        Level_4 = PlayerPrefs.GetInt("Level4");

        Level_5 = PlayerPrefs.GetInt("Level5");

        Level_6 = PlayerPrefs.GetInt("Level6");

        level1 = GameObject.Find("Level1Button");
        level2 = GameObject.Find("Level2Button");
        level3 = GameObject.Find("Level3Button");
        level4 = GameObject.Find("Level4Button");
        level5 = GameObject.Find("Level5Button");
        level6 = GameObject.Find("Level6Button");

        PlayerPrefs.SetInt("Level1", 1);

        Level_1 = PlayerPrefs.GetInt("Level1");

        if (Level_2 != 0)
        {
            level2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        else
        {
            level2.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }

        if (Level_3 != 0)
        {
            level3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        else
        {
            level3.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }

        if (Level_4 != 0)
        {
            level4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        else
        {
            level4.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }

        if (Level_5 != 0)
        {
            level5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        else
        {
            level5.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }

        //if (Level_6 != 0)
        //
        //level6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        //}
        //else
        //{
        //level6.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        //}

        G_Mass = PlayerPrefs.GetInt("Mass");
        G_Bump = PlayerPrefs.GetInt("Bump");
        G_Boss = PlayerPrefs.GetInt("Boss");
        G_DP = PlayerPrefs.GetInt("DP");
    }

    public void AddCoins()
    {
        PlayerPrefs.SetInt("Coins", Coins + 500);

        Coins = PlayerPrefs.GetInt("Coins");

        CoinsText.text = Coins.ToString();
    }

    public void AddCoins1()
    {
        PlayerPrefs.SetInt("HRCoins", HRCoins + 500);

        HRCoins = PlayerPrefs.GetInt("HRCoins");

        CoinsText.text = Coins.ToString();
    }

    /// SKINS ///

    public void Skin2()
    {   
            if (HRCoins >= 50)
            {

                skin2.GetComponent<Button>().interactable = true;

                if (Skin_2 != 0)
                {
                    
                }
                else
                {
                    HRCoins -= 50;

                    HRCoins = PlayerPrefs.GetInt("HRCoins", HRCoins);
                    HRCoinsText.text = HRCoins.ToString();

                    PlayerPrefs.SetInt("Skin2", 1);

                    Skin_2 = PlayerPrefs.GetInt("Skin2");

                    SceneManager.LoadScene(1);
                }
            }
            else
            {
                
            }       
    }

    public void Skin3()
    {
        if (HRCoins >= 50)
        {

            

            if (Skin_3 != 0)
            {

            }
            else
            {
                HRCoins -= 50;

                HRCoins = PlayerPrefs.GetInt("HRCoins", HRCoins);
                HRCoinsText.text = HRCoins.ToString();

                PlayerPrefs.SetInt("Skin3", 1);

                Skin_3 = PlayerPrefs.GetInt("Skin3");

                SceneManager.LoadScene(1);

            }
        }
        else
        {
           
        }
    }

    public void Skin4()
    {
        if (HRCoins >= 50)
        {



            if (Skin_4 != 0)
            {

            }
            else
            {
                HRCoins -= 50;

                HRCoins = PlayerPrefs.GetInt("HRCoins", HRCoins);
                HRCoinsText.text = HRCoins.ToString();

                PlayerPrefs.SetInt("Skin4", 1);

                Skin_4 = PlayerPrefs.GetInt("Skin4");

                SceneManager.LoadScene(1);

            }
        }
        else
        {

        }
    }

    public void Skin5()
    {
        if (HRCoins >= 50)
        {



            if (Skin_5 != 0)
            {

            }
            else
            {
                HRCoins -= 50;

                HRCoins = PlayerPrefs.GetInt("HRCoins", HRCoins);
                HRCoinsText.text = HRCoins.ToString();

                PlayerPrefs.SetInt("Skin5", 1);

                Skin_5 = PlayerPrefs.GetInt("Skin5");

                SceneManager.LoadScene(1);

            }
        }
        else
        {

        }
    }

    public void Skin6()
    {
        if (HRCoins >= 50)
        {



            if (Skin_6 != 0)
            {

            }
            else
            {
                HRCoins -= 50;

                HRCoins = PlayerPrefs.GetInt("HRCoins", HRCoins);
                HRCoinsText.text = HRCoins.ToString();

                PlayerPrefs.SetInt("Skin6", 1);

                Skin_6 = PlayerPrefs.GetInt("Skin6");

                SceneManager.LoadScene(1);

            }
        }
        else
        {

        }
    }

    public void Skin7()
    {
        if (HRCoins >= 50)
        {



            if (Skin_7 != 0)
            {

            }
            else
            {
                HRCoins -= 50;

                HRCoins = PlayerPrefs.GetInt("HRCoins", HRCoins);
                HRCoinsText.text = HRCoins.ToString();

                PlayerPrefs.SetInt("Skin7", 1);

                Skin_7 = PlayerPrefs.GetInt("Skin7");

                SceneManager.LoadScene(1);

            }
        }
        else
        {

        }
    }

    public void Skin8()
    {
        if (HRCoins >= 50)
        {



            if (Skin_8 != 0)
            {

            }
            else
            {
                HRCoins -= 50;

                HRCoins = PlayerPrefs.GetInt("HRCoins", HRCoins);
                HRCoinsText.text = HRCoins.ToString();

                PlayerPrefs.SetInt("Skin8", 1);

                Skin_8 = PlayerPrefs.GetInt("Skin8");

                SceneManager.LoadScene(1);

            }
        }
        else
        {

        }
    }

    public void Skin9()
    {
        if (HRCoins >= 50)
        {



            if (Skin_9 != 0)
            {

            }
            else
            {
                HRCoins -= 50;

                HRCoins = PlayerPrefs.GetInt("HRCoins", HRCoins);
                HRCoinsText.text = HRCoins.ToString();

                PlayerPrefs.SetInt("Skin9", 1);

                Skin_9 = PlayerPrefs.GetInt("Skin9");

                SceneManager.LoadScene(1);

            }
        }
        else
        {

        }
    }



    /// LEVELS ///

    public void Level2()
    {
        if (Coins >= 200)
        {

            level2.GetComponent<Button>().interactable = true;

            if (Level_2 != 0)
            {

            }
            else
            {
                Coins -= 200;

                Coins = PlayerPrefs.GetInt("Coins", Coins);
                CoinsText.text = Coins.ToString();

                PlayerPrefs.SetInt("Level2", 1);

                Level_2 = PlayerPrefs.GetInt("Level2");

                SceneManager.LoadScene(1);
            }
        }
        else
        {

        }
    }

    public void Level3()
    {
        if (Coins >= 200)
        {

            level3.GetComponent<Button>().interactable = true;

            if (Level_3 != 0)
            {

            }
            else
            {
                Coins -= 200;

                Coins = PlayerPrefs.GetInt("Coins", Coins);
                CoinsText.text = Coins.ToString();

                PlayerPrefs.SetInt("Level3", 1);

                Level_3 = PlayerPrefs.GetInt("Level3");

                SceneManager.LoadScene(1);
            }
        }
        else
        {

        }
    }

    public void Level4()
    {
        if (Coins >= 200)
        {

            level4.GetComponent<Button>().interactable = true;

            if (Level_4 != 0)
            {

            }
            else
            {
                Coins -= 200;

                Coins = PlayerPrefs.GetInt("Coins", Coins);
                CoinsText.text = Coins.ToString();

                PlayerPrefs.SetInt("Level4", 1);

                Level_4 = PlayerPrefs.GetInt("Level4");

                SceneManager.LoadScene(1);
            }
        }
        else
        {

        }
    }

    public void Level5()
    {
        if (Coins >= 200)
        {

            level5.GetComponent<Button>().interactable = true;

            if (Level_5 != 0)
            {

            }
            else
            {
                Coins -= 200;

                Coins = PlayerPrefs.GetInt("Coins", Coins);
                CoinsText.text = Coins.ToString();

                PlayerPrefs.SetInt("Level5", 1);

                Level_5 = PlayerPrefs.GetInt("Level5");

                SceneManager.LoadScene(1);
            }
        }
        else
        {

        }
    }

    public void Level6()
    {
        if (Coins >= 200)
        {

            level6.GetComponent<Button>().interactable = true;

            if (Level_6 != 0)
            {

            }
            else
            {
                Coins -= 200;

                Coins = PlayerPrefs.GetInt("Coins", Coins);
                CoinsText.text = Coins.ToString();

                PlayerPrefs.SetInt("Level6", 1);

                Level_6 = PlayerPrefs.GetInt("Level6");

                SceneManager.LoadScene(1);
            }
        }
        else
        {

        }
    }



    public void Spin()
    {
        SpinResult = Random.Range(1, 5);

        if (Coins >= 100)
        {
            PlayerPrefs.SetInt("Coins", Coins - 100);
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

                DB_Panel.active = true;
                Heavier_Panel.active = false;
                HeadStart_Panel.active = false;
                DC_Panel.active = false;
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

                DB_Panel.active = false;
                Heavier_Panel.active = true;
                HeadStart_Panel.active = false;
                DC_Panel.active = false;
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

                DB_Panel.active = false;
                Heavier_Panel.active = false;
                HeadStart_Panel.active = true;
                DC_Panel.active = false;
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

                DB_Panel.active = false;
                Heavier_Panel.active = false;
                HeadStart_Panel.active = false;
                DC_Panel.active = true;
            }

            print(SpinResult);

        }
        else
        {
            print("Pas de $$$$");
        }
    } 

    public void Update()
    {
        if (ReviveClick == true)
        {
            if (HRCoins >= 1)
            {
                PlayerPrefs.SetInt("HRCoins", HRCoins - 1);
                DZCollision.revivePressed = true;
            }
            else
            {
                print("Pas de $$$$");
            }

            print("caca");
        }
    }

}