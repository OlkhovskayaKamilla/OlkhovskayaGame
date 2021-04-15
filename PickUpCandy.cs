using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface PickUp
{
    void PickUp();
}

public class PickUpCandy : MonoBehaviour, PickUp
{
    public void PickUp()
    {
        Destroy(gameObject);
    }

}
