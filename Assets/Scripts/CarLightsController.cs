using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLightsController : MonoBehaviour
{
    public Light[] frontLights;
    public Light[] rearLights;

    private bool lightsOn = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            lightsOn = !lightsOn;
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
