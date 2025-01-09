using UnityEngine;
public enum GameState {Free,Dialog}
public class gamecontroller : MonoBehaviour
{
    GameState state;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Dialog.Instance.Onshow += () =>
        {
            state = GameState.Dialog;
        };
        Dialog.Instance.noshow += () =>
        {
            if(state == GameState.Dialog) 
                state = GameState.Free;
        };
    }

    // Update is called once per frame
    void Update()
    {
        if(state == GameState.Dialog)
        {
            Dialog.Instance.HandleUpdate();
        }
    }
}
