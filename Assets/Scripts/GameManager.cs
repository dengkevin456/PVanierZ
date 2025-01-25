using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool isTutorialLevel = false;
    private GameObject[] zombies;
    private GameObject[] zombieSpawnPos;
    
    
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(instance);
            return;
        }

        instance = this;
    }
}
