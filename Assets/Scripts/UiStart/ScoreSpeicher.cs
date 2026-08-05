using UnityEngine;

public class ScoreSpeicher : MonoBehaviour
{
    public static int score1 = 0;
    public static int score2 = 0;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}

