using UnityEngine;

// TEMPLATE -> stores information

[CreateAssetMenu(menuName = "Player")]
public class Player : ScriptableObject
{
    // name
    // level
    // race

    [SerializeField] string name1;
    [SerializeField] int level;
    [SerializeField] string race;
    int damage = 0;

    // printStats()
    // setDamage()

    public void setDamage()
    {
        damage = level * 10; // 100 ; 10
    }

    public void printStats()
    {
        Debug.Log("This player's name is: " + name1);
        Debug.Log("This player's level is: " + level);
        Debug.Log("This player's race is: " + race);
        Debug.Log("This player's damage is: " + damage);
    }
}
