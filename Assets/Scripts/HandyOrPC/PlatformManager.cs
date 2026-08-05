using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public static PlatformManager Instance;
    public bool isMobile;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // bleibt beim Szenenwechsel erhalten
        }
        else
        {
            Destroy(gameObject); // verhindert Duplikate
        }

        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Debug.Log("Bildschirm Querformat");
    }

    public void SetPlatform(bool mobile)
    {
        isMobile = mobile;
    }
}
