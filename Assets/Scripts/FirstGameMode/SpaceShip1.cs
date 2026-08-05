using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceShip : MonoBehaviour
{
    public float moveSpeed;

    public GameObject laser;

    public AudioClip shoot;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        Movement();
        Schooting();
    }

    void Movement()
    {
        Vector3 movement = Vector3.right * Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -24, 24);
        transform.position = position;
    }

    void Schooting()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(laser, gameObject.transform.position, laser.transform.rotation);

            audioSource.clip = shoot;
            audioSource.Play();
        }
    }

     private void OnTriggerEnter(Collider other)
     {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        #if UNITY_ANDROID || UNITY_IOS
        Handheld.Vibrate();
        #endif
        }
    }

    private void OnDestroy()
    {
        SceneManager.LoadScene("UIRestart1");
    }
}

    
    
