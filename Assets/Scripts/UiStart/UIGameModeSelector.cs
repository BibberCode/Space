using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIGameModeSelector : MonoBehaviour
{
    public static float gameModeSelector = 2;
    public Button firstGameMode;
    public Button secondGameMode;
    public TextMeshProUGUI gameModeSelectorText;

    private void Start()
    {
        gameModeSelectorText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (firstGameMode != null)
        {
            firstGameMode.onClick.AddListener(() => gameModeSelector = 0);

        }

        if (secondGameMode != null)
        {
            secondGameMode.onClick.AddListener(() => gameModeSelector = 1);
        }
    }
}

