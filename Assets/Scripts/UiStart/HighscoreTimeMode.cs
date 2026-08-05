using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class HighscoreTimeMode : MonoBehaviour
{
    private TextMeshProUGUI highscoreText;

    private void Start()
    {
        highscoreText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        int gespeicherterHighscoreBaseMode = PlayerPrefs.GetInt("HighscoreTimeMode", 0);

        if (ScoreSpeicher.score2 > gespeicherterHighscoreBaseMode)
        {
            PlayerPrefs.SetInt("HighscoreTimeMode", ScoreSpeicher.score2);
            PlayerPrefs.Save(); // optional, aber gut für sofortiges Speichern
            Debug.Log("Neuer Highscore: " + ScoreSpeicher.score2);
        }

        highscoreText.text = "Time Mode: " + PlayerPrefs.GetInt("HighscoreTimeMode", 0).ToString();
    }
}
