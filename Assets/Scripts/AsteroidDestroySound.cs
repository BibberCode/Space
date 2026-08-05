using UnityEngine;

public class AsteroidDestroySound : MonoBehaviour
{
    public AudioClip destroySound;
    private AudioSource audioSource;

    private float destroySoundObject = 2;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = destroySound;
        audioSource.Play();
    }
    void Update()
    {
        destroySoundObject -= Time.deltaTime;

        if (destroySoundObject <= 0)
        {
            Destroy(gameObject);
        }
    }
}
