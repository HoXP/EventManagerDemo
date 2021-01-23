using Framework;
using UnityEngine;
using UnityEngine.UI;

public class UIA : MonoBehaviour
{
    public Button _btn = null;

    private void Awake()
    {
        _btn.onClick.AddListener(OnClickBtn);
    }

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnClickBtn()
    {
        ClientEventManager.Instance.PushEvent((int)EventId.EventIdTest, true, 0, $"{gameObject.name}_{Random.Range(0, 100)}");
    }
}