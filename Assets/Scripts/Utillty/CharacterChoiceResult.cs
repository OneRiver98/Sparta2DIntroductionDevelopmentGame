using UnityEngine;

public class CharacterChoiceResult : MonoBehaviour
{
    public GameObject[] PlayerCharacters;

    private void Start()
    {
        PlayerCharacters[DataManager.Instance.choiceNum].SetActive(true);
    }
}