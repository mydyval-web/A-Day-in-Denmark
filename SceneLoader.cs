using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void OpenMorning()
    {
        SceneManager.LoadScene("Morning");
    }

    public void OpenHome()
    {
        SceneManager.LoadScene("Home");
    }
    
    public void OpenMeet()
    {
        SceneManager.LoadScene("Meet");
    }

    public void BackToMorning() 
    {
        SceneManager.LoadScene("Morning");
    }

    public void OpenPlayground()
    {
        SceneManager.LoadScene("Playground");
    }

    public void BackToMeet()
    {
        SceneManager.LoadScene("Meet");
    }

    public void BackToPlayground()
    {
        SceneManager.LoadScene("Playground");
    }

    public void OpenEat()
    {
        SceneManager.LoadScene("Eat");
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene("Credit");
    }

}