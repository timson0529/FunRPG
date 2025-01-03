using UnityEngine;


[CreateAssetMenu(fileName = "Monster", menuName = "Monster/Create a new Monster")]
public class MonsterBase  : ScriptableObject
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
