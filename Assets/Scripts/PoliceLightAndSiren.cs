using UnityEngine;

public class PoliceLightAndSiren : MonoBehaviour
{
    // Light references
    public Light redLight; // Assign red light in the Inspector
    public Light blueLight; // Assign blue light in the Inspector

    // Audio source reference
    public AudioSource siren;

    // Flashing effect variables
    private bool isBlueLightOn = true;
    private bool sirenActive = false;

    void Start()
    {
        // Start the flashing effect
        InvokeRepeating(nameof(FlashLights), 0f, 0.5f); // Adjust frequency for desired flash speed
    }

    void Update()
    {
        // Toggle siren and intensify lights when Space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sirenActive = !sirenActive;

            // Activate/deactivate siren sound
            if (sirenActive)
            {
                siren.Play();
                redLight.intensity = 5; // Intensify lights
                blueLight.intensity = 5;
            }
            else
            {
                siren.Stop();
                redLight.intensity = 2; // Reset to base intensity
                blueLight.intensity = 2;
            }
        }
    }

    void FlashLights()
    {
        // Alternate lights
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

        // Toggle the state
        isBlueLightOn = !isBlueLightOn;
    }
}
