using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SwitchHandyControlPosition : MonoBehaviour
{
    private float handyControlPosition;
    [SerializeField] private Slider setterSlider;

    [SerializeField] private TextMeshProUGUI sliderNumber;
    [SerializeField] private GameObject handyControlManager;

    [Header("Test")]
    [SerializeField] private GameObject spaceShip;
    [SerializeField] private GameObject startTest;
    [SerializeField] private GameObject endTest;
    [SerializeField] private GameObject reset;
    [SerializeField] private GameObject goToMenu;
    [SerializeField] private GameObject musicEndTest;
    [SerializeField] private GameObject musicInTest;

    public void GoToScene()
    {
        SceneManager.LoadScene("SwitchHandyControlPosition");
    }

    public void GoToMenue()
    {
        SceneManager.LoadScene("UIStart");
    }

    public void TestStart()
    {
        GameObject slider = setterSlider.gameObject;
        GameObject temporarySliderNumber = sliderNumber.gameObject;
        temporarySliderNumber.SetActive(false);
        slider.SetActive(false);
        startTest.SetActive(false);
        reset.SetActive(false);
        musicEndTest.SetActive(false);
        goToMenu.SetActive(false);
        spaceShip.SetActive(true);
        endTest.SetActive(true);
        musicInTest.SetActive(true);
        handyControlManager.SetActive(true);
    }

    public void TestEnd()
    {
        GameObject slider = setterSlider.gameObject;
        GameObject temporarySliderNumber = sliderNumber.gameObject;
        temporarySliderNumber.SetActive(true);
        slider.SetActive(true);
        startTest.SetActive(true);
        reset.SetActive(true);
        goToMenu.SetActive(true);
        musicEndTest.SetActive(true);
        spaceShip.SetActive(false);
        endTest.SetActive(false);
        musicInTest.SetActive(false);
        handyControlManager.SetActive(false);
    }

    public void ResetPosition()
    {
        setterSlider.value = 0;
    }

    private void Awake()
    {
        setterSlider.value = PlayerPrefs.GetFloat("HandyControlPosition");
    }

    private void Update()
    {
        handyControlPosition = setterSlider.value;
        PlayerPrefs.SetFloat("HandyControlPosition", handyControlPosition);
        PlayerPrefs.Save(); // optional, aber empfehlenswert

        float positionFloat = PlayerPrefs.GetFloat("HandyControlPosition") + 235.625f;
        Vector3 position = transform.position;
        position.y = handyControlPosition + 235.625f;
        transform.position = position;

        sliderNumber.text = handyControlPosition.ToString("F2");
    }
}
