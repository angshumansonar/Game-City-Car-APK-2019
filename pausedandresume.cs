using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class pausedandresume : MonoBehaviour
{
    public GameObject pausedui;
    public GameObject caraudio;
    public static bool gamepaused = false;
    
    private void Start()
    {
        pausedui.SetActive(false);
        //caraudio.SetActive(true);
    }
    private void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Alpha6"))
        {
            if (gamepaused)
            {
                resume();
                
            }
            else
            {
                paused();
                
            }
        }
    }

    public void paused()
    {
        pausedui.SetActive(true);
        caraudio.SetActive(false);
        Time.timeScale = 0f;
        gamepaused = true;
        
    }
    public void resume()
    {
        Time.timeScale = 1f;
        pausedui.SetActive(false);
        caraudio.SetActive(true);
        gamepaused = false;
        
    }
   
}
