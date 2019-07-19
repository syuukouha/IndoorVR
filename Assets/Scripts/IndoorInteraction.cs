using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndoorInteraction : MonoBehaviour
{
    public GameObject[] Floor;
    public GameObject[] Sofa;
    public GameObject[] Couch1;
    public GameObject[] Couch2;


    public void ChangeFloorMaterial(GameObject gameObject)
    {
        Material newMaterial = gameObject.GetComponent<MeshRenderer>().material;

        for (int i = 0; i < Floor.Length; i++)
        {
            Floor[i].GetComponent<MeshRenderer>().material.CopyPropertiesFromMaterial(newMaterial);
        }
    }
    public void ChangeSofa(string name)
    {
        switch (name)
        {
            case "Sofa":
                for (int i = 0; i < Sofa.Length; i++)
                {
                    Sofa[i].SetActive(true);
                    Couch1[i].SetActive(false);
                    Couch2[i].SetActive(false);
                }
                break;
            case "Couch1":
                for (int i = 0; i < Sofa.Length; i++)
                {
                    Sofa[i].SetActive(false);
                    Couch1[i].SetActive(true);
                    Couch2[i].SetActive(false);
                }
                break;
            case "Couch2":
                for (int i = 0; i < Sofa.Length; i++)
                {
                    Sofa[i].SetActive(false);
                    Couch1[i].SetActive(false);
                    Couch2[i].SetActive(true);
                }
                break;
            default:
                for (int i = 0; i < Sofa.Length; i++)
                {
                    Sofa[i].SetActive(true);
                    Couch1[i].SetActive(false);
                    Couch2[i].SetActive(false);
                }
                break;
        }
    }
}
