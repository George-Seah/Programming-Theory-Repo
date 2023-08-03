using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject gameOverMenuUI;

    void Start(){
        gameOverMenuUI.SetActive(false);
        ProjectileBehavior.distanceChangeable = true;
        PlayerBehavior.projectileLaunched = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused){
                Resume();
            }
            else{
                Pause();
            }
        }
        //(ProjectileBehavior.distanceChangeable == null) && PlayerBehavior.projectileLaunched
        if(PlayerBehavior.projectileLaunched && !ProjectileBehavior.distanceChangeable){
            gameOverMenuUI.SetActive(true);
        }
        else{
            gameOverMenuUI.SetActive(false);
        }
    }
    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void MainMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void Quit(){
        Debug.Log("Quit Button was pressed");
        Application.Quit();
    }
    public void Restart(){
        Debug.Log($"Restart Button was pressed and distanceChangeable is {ProjectileBehavior.distanceChangeable}");
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ProjectileBehavior.distanceChangeable = true;
        PlayerBehavior.projectileLaunched = false;
    }
}
