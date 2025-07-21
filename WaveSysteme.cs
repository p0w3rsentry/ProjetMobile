using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaveSysteme : MonoBehaviour
{
    public static int enemiesCounter;
    public static int waveNumber;
    public GameObject waveText;
    public GameObject enemy;
    public GameObject bomb;
    public GameObject boss;
    public GameObject collectible;
    public Transform bombspawn1;
    public Transform bombspawn2;
    public Transform bombspawn3;
    public Transform bombspawn4;
    
    public Transform collectibleSpawn1;
    public Transform collectibleSpawn2;
    public Transform collectibleSpawn3;
    public Transform mobspawn1;
    public Transform mobspawn2;
    public Transform mobspawn3;
    public Transform mobspawn4;
    public static int roundCounter;
    public static int bombCounter;
    public static int collectibleCounter;
  
    // Start is called before the first frame update
    void Start()
    {
        roundCounter = 1;
        waveNumber = 0;
        enemiesCounter = GameObject.FindGameObjectsWithTag("enemies").Length;
        
    }
    void Wave1()
    {
    print("wave1");

        if (collectibleCounter < 0) { collectibleCounter = 0; }
        
            if (collectibleCounter == 0)
            {
                Instantiate(collectible, collectibleSpawn1.position, collectibleSpawn1.rotation);

                collectibleCounter = collectibleCounter + 1;
            }
        
        if (bombCounter==0)
        {
            Instantiate(bomb, bombspawn2.position, bombspawn2.rotation);
            Instantiate(bomb, bombspawn1.position, bombspawn1.rotation);
           bombCounter = bombCounter+2;
        }
        Instantiate(enemy, mobspawn1.position, mobspawn1.rotation);
       
        enemiesCounter = GameObject.FindGameObjectsWithTag("enemies").Length;
        waveNumber++;
        roundCounter++;
      
    }
void Wave2()
{
        if (collectibleCounter < 0) { collectibleCounter = 0; }
        if (collectibleCounter == 0)
        {
            Instantiate(collectible, collectibleSpawn1.position, collectibleSpawn1.rotation);

            collectibleCounter = collectibleCounter + 1;
        }
        if (bombCounter == 0)
        {
            Instantiate(bomb, bombspawn2.position, bombspawn2.rotation);
            Instantiate(bomb, bombspawn1.position, bombspawn1.rotation);
            bombCounter =  bombCounter + 2;
        }
        
        Instantiate(enemy, mobspawn2.position, mobspawn2.rotation);
        enemiesCounter = GameObject.FindGameObjectsWithTag("enemies").Length;
        waveNumber++;
        print("wave2");
        roundCounter++;
}
    void Wave3()
    {
        if (collectibleCounter < 0) { collectibleCounter = 0; }
        if (collectibleCounter == 0)
        {
           
            Instantiate(collectible, collectibleSpawn2.position, collectibleSpawn2.rotation);

            collectibleCounter = collectibleCounter + 1;
        }
        if (bombCounter == 0)
        {
            Instantiate(bomb, bombspawn2.position, bombspawn2.rotation);
            Instantiate(bomb, bombspawn1.position, bombspawn1.rotation);
            bombCounter = bombCounter + 2;
        }
        Instantiate(enemy, mobspawn3.position, mobspawn3.rotation);
        enemiesCounter = GameObject.FindGameObjectsWithTag("enemies").Length;
        waveNumber++;
        print("wave3");
        roundCounter++;
    }
    void Wave4()
    {
        if (collectibleCounter < 0) { collectibleCounter = 0; }
        if (collectibleCounter == 0)
        {
            Instantiate(collectible, collectibleSpawn1.position, collectibleSpawn1.rotation);
            Instantiate(collectible, collectibleSpawn2.position, collectibleSpawn2.rotation);

            collectibleCounter = collectibleCounter + 2;
        }
        if (bombCounter == 0)
        {
            Instantiate(bomb, bombspawn2.position, bombspawn2.rotation);
            Instantiate(bomb, bombspawn3.position, bombspawn3.rotation);
            Instantiate(bomb, bombspawn1.position, bombspawn1.rotation);
            bombCounter = bombCounter +3;
        }
        Instantiate(enemy, mobspawn1.position, mobspawn1.rotation);
        Instantiate(enemy, mobspawn2.position, mobspawn2.rotation);
        enemiesCounter = GameObject.FindGameObjectsWithTag("enemies").Length;
        waveNumber++;
        print("wave4");
        roundCounter++;
    }
    void Wave5()
    {
        if (collectibleCounter < 0) { collectibleCounter = 0; }
        if (collectibleCounter == 0)
        {
            Instantiate(collectible, collectibleSpawn1.position, collectibleSpawn1.rotation);
            Instantiate(collectible, collectibleSpawn2.position, collectibleSpawn2.rotation);

            collectibleCounter = collectibleCounter + 2;
        }
        if (bombCounter == 0)
        {
            Instantiate(bomb, bombspawn2.position, bombspawn2.rotation);
            Instantiate(bomb, bombspawn3.position, bombspawn3.rotation);
            Instantiate(bomb, bombspawn1.position, bombspawn1.rotation);
            bombCounter = bombCounter + 3;
        }
        Instantiate(enemy, mobspawn3.position, mobspawn3.rotation);
        Instantiate(enemy, mobspawn2.position, mobspawn2.rotation);
        enemiesCounter = GameObject.FindGameObjectsWithTag("enemies").Length;
        waveNumber++;
        print("wave5");
        roundCounter++;
    }
    void Wave6()
    {
        if (collectibleCounter < 0) { collectibleCounter = 0; }
        if (collectibleCounter == 0)
        {
            Instantiate(collectible, collectibleSpawn1.position, collectibleSpawn1.rotation);
            Instantiate(collectible, collectibleSpawn2.position, collectibleSpawn2.rotation);

            collectibleCounter = collectibleCounter + 2;
        }
        if (bombCounter == 0)
        {
            Instantiate(bomb, bombspawn2.position, bombspawn2.rotation);
            Instantiate(bomb, bombspawn3.position, bombspawn3.rotation);
            Instantiate(bomb, bombspawn1.position, bombspawn1.rotation);
            bombCounter = bombCounter + 3;
        }
        Instantiate(enemy, mobspawn3.position, mobspawn3.rotation);
        Instantiate(enemy, mobspawn1.position, mobspawn1.rotation);
        enemiesCounter = GameObject.FindGameObjectsWithTag("enemies").Length;
        waveNumber++;
        print("wave6");
        roundCounter++;
    }
    void Wave7()
    {
        if (collectibleCounter < 0) { collectibleCounter = 0; }
        if (collectibleCounter == 0)
        {
            Instantiate(collectible, collectibleSpawn1.position, collectibleSpawn1.rotation);
            Instantiate(collectible, collectibleSpawn2.position, collectibleSpawn2.rotation);
            Instantiate(collectible, collectibleSpawn3.position, collectibleSpawn3.rotation);

            collectibleCounter = collectibleCounter + 3;
        }
        if (bombCounter == 0)
        {
            Instantiate(bomb, bombspawn2.position, bombspawn2.rotation);
            Instantiate(bomb, bombspawn3.position, bombspawn3.rotation);
            Instantiate(bomb, bombspawn1.position, bombspawn1.rotation);
            bombCounter = bombCounter + 3;
        }
        Instantiate(enemy, mobspawn2.position, mobspawn2.rotation);
        Instantiate(enemy, mobspawn3.position, mobspawn3.rotation);
        Instantiate(enemy, mobspawn4.position, mobspawn4.rotation);
        enemiesCounter = GameObject.FindGameObjectsWithTag("enemies").Length;
        waveNumber++;
        print("wave7");
        roundCounter++;
    }
    void Wave8()
    {
        if (collectibleCounter < 0) { collectibleCounter = 0; }
        if (collectibleCounter == 0)
        {
            Instantiate(collectible, collectibleSpawn1.position, collectibleSpawn1.rotation);
            Instantiate(collectible, collectibleSpawn2.position, collectibleSpawn2.rotation);
            Instantiate(collectible, collectibleSpawn3.position, collectibleSpawn3.rotation);

            collectibleCounter = collectibleCounter + 3;
        }
        if (bombCounter == 0)
        {
            Instantiate(bomb, bombspawn4.position, bombspawn4.rotation);
            Instantiate(bomb, bombspawn2.position, bombspawn2.rotation);
            Instantiate(bomb, bombspawn3.position, bombspawn3.rotation);
            Instantiate(bomb, bombspawn1.position, bombspawn1.rotation);
            bombCounter = bombCounter + 4;
        }
        Instantiate(enemy, mobspawn1.position, mobspawn1.rotation);
        Instantiate(enemy, mobspawn3.position, mobspawn3.rotation);
        Instantiate(enemy, mobspawn4.position, mobspawn4.rotation);
        enemiesCounter = GameObject.FindGameObjectsWithTag("enemies").Length;
        waveNumber++;
        print("wave8");
        roundCounter++;
    }
    void Wave9()
    {
        if (collectibleCounter < 0) { collectibleCounter = 0; }
        if (collectibleCounter == 0)
        {
            Instantiate(collectible, collectibleSpawn1.position, collectibleSpawn1.rotation);
            Instantiate(collectible, collectibleSpawn2.position, collectibleSpawn2.rotation);
            Instantiate(collectible, collectibleSpawn3.position, collectibleSpawn3.rotation);

            collectibleCounter = collectibleCounter + 3;
        }
        if (bombCounter == 0)
        {
            Instantiate(bomb, bombspawn4.position, bombspawn4.rotation);
            Instantiate(bomb, bombspawn2.position, bombspawn2.rotation);
            Instantiate(bomb, bombspawn3.position, bombspawn3.rotation);
            Instantiate(bomb, bombspawn1.position, bombspawn1.rotation);
            bombCounter = bombCounter + 4;
        }
        Instantiate(enemy, mobspawn1.position, mobspawn1.rotation);
        Instantiate(enemy, mobspawn3.position, mobspawn3.rotation);
        Instantiate(enemy, mobspawn2.position, mobspawn2.rotation);
        enemiesCounter = GameObject.FindGameObjectsWithTag("enemies").Length;
        waveNumber++;
        print("wave9");
        roundCounter++;
    }
    void Wave10()
    {
        if (collectibleCounter < 0) { collectibleCounter = 0; }
        if (collectibleCounter == 0)
        {
            Instantiate(collectible, collectibleSpawn1.position, collectibleSpawn1.rotation);
            Instantiate(collectible, collectibleSpawn2.position, collectibleSpawn2.rotation);
            Instantiate(collectible, collectibleSpawn3.position, collectibleSpawn3.rotation);

            collectibleCounter = collectibleCounter + 3;
        }
        if (bombCounter == 0)
        {
            Instantiate(bomb, bombspawn4.position, bombspawn4.rotation);
            Instantiate(bomb, bombspawn2.position, bombspawn2.rotation);
            Instantiate(bomb, bombspawn3.position, bombspawn3.rotation);
            Instantiate(bomb, bombspawn1.position, bombspawn1.rotation);
            bombCounter = bombCounter + 4;
        }
        Instantiate(boss, mobspawn4.position, mobspawn4.rotation);
        enemiesCounter = GameObject.FindGameObjectsWithTag("enemies").Length;
        waveNumber++;
        print("wave10");
        roundCounter=1;
        rebound.forceMultiplier =  rebound.forceMultiplier+5;
        rebound_Enemie.forceMultiplier--;
    }
    // Update is called once per frame
    void Update()
    {
        if (roundCounter == 1 & enemiesCounter == 0)
        {
            Wave1();
        }
        if (roundCounter==2 & enemiesCounter==0)
        {
            Wave2();
        }
        if(roundCounter == 3 & enemiesCounter == 0)
        {
            Wave3();
        }
        if (roundCounter == 4 & enemiesCounter == 0)
        {
            Wave4();
        }
        if (roundCounter == 5 & enemiesCounter == 0)
        {
            Wave5();
        }
        if (roundCounter == 6 & enemiesCounter == 0)
        {
            Wave6();
        }
        if (roundCounter == 7 & enemiesCounter == 0)
        {
            Wave7();
        }
        if (roundCounter == 8 & enemiesCounter == 0)
        {
            Wave8();
        }
        if (roundCounter == 9 & enemiesCounter == 0)
        {
            Wave9();
        }
        if (roundCounter == 10 & enemiesCounter == 0)
        {
            Wave10();
        }
        waveText.GetComponent<Text>().text = "wave "+ waveNumber;
    }
}
