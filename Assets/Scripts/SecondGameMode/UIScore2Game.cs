using UnityEngine;
using TMPro;

public class UIScore2Game : MonoBehaviour
{
    private TextMeshProUGUI scoreTextGame;

    private void Start()
    {
        scoreTextGame = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        scoreTextGame.text = ScoreSpeicher.score2.ToString();
    }
}
