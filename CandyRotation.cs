using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyRotation : MonoBehaviour
{
    public Vector3 rotation;

    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + rotation * Time.deltaTime);
    }
}
