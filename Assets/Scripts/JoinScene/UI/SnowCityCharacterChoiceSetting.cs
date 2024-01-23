using UnityEditor.SceneManagement;
using UnityEngine;

public class SnowCityCharacterChoiceSetting : MonoBehaviour
{
    [SerializeField] private GameObject choiceOption;
    [SerializeField] private GameObject Penguin;
    [SerializeField] private GameObject SnowHuman;

    public void ChoiceOption()
    {
        choiceOption.SetActive(true);
    }

    public void Update()
    {
        if (Penguin.activeSelf == true)
        {
            PlayerPrefs.SetInt("Active", 1);
        }
        else if (SnowHuman.activeSelf == true)
        {
            PlayerPrefs.SetInt("Active", 2);
        }
    }

    public void ChoicePenguin()
    {
        Penguin.SetActive(true);
        SnowHuman.SetActive(false);
        choiceOption.SetActive(false);
    }

    public void ChoiceSnowHuman()
    {
        SnowHuman.SetActive(true);
        Penguin.SetActive(false);
        choiceOption.SetActive(false);
    }
}
