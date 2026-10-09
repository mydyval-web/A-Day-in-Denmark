using UnityEngine;

public class AnswerManager : MonoBehaviour
{
    public GameObject skoCorrect;
    public GameObject hatWrong;
    public GameObject bukserWrong;

    void Start()
    {
        skoCorrect.SetActive(false);
        hatWrong.SetActive(false);
        bukserWrong.SetActive(false);
    }

    public void SelectSko()
    {
        skoCorrect.SetActive(true);
        hatWrong.SetActive(false);
        bukserWrong.SetActive(false);

        Debug.Log("Correct answer!");
    }

    public void SelectHat()
    {
        skoCorrect.SetActive(false);
        hatWrong.SetActive(true);
        bukserWrong.SetActive(false);

        Debug.Log("Wrong answer - try again!");
    }

    public void SelectBukser()
    {
        skoCorrect.SetActive(false);
        hatWrong.SetActive(false);
        bukserWrong.SetActive(true);

        Debug.Log("Wrong answer - try again!");
    }
}