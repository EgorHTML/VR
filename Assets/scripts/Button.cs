using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject objectToActivate;
    private bool isActive = true;
    void Start()
    {
        objectToActivate = GameObject.FindWithTag("cube");
    }
    public void ToggleObjectActivation()
    {
        isActive = !isActive;
        objectToActivate.SetActive(isActive);
    }
}
