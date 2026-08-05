using UnityEngine;
using UnityEngine.SceneManagement;

public class UIRestartButton2 : MonoBehaviour
{
    private void Awake()
    {
        int gespeicherterHighscoreBaseMode = PlayerPrefs.GetInt("HighscoreTimeMode", 0);

        if (ScoreSpeicher.score2 > gespeicherterHighscoreBaseMode)
        {
            PlayerPrefs.SetInt("HighscoreTimeMode", ScoreSpeicher.score2);
            PlayerPrefs.Save(); // optional, aber gut für sofortiges Speichern
            Debug.Log("Neuer Highscore: " + ScoreSpeicher.score2);
        }
    }

    public void StarteSpiel()
    {
        SceneManager.LoadScene("SecondGameMode");
        ScoreSpeicher.score2 = 0;
        UITimer2.timer = 60;
    }

    public void GeheMenue()
    {
        ScoreSpeicher.score2 = 0;

        SceneManager.LoadScene("UIStart");
    }
}

