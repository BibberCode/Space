using UnityEngine;

public class GameSceneInitializer : MonoBehaviour
{
    public GameObject arrowKeysUI; // z. B. Canvas-Objekt mit Pfeiltasten

    void Start()
    {
        if (PlatformManager.Instance != null && PlatformManager.Instance.isMobile)  { arrowKeysUI.SetActive(true); }
        else { arrowKeysUI.SetActive(false); }
    }

    private void Update()
    {
        if (gameObject.name == "Exit Button")
        {
            if (PlatformManager.Instance != null && PlatformManager.Instance.isMobile) { gameObject.SetActive(false); }
            else { gameObject.SetActive(true); } 
        }
    }
}
