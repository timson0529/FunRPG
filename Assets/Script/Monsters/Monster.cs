using UnityEngine;

public class Monster : MonoBehaviour
{
    MonsterBase _base;
    int level;

    public Monster (MonsterBase pBase, int pLevel)  //creator
    {
        _base = pBase;
        level = pLevel;

    }
}
