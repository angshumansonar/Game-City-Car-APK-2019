using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelselection : MonoBehaviour
{
    public void level1()
    {
        SceneManager.LoadScene("level1");
        Time.timeScale = 1f;
        //caraudio.SetActive(true);

    }
    public void mainmanubt()
    {
        SceneManager.LoadScene("mainmanu");
        Time.timeScale = 1f;

    }
    public void level2()
    {
        SceneManager.LoadScene("level2");
        Time.timeScale = 1f;
        //caraudio.SetActive(true);
    }
    public void level3()
    {
        SceneManager.LoadScene("level3");
        Time.timeScale = 1f;
        //caraudio.SetActive(true);
    }
    public void level4()
    {
        SceneManager.LoadScene("level4");
        Time.timeScale = 1f;
        //caraudio.SetActive(true);
    }
}
