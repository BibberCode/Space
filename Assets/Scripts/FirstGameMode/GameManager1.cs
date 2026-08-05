using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score;
    public bool gameOver = false;

    void Start()
    {
        instance = this;
    }
}
