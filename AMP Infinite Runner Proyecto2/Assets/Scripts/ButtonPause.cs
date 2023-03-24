using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class ButtonPause : MonoBehaviour
{
    public GameObject pausePanel,startPanel,endPanel;
    public TextMeshProUGUI textPoints,textFinalPoints,textFinalTime;

    //public int returnToTitle = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    #region Menu Start
    public void Begin()
    {
        startPanel.SetActive(false);
        Time.timeScale = 1.0f;
    }
    #endregion

    #region Pause Game
    public void Pause()
    {
     pausePanel.SetActive(true);
     Time.timeScale = 0f;
    }
    public void Continue()
    {
     pausePanel.SetActive(false);
     Time.timeScale = 1f;
     }
     public void ResetButton()
    {
        pausePanel.SetActive(false);
        endPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    #endregion


    #region Menu End
    public void Restart() //Not added as i could not use the player prefs
    {
        //PLayer pref booleano, para evitar triggerear el awake. 
        //PlayerPrefs.SetInt("returnToTitle", 0);
        //returnToTitle = PlayerPrefs.GetInt("returnToTitle");
        //print(returnToTitle);

        endPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
        //textPoints.text = "Puntos: " + playerMovement.puntos; //is this redundante? already on update from player movement
    }
    
    public void ReturnMainTitle()
    {
        //PlayerPrefs.SetInt("returnToTitle", 1);
        //returnToTitle = PlayerPrefs.GetInt("returnToTitle");
        //print(returnToTitle);

        endPanel.SetActive(false);
        startPanel.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //  Player pref a FALSE. 

        //textPoints.text = "Puntos: " + playerMovement.puntos; //is this redundante? already on update from player movement
    }

    //Since its WEB, its not added to the game.
    public void QuitGame()
    {
        Application.Quit();
    }
    #endregion
}

