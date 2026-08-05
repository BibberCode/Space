using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformSelector : MonoBehaviour
{
    public void OnMobileSelected()
    {
        PlatformManager.Instance.SetPlatform(true);
        SceneManager.LoadScene("UIStart");
    }

    public void OnPCSelected()
    {
        PlatformManager.Instance.SetPlatform(false);
        SceneManager.LoadScene("UIStart");
    }
}
