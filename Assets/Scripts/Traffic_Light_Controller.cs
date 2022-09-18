using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traffic_Light_Controller : MonoBehaviour
{
    public float timeTakenBetweenTrafficLight;

    public float timefortrafficlight = 0;
    public int currenttrafficlight = 0;
    public int previoustrafficlight = 0;

    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
        }

    }

   
    void Update()
    {
        trafficlight();
    }

    void trafficlight()
    {
        if (Time.time >= timefortrafficlight)
        {
            timefortrafficlight += timeTakenBetweenTrafficLight;
            this.gameObject.transform.GetChild(currenttrafficlight).gameObject.SetActive(false);
            if (previoustrafficlight != currenttrafficlight)
            {
                this.gameObject.transform.GetChild(previoustrafficlight).gameObject.SetActive(true);
            }
            previoustrafficlight = currenttrafficlight;
            if (currenttrafficlight >= transform.childCount - 1)
            {
                currenttrafficlight = 0;
            }
            else
            {
                currenttrafficlight += 1;
            }
        }
    }
}