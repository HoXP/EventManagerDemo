using Framework;
using UnityEngine;
using UnityEngine.UI;

public class UIB : MonoBehaviour
{
    public Text _txt = null;

    private void OnEnable()
    {
        ClientEventManager.Instance.RegisterEvent((int)EventId.EventIdTest, OnTest);
    }

    private void OnDisable()
    {
        ClientEventManager.Instance.UnRegisterEvent((int)EventId.EventIdTest, OnTest);
    }

    private void OnTest(ClientEvent eve)
    {
        _txt.text = eve.GetParameter<string>(0);
    }
}