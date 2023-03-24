using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject startPanel, endPanel, pausePanel;
    ButtonPause buttonPause;
    // Start is called before the first frame update

    private void Awake()
    {
            startPanel.SetActive(true);
            endPanel.SetActive(false);
            pausePanel.SetActive(false);
            Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
