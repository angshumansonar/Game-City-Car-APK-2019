using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmanu : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene("playmanu");
    }
    public void quitbt()
    {
        Application.Quit();
    }
    public void mainmanubt()
    {
        SceneManager.LoadScene("mainmanu");
    }
    public void highqualitybt()
    {
        QualitySettings.SetQualityLevel(2);
    }
    public void mediumqualitybt()
    {
        QualitySettings.SetQualityLevel(1);
    }
    public void lowqualitybt()
    {
        QualitySettings.SetQualityLevel(0);
    }
    public void heelps()
    {
        SceneManager.LoadScene("helps");
    }

}
