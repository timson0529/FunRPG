using UnityEngine;

public class NPCcontroller : MonoBehaviour, interactable
{
    [SerializeField] dialogs dialog;
    public void Interact()
    {
        StartCoroutine(Dialog.Instance.show(dialog));
    }
}
