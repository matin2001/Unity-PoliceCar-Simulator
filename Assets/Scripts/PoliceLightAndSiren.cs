using UnityEngine;

public class PoliceLightAndSiren : MonoBehaviour
{
    // Light references
    public Light redLight; 
    public Light blueLight; 
    public AudioSource siren;
    private bool isBlueLightOn = true;
    private bool sirenActive = false;

    void Start()
    {
        InvokeRepeating(nameof(FlashLights), 0f, 0.5f); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sirenActive = !sirenActive;
            if (sirenActive)
            {
                siren.Play();
                redLight.intensity = 5;
                blueLight.intensity = 5;
            }
            else
            {
                siren.Stop();
                redLight.intensity = 2;
                blueLight.intensity = 2;
            }
        }
    }

    void FlashLights()
    {
        if (isBlueLightOn)
        {
            blueLight.enabled = true;
            redLight.enabled = false;
        }
        else
        {
            blueLight.enabled = false;
            redLight.enabled = true;
        }
        isBlueLightOn = !isBlueLightOn;
    }
}
