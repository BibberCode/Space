using UnityEngine;
using TMPro;

public class UIScoreGame2 : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        scoreText.text = ScoreSpeicher.score2.ToString();
    }
}
