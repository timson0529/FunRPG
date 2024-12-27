using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Portal : MonoBehaviour
{
    [Header("Scene Settings")]
    [SerializeField] private int targetSceneIndex = -1; // �ؼг��������ޡA�ݦb Build Settings ���]�m

    private bool isTeleporting = false; // ����ƶǰe

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isTeleporting && targetSceneIndex >= 0)
        {
            Debug.Log("Player entered the portal!"); // �T�{Ĳ�o
            isTeleporting = true;
            StartCoroutine(LoadTargetScene());
        }
    }

    private IEnumerator LoadTargetScene()
    {
        // �i��G����ǰe�S�ĩέ��ġ]���B�ٲ��^

        // �T�O�������Ƥ����]��p�H�X�ĪG�i�H��b�o�̡^
        yield return new WaitForSeconds(0.2f); // �p����A�קK���`

        // �[���ؼг���
        AsyncOperation operation = SceneManager.LoadSceneAsync(targetSceneIndex);
        while (!operation.isDone)
        {
            yield return null; // ���ݳ����[������
        }

        isTeleporting = false; // �ǰe����
    }


}
