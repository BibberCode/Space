using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class HighscoreBaseMode : MonoBehaviour
{
    private TextMeshProUGUI highscoreText;

    private void Start()
    {
        highscoreText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        int gespeicherterHighscoreBaseMode = PlayerPrefs.GetInt("HighscoreBaseMode", 0);

        if (ScoreSpeicher.score1 > gespeicherterHighscoreBaseMode)
        {
            PlayerPrefs.SetInt("HighscoreBaseMode", ScoreSpeicher.score1);
            PlayerPrefs.Save(); // optional, aber gut für sofortiges Speichern
            Debug.Log("Neuer Highscore: " + ScoreSpeicher.score1);
        }

        highscoreText.text = "Base Mode: " + PlayerPrefs.GetInt("HighscoreBaseMode", 0).ToString();
    }
}
