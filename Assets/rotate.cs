using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    private void Update()
    {
        this.transform.Rotate(0f, 0f, 0.5f);
    }
}
