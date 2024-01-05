using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
 public GameObject Auto;
public float AutoX;
public float AutoY;
public float AutoZ;
void Update()
{
    AutoX = Auto.transform.eulerAngles.x;
    AutoY = Auto.transform.eulerAngles.y;
    AutoZ = Auto.transform.eulerAngles.z;

    transform.eulerAngles = new Vector3(AutoX - AutoX, AutoY, AutoZ - AutoZ);
}
}
