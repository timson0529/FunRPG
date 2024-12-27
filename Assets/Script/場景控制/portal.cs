using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Portal : MonoBehaviour
{
    [Header("Scene Settings")]
    [SerializeField] private int targetSceneIndex = -1; // 目標場景的索引，需在 Build Settings 中設置

    private bool isTeleporting = false; // 防止重複傳送

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isTeleporting && targetSceneIndex >= 0)
        {
            Debug.Log("Player entered the portal!"); // 確認觸發
            isTeleporting = true;
            StartCoroutine(LoadTargetScene());
        }
    }

    private IEnumerator LoadTargetScene()
    {
        // 可選：播放傳送特效或音效（此處省略）

        // 確保場景平滑切換（比如淡出效果可以放在這裡）
        yield return new WaitForSeconds(0.2f); // 小延遲，避免異常

        // 加載目標場景
        AsyncOperation operation = SceneManager.LoadSceneAsync(targetSceneIndex);
        while (!operation.isDone)
        {
            yield return null; // 等待場景加載完成
        }

        isTeleporting = false; // 傳送結束
    }


}
