using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLightsController : MonoBehaviour
{
    // Reference to the car's lights
    public Light[] frontLights;
    public Light[] rearLights;

    // Light state
    private bool lightsOn = false;

    void Update()
    {
        // Check for key press
        if (Input.GetKeyDown(KeyCode.G))
        {
            // Toggle lights
            lightsOn = !lightsOn;

            // Update light states
            foreach (var light in frontLights)
            {
                light.enabled = lightsOn;
            }

            foreach (var light in rearLights)
            {
                light.enabled = lightsOn;
            }
        }
    }
}
