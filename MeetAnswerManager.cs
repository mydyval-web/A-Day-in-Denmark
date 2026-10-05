using UnityEngine;
using UnityEngine.UI;

public class MeetAnswerManager : MonoBehaviour
{
    public Image hejButton;
    public Image farvelButton;

    public void SelectHej()
    {
        hejButton.color = new Color(0.6f, 1f, 0.6f);
        farvelButton.color = Color.white;
    }

    public void SelectFarvel()
    {
        farvelButton.color = new Color(1f, 0.6f, 0.6f);
        hejButton.color = Color.white;
    }
}