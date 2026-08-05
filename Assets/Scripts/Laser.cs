using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed;
    private float timer = 1;

    void Update()
    {
       transform.Translate(Vector3.up  * speed * Time.deltaTime); 
       TimerFinished();
    }

    bool TimerFinished()
    {
        timer -= Time.deltaTime;
        
        if (timer <= 0)
        {
            timer = 1;

            Destroy(gameObject);

            return true;
        }
        else
        {
            return false;
        }
    }
}
