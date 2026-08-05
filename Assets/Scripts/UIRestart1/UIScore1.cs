using UnityEngine;
using TMPro;

public class UIScore1 : MonoBehaviour
{
    private TextMeshProUGUI textMeshProUGUI;

    private void Start()
    {
        textMeshProUGUI = gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        textMeshProUGUI.text = "Score: " + ScoreSpeicher.score1.ToString();
    }
}
