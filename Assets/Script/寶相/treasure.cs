using UnityEngine;
using UnityEngine.SceneManagement;

public class treasure : MonoBehaviour, interactable
{
    [SerializeField] dialogs dialog;
    public float destroyDelay = 2f;
     public void Interact()
    {
        StartCoroutine(Dialog.Instance.show(dialog));
        Destroy(gameObject, destroyDelay);
    }

}
