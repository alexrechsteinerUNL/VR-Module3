using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WristMenu : MonoBehaviour
{
    [SerializeField] 
    private Transform playerHead;
    
    [SerializeField] 
    private float enableThreshold;

    [SerializeField]
    private float disableThreshold;
    
    [SerializeField]
    private GameObject mainMenu;
    [SerializeField]
    private GameObject locomotionMenu;
    [SerializeField]
    private GameObject controlsButton;

    private bool menuEnabled;

    private void Update()
    {
        CheckMenuOrientationAndDisplay();
    }

    private void CheckMenuOrientationAndDisplay()
    {
        Vector3 directionToHead = Vector3.Normalize(playerHead.position - transform.position);
        Debug.DrawRay(transform.position, transform.forward);
        float dotProduct = Vector3.Dot(-transform.forward, directionToHead);
        if (dotProduct > enableThreshold && !menuEnabled)
        {
            ShowMainMenu();
        }
        else if (dotProduct < disableThreshold)
        {
            HideAllMenus();
        }
    }

    public void ShowControls()
    {
        controlsButton.SetActive(true);
        mainMenu.SetActive(false);
        locomotionMenu.SetActive(false);
    }

    public void ShowLocomotionMenu()
    {
        locomotionMenu.SetActive(true);
        mainMenu.SetActive(false);
        controlsButton.SetActive(false);
    }

    public void ShowMainMenu()
    {
        controlsButton.SetActive(false);
        locomotionMenu.SetActive(false);
        mainMenu.SetActive(true);
        menuEnabled = true;
    }

    private void HideAllMenus()
    {
        controlsButton.SetActive(false);
        locomotionMenu.SetActive(false);
        mainMenu.SetActive(false);
        menuEnabled = false;
    }
}
