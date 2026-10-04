using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class JoinServer : MonoBehaviour
{
    private void Awake()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        NetworkManager.Singleton.StartClient();
    }
}
