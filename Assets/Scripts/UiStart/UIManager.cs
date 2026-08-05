using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.InputSystem;

public class UIManager : MonoBehaviour
{
    public GameObject firstGameModeButton;
    public GameObject secondGameModeButton;
    public TextMeshProUGUI selectText;
    
    private bool isVisible = false;

    private void Start()
    {
        firstGameModeButton.SetActive(false);
        secondGameModeButton.SetActive(false);
    }

    private void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame) { Application.Quit(); }
    }
    public void ShowGameModeButtons()
    {
        isVisible = !isVisible;

        if (firstGameModeButton != null)
            firstGameModeButton.SetActive(isVisible);

        if (secondGameModeButton != null)
            secondGameModeButton.SetActive(isVisible);
    }

    public void HideGameModeButtons()
    {
            firstGameModeButton.SetActive(false);
            secondGameModeButton.SetActive(false);
    }


    public void StarteSpiel()
    {
        if (UIGameModeSelector.gameModeSelector == 0)
        {
            SceneManager.LoadScene("FirstGameMode");
            UIGameModeSelector.gameModeSelector = 2;
        }

        if (UIGameModeSelector.gameModeSelector ==1)
        {
            UITimer2.timer = 60;
            SceneManager.LoadScene("SecondGameMode");
            UIGameModeSelector.gameModeSelector = 2;
        }
    }

    public void noGameModeSelect()
    {
        selectText.color = Color.red;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}


