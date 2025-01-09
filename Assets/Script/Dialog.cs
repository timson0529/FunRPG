using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Dialog : MonoBehaviour
{
    [SerializeField] GameObject dialogbox;
    [SerializeField] TextMeshProUGUI dialogtext;
    [SerializeField] int letterPerSecond;
    public event Action Onshow;
    public event Action noshow;
    public static Dialog Instance { get; private set; }
    private void Awake()
    {
        Instance = this;
    }
    int currentline = 0;
    dialogs dialog;
    bool istyping;
    public IEnumerator show(dialogs dialog)
    {
        yield return new WaitForEndOfFrame();
        Onshow?.Invoke();
        this.dialog = dialog;
        dialogbox.SetActive(true);
        StartCoroutine(typeDialog(dialog.Lines[0]));
    }

    public void HandleUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&!istyping)
        {
            ++currentline;
            if (currentline < dialog.Lines.Count)
            {
                StartCoroutine(typeDialog(dialog.Lines[currentline]));
            }
            else
            {
                currentline = 0;
                dialogbox.SetActive(false);
                noshow?.Invoke();
            }

        }
    }
    public IEnumerator typeDialog(string line)
    {
        istyping = true;
        dialogtext.text = "";
        foreach(var letter in line.ToCharArray())
        {
            dialogtext.text += letter;
            yield return new WaitForSeconds(1f/letterPerSecond);
        }
        istyping = false;
    }
}
