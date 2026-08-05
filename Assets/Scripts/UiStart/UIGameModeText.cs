using UnityEngine;
using TMPro;

public class UIGameModeText : MonoBehaviour
{
    private TextMeshProUGUI selectText;

    private void Start()
    {
        selectText = gameObject.GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        if (UIGameModeSelector.gameModeSelector == 0)
        {
            selectText.text = "Base Mode";
            selectText.color = Color.white;
        }

        if (UIGameModeSelector.gameModeSelector == 1)
        {
            selectText.text = "Time Mode";
            selectText.color = Color.white;
        }

        if (UIGameModeSelector.gameModeSelector == 2)
        {
            selectText.text = "Please Select a Game Mode";
            selectText.color = Color.red;
        }
    }
}
