using UnityEngine;


[CreateAssetMenu(fileName = "Monster", menuName = "Monster/Create a new Monster")]
public class MonstersBase  : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] MonstersType trpe;     //�Ǫ����ݩ�

    //�Ǫ��򥻪��A
    [SerializeField] int maxHP;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spDefense;
    [SerializeField] int spAttack;
    [SerializeField] int speed;
}

public enum MonstersType 
{
    �@��,
    ��,
    ��,
    �q,
    ��,
    �B,
    �氫,
    �r,
    �a��,
    ����,
    �W��,
    ��,
    ����,
    ���F,
    �s
}
