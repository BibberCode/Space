using UnityEngine;

public class HitParticle : MonoBehaviour
{
    private float ParticleDestroy = 2;

    void Update()
    {
        ParticleDestroy -= Time.deltaTime;
        TimerFinished();
    }

    bool TimerFinished()
    {
        if (ParticleDestroy <= 0)
        {
            ParticleDestroy = 2;
            Destroy(gameObject);

            return true;
        }
        else
        {
            return false;
        }
    }
}
