using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject Penguin;
    [SerializeField] private GameObject SnowHuman;

    public void Awake()
    {
        if ((PlayerPrefs.GetInt("Active")) == 1)
        {
            Penguin.SetActive(true);
            SnowHuman.SetActive(false);
            MainCameraController.instance.target = Penguin;
        }
        if ((PlayerPrefs.GetInt("Active")) == 2)
        {
            SnowHuman.SetActive(true);
            Penguin.SetActive(false);
            MainCameraController.instance.target = SnowHuman;
        }
    }
}
