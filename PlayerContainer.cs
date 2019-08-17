using UnityEngine;

public class PlayerContainer : MonoBehaviour {
    [SerializeField] Player player1;

    void Start()
    {
        player1.setDamage();
        player1.printStats();
    }
}
