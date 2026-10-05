using UnityEngine;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour
{
    public static int selectedCharacter = 0;

    public GameObject circleGirl;
    public GameObject circleBoy;
    public Button startButton;

    void Start()
    {
        selectedCharacter = 0;

        circleGirl.SetActive(false);
        circleBoy.SetActive(false);

        startButton.interactable = false;
    }

    public void SelectGirl()
    {
        selectedCharacter = 1;

        circleGirl.SetActive(true);
        circleBoy.SetActive(false);

        startButton.interactable = true;

        Debug.Log("Girl selected");
    }

    public void SelectBoy()
    {
        selectedCharacter = 2;

        circleGirl.SetActive(false);
        circleBoy.SetActive(true);

        startButton.interactable = true;

        Debug.Log("Boy selected");
    }
}