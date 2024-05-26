using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonUtillty : ButtonUI
{
    public Image SelectedCharacterImage;
    public Sprite[] CharacterImages;

    public void ChangeStartSceneToMainScene()
    {
        if (tMP_InputField.text.Length >= 2 || tMP_InputField.text.Length >= 10)
        {
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            return;
        }
    }

    public void ChangeName()
    {
        if (tMP_InputField.text.Length <= 2 || tMP_InputField.text.Length <= 10)
        {
            DataManager.Instance.playerName = tMP_InputField.text;
        }
        else
        {
            return;
        }
    }

    public void ChoiceCharacterImage(int num)
    {
        SelectedCharacterImage.sprite = CharacterImages[num];
        DataManager.Instance.choiceNum = num;
    }
}
