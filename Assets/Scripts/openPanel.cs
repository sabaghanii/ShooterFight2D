using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class openPanel : MonoBehaviour
{
    public GameObject panelCanvas;

    public void displayPanel()
    {
        panelCanvas.SetActive(true);
    }
}
