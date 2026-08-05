using UnityEngine;

public class Asteroid2 : MonoBehaviour
{
    public float speed;

    public ParticleSystem destroyParticle;
    public GameObject asteroid2;

    public GameObject destroySoundObject;

    public GameObject UILaser;

    void Update()
    {
        transform.Rotate(new Vector3(180, 180, 0) * Time.deltaTime);
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Laser")
        {
            Instantiate(destroyParticle, asteroid2.transform.position, destroyParticle.transform.rotation);

            Destroy(gameObject);
            Destroy(other.gameObject);

            UITimer2.timer += 0.2f;
            ScoreSpeicher.score2 += 1;

            Instantiate(destroySoundObject, asteroid2.transform.position, destroySoundObject.transform.rotation);
        }

        if (other.gameObject.tag == "AsteroidDestroyer")
        {
            Destroy(gameObject);
        }
    }
}
