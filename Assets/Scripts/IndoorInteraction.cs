using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndoorInteraction : MonoBehaviour
{
    public GameObject[] Floors;

    public void ChangeFloorMaterial(GameObject gameObject)
    {
        Material newMaterial = gameObject.GetComponent<MeshRenderer>().material;

        for (int i = 0; i < Floors.Length; i++)
        {
            Floors[i].GetComponent<MeshRenderer>().material.CopyPropertiesFromMaterial(newMaterial);
        }
    }
}
