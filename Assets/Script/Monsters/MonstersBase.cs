using UnityEngine;


[CreateAssetMenu(fileName = "Monster", menuName = "Monster/Create a new Monster")]
public class MonstersBase  : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] MonstersType trpe;     //怪物的屬性

    //怪物基本狀態
    [SerializeField] int maxHP;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spDefense;
    [SerializeField] int spAttack;
    [SerializeField] int speed;
}

public enum MonstersType 
{
    一般,
    火,
    水,
    電,
    草,
    冰,
    格鬥,
    毒,
    地面,
    飛行,
    超能,
    蟲,
    岩石,
    幽靈,
    龍
}
