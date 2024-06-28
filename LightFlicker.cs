using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public float minLight = 0;
    public float maxLight = 1;
    public float newLightDelay = 0.05f;
    public float transitionSpeed = 0.2f;
    public Light light;

    private float time = 0;
    private float target;

    void Start()
    {
        target = Random.Range(minLight,maxLight);
    }
    void Update()
    {
        time += Time.deltaTime;
        if(time > newLightDelay) {
            target = Random.Range(minLight,maxLight);
            time = 0;
        }
        light.intensity = Mathf.Lerp(light.intensity, target, transitionSpeed * Time.deltaTime * Time.timeScale);
    }
}
