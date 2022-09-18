using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaganLight : MonoBehaviour
{
    public Light lt;
    public GameObject cube;
    int mode;

    void Start()
    {
        lt = GetComponent<Light>();
        mode = 0;
        InvokeRepeating("checkOrientation", 0f, 1f);
    }

    void checkOrientation()
    {
        Debug.Log(cube.transform.localRotation.eulerAngles.x + ", " + cube.transform.localRotation.eulerAngles.y + ", " + cube.transform.localRotation.eulerAngles.z);
        
        if ((cube.transform.localRotation.eulerAngles.z >= 170) && (cube.transform.localRotation.eulerAngles.z <= 190))
        {
            while ((cube.transform.localRotation.eulerAngles.z < 350) && (cube.transform.localRotation.eulerAngles.z > 10))
            {
                // Reapeat, do nothing
            }
            changeLight();
            // if ((cube.transform.localRotation.eulerAngles.z >= 350) || (cube.transform.localRotation.eulerAngles.z <= 10))
            // {
            //     changeLight();
            // }
        }
    }

    void changeLight()
    {
        if (mode == 0)
        {
            mode = 1;
            lt.color = Color.white;
        } else {
            mode = 0;
            lt.color = Color.red;
        }
    }
}
