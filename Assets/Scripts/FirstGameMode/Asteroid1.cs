using System.Threading;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed;
    private GameObject spaceShip;

    public ParticleSystem destroyParticle;
    public GameObject asteroid1;

    public GameObject destroySoundObject;

    public GameObject UILaser;

    void Start()
    {
        GameObject target = GameObject.Find("SpaceShip1");
        spaceShip = target;
    }

    void Update()
    {
        transform.Rotate(new Vector3(180, 180, 0) * Time.deltaTime);
        transform.Translate(Vector3.down * speed *Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Laser")
        {
            Instantiate(destroyParticle, asteroid1.transform.position, destroyParticle.transform.rotation);

            Destroy(gameObject);
            Destroy(other.gameObject);

            GameManager.instance.score += 1;    //Score +1 in GameScene
            ScoreSpeicher.score1 += 1;   //Score +1 in RestartScene

            Instantiate(destroySoundObject, asteroid1.transform.position, destroySoundObject.transform.rotation);

            EnemySpawner.playTime += 0.01f;
        }

        if (other.gameObject.tag == "AsteroidDestroyer")
        {
            Destroy(gameObject);
            Destroy(spaceShip);
        }
    }
}
