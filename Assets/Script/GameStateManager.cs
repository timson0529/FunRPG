using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance;

    public Vector3 playerPosition; // �O�s�����m
    public bool isTreasureCollected; // �ܨҡG�O�s�_�ìO�_�Q����
    public bool isDoorOpen; // �ܨҡG�O�s���O�_�}��

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // �T�O���������ɤ��Q�P��
        }
        else
        {
            Destroy(gameObject); // �T�O�u�s�b�@�ӹ��
        }
    }

    public void SavePlayerPosition(Vector3 position)
    {
        playerPosition = position;
    }

    public Vector3 LoadPlayerPosition()
    {
        return playerPosition;
    }
}
