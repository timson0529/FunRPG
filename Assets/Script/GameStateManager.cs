using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance;

    public Vector3 playerPosition; // 保存角色位置
    public bool isTreasureCollected; // 示例：保存寶藏是否被收集
    public bool isDoorOpen; // 示例：保存門是否開啟

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // 確保場景切換時不被銷毀
        }
        else
        {
            Destroy(gameObject); // 確保只存在一個實例
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
