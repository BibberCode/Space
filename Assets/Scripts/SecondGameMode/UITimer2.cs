using UnityEngine;
using TMPro;

public class UITimer2 : MonoBehaviour
{
    public static float timer = 60;
    private TextMeshProUGUI textMeshProUGUI;
    private GameObject SpaceShip;

    private void Start()
    {
        textMeshProUGUI = gameObject.GetComponent<TextMeshProUGUI>();

        GameObject target = GameObject.Find("SpaceShip2");
        SpaceShip = target;
    }

    public void Update()
    {
        timer -= Time.deltaTime; //Timer herunterzälen
        
        if (timer <= 0)
        {
            Destroy(SpaceShip);
        }

        if (timer <= 10) { textMeshProUGUI.color = Color.red; }

        textMeshProUGUI.text = Mathf.FloorToInt(timer).ToString(); //Anzeige aktualisieren
    }
}
