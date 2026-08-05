using UnityEngine;
using UnityEngine.UI;

public class HandyControl : MonoBehaviour
{
    public float moveSpeed;
    public GameObject laserObjekt;
    public GameObject spaceShip;
    
    public Button ShootButton;

    private bool moveLeft = false;
    private bool moveRight = false;

    public GameObject handyControl;

    public void StartMovingLeft() => moveLeft = true;
    public void StopMovingLeft() => moveLeft = false;

    public void StartMovingRight() => moveRight = true;
    public void StopMovingRight() => moveRight = false;


    private void Start()
    {
        ShootButton.onClick.AddListener(Shooting);
    }

    private void Update()
    {
        if (moveLeft)
            spaceShip.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            

        if (moveRight)
            spaceShip.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        float handyControlPosition = PlayerPrefs.GetFloat("HandyControlPosition");
        Vector3 position = handyControl.transform.position;
        position.y = handyControlPosition + 235.625f;
        handyControl.transform.position = position;
    }

    public void Shooting()
    {
        Instantiate(laserObjekt, spaceShip.transform.position, laserObjekt.transform.rotation);
    }
}
