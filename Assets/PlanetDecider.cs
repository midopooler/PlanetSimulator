using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetDecider : MonoBehaviour
{
    float distanceFromStar, gravity, waterCover, atmosphereLevel;
    public Slider distance, grav, water, atmos;
    public Material lava, venusian, waterEarth, icy, mars, savannah, icy2, moon;
    
    Material target;
    public GameObject targetBody;

    private void Update()
    {

        distanceFromStar = distance.value;
        gravity = grav.value;
        waterCover = water.value;
        atmosphereLevel = atmos.value;


        if (distanceFromStar == 0)
        {
            if (waterCover == 0)
            {
                targetBody.GetComponent<MeshRenderer>().material = venusian;
            }
            else if (waterCover == 1 || waterCover == 2)
            {
                targetBody.GetComponent<MeshRenderer>().material = lava;
            }
        }
        else if (distanceFromStar == 1)
        {
            if (waterCover == 0)
            {
                targetBody.GetComponent<MeshRenderer>().material = mars;
            }
            else if (waterCover == 1)
            {
                targetBody.GetComponent<MeshRenderer>().material = savannah;
            }
            else if (waterCover == 2)
            {
                targetBody.GetComponent<MeshRenderer>().material = waterEarth;
            }
        }
        else if (distanceFromStar == 2)
        {
            if (waterCover == 0)
            {
                targetBody.GetComponent<MeshRenderer>().material = moon;
            }
            else if (waterCover == 1)
            {
                targetBody.GetComponent<MeshRenderer>().material = icy;
            }
            else if (waterCover == 2)
            {
                targetBody.GetComponent<MeshRenderer>().material = icy2;
            }
        }
    }

}
