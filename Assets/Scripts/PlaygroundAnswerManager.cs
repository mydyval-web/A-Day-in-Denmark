using UnityEngine;

public class PlaygroundAnswerManager : MonoBehaviour
{
    public GameObject ballCorrect;
    public GameObject slideWrong;

    void Start()
    {
        ballCorrect.SetActive(false);
        slideWrong.SetActive(false);
    }

    public void SelectBall()
    {
        ballCorrect.SetActive(true);
        slideWrong.SetActive(false);
    }

    public void SelectSlide()
    {
        ballCorrect.SetActive(false);
        slideWrong.SetActive(true);
    }
}