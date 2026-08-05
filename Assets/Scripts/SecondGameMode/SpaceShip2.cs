using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SpaceShip2 : MonoBehaviour
{
    public GameObject spaceShip;

    public float moveSpeed;

    public GameObject laser;

    public ParticleSystem hitParticle;

    public AudioClip hit;
    public AudioClip shoot;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        Movement();
        Shooting();
    }

    void Movement()
    {
        Vector3 movement = Vector3.right * Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -24, 24);
        transform.position = position;
    }

    void Shooting()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(laser, gameObject.transform.position, laser.transform.rotation);

            audioSource.clip = shoot;
            audioSource.Play();
        }
    }

    private void OnDestroy()
    {
        SceneManager.LoadScene("UIRestart2");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            UITimer2.timer -= 3;
            Destroy(other.gameObject);

            Instantiate(hitParticle, spaceShip.transform.position, hitParticle.transform.rotation);     //Hit Particle erstellen

            audioSource.clip = hit;   //Shoot Sound
            audioSource.Play();
            #if UNITY_ANDROID || UNITY_IOS
            Handheld.Vibrate();
            #endif
        }
    }
}


