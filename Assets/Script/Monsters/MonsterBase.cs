using UnityEngine;


[CreateAssetMenu(fileName = "Monster", menuName = "Monster/Create a new Monster")]
public class MonsterBase  : ScriptableObject
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

    public string Getname()
    {
        return name;
    }

    public string Name 
    {
        get { return name; }
    }

    public string Description 
    {  
        get { return description; } 
    }

    public int MaxHP 
    { 
        get { return maxHP; } 
    }

    public Sprite FrontSprite 
    {
        get { return frontSprite; } 
    }

    public Sprite BackSprite 
    { 
        get { return backSprite; } 
    }

    public int Attack 
    { 
        get { return attack; } 
    }
    

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
