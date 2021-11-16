using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GOPanel;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        GOPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
