using System;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text _currentTime;

    // Update is called once per frame
    void Update()
    {
        DateTime dateTime = DateTime.Now;
        _currentTime.text = dateTime.ToString("HH:mm");
    }
}
