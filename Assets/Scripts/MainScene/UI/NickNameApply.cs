using UnityEngine;
using UnityEngine.UI;

public class NickNameApply : MonoBehaviour
{
    [SerializeField] private Text _playerName;

    private void Awake()
    {
        _playerName.text = PlayerPrefs.GetString("PlayerName");
    }
}
