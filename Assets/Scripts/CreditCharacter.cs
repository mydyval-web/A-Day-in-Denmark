using UnityEngine;

public class CreditCharacter : MonoBehaviour
{
    public GameObject girl;
    public GameObject boy;

    void Start()
    {
        if (CharacterSelector.selectedCharacter == 1)
        {
            girl.SetActive(true);
            boy.SetActive(false);
        }
        else if (CharacterSelector.selectedCharacter == 2)
        {
            girl.SetActive(false);
            boy.SetActive(true);
        }
    }
}