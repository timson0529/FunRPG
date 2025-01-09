using UnityEngine;

public class PersistentCinemachineCamera : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject); // ¨¾¤î Cinemachine Virtual Camera ³Q¾P·´
    }
}
