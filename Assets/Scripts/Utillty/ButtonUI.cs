using TMPro;
using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    protected TMP_InputField tMP_InputField;

    protected void Awake()
    {
        tMP_InputField = GetComponentInChildren<TMP_InputField>();
    }
}
