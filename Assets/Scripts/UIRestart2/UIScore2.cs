using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UIScore2 : MonoBehaviour
{
    private TextMeshProUGUI textMeshProUGUI;

    private void Start()
    {
        textMeshProUGUI = gameObject.GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        textMeshProUGUI.text = "Score: " + ScoreSpeicher.score2.ToString();
    }
}

