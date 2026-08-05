using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static float timer = 2;
    public static float playTime = 0;
    public GameObject asteroidPreFab;

    bool TimerFinished()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = 2 - playTime;

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
            Vector3 spawnPosition = new Vector3(Random.Range(-24, 24), 11, 0);
            Instantiate(asteroidPreFab, spawnPosition, asteroidPreFab.transform.rotation);
        }
    }
}
