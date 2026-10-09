using UnityEngine;

public class EatAnswerManager : MonoBehaviour
{
    public GameObject appleCorrect;
    public GameObject breadWrong;

    void Start()
    {
        appleCorrect.SetActive(false);
        breadWrong.SetActive(false);
    }

    public void SelectApple()
    {
        appleCorrect.SetActive(true);
        breadWrong.SetActive(false);
    }

    public void SelectBread()
    {
        appleCorrect.SetActive(false);
        breadWrong.SetActive(true);
    }
}