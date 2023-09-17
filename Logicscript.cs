using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logicscript : MonoBehaviour
{
    public double playerscore;
    public Text scoretext;
    public GameObject gameoverscreen;
    public GameObject GAMEovermenu;
    public void addScore(int scoreToAdd)
    {
        playerscore+= scoreToAdd;
        scoretext.text = playerscore.ToString(); 
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        gameoverscreen.SetActive(true);

    }
    public void Gameovermenu()
    {
        GAMEovermenu.SetActive(true);
    }
    
    

}
