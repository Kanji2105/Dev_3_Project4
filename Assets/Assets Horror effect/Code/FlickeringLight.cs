using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    public Light targetLight;

    public float minIntensity = 0.2f;
    public float maxIntensity = 1.2f;

    public float minDelay = 0.05f;
    public float maxDelay = 0.2f;

    private float timer;

    void Start()
    {
        if (targetLight == null)
            targetLight = GetComponent<Light>();

        SetNewTimer();
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            targetLight.intensity = Random.Range(minIntensity, maxIntensity);
            SetNewTimer();
        }
    }

    void SetNewTimer()
    {
        timer = Random.Range(minDelay, maxDelay);
    }
}