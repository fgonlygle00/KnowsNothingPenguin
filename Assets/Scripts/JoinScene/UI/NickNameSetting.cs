using UnityEngine;
using UnityEngine.UI;

public class NickNameSetting : MonoBehaviour
{
    public InputField _playerNameInput;

    public static NickNameSetting Instance;
    public void Awake()
    {
        Instance = this;
    }

    public void InputNickName()
    {
        PlayerPrefs.SetString("PlayerName", _playerNameInput.text);
    }
}
