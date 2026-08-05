using UnityEngine;
using UnityEngine.SceneManagement;

public class UIRestartButton1 : MonoBehaviour
{
    private void Awake()
    {
        int gespeicherterHighscoreBaseMode = PlayerPrefs.GetInt("HighscoreBaseMode", 0);

        if (ScoreSpeicher.score1 > gespeicherterHighscoreBaseMode)
        {
            PlayerPrefs.SetInt("HighscoreBaseMode", ScoreSpeicher.score1);
            PlayerPrefs.Save(); // optional, aber gut für sofortiges Speichern
            Debug.Log("Neuer Highscore: " + ScoreSpeicher.score1);
        }
    }
    public void StarteSpiel()
    {
        SceneManager.LoadScene("FirstGameMode");
        ScoreSpeicher.score1 = 0;
        UITimer2.timer = 60;
    }

    public void GeheMenue()
    {
        ScoreSpeicher.score1 = 0;

        SceneManager.LoadScene("UIStart");
    }
}

