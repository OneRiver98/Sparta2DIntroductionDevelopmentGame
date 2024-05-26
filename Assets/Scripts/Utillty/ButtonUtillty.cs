using UnityEngine.SceneManagement;

public class ButtonUtillty : ButtonUI
{
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
            DataManager.Instance.name = tMP_InputField.text;
        }
        else
        {
            return;
        }
    }
}