using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartBtn()
    {
        if ( 2 <= NickNameSetting.Instance._playerNameInput.text.Length && NickNameSetting.Instance._playerNameInput.text.Length <= 10)
        {
            NickNameSetting.Instance.InputNickName();
            SceneManager.LoadScene("MainScene");
        }
    }
}
