using UnityEngine;

public class EnemyspawnerStart : MonoBehaviour
{
    private float timer = 0.3f;
    public GameObject asteroidPreFab;

    bool TimerFinished()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = 0.3f;

            return true;
        }
        else
        {
            return false;
        }
    }

    void Update()
    {
        if (TimerFinished())
        {
            //Spawn Asteroid
            Vector3 spawnPosition = new Vector3(Random.Range(-50, 50), 11, 0); //zufällige Position wählen
            Instantiate(asteroidPreFab, spawnPosition, asteroidPreFab.transform.rotation); //Spawnen
        }
    }
}
