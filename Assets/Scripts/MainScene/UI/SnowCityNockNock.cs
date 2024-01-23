using UnityEngine;

public class SnowCityNockNock : MonoBehaviour
{
    [SerializeField] private GameObject _nockNcok;

    private void OnTriggerStay2D(Collider2D collision)
    {
        _nockNcok.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _nockNcok.SetActive(false);
    }
}
