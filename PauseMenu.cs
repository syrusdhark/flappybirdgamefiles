using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame
    [SerializeField] GameObject Pausemenu;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pauseGame();
        }
        
    }
    void pauseGame()
    {
        Pausemenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resumegame()
    {
        Pausemenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
