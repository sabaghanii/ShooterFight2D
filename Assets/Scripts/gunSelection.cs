using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunSelection : MonoBehaviour
{
    public GameObject panelCanvas;
    public gameManager gm;
    [SerializeField] GameObject gun_player;
    [SerializeField] GameObject rifle_player;
    
    public void select_gun()
    {
        gm.weaponIndex = 1;
        panelCanvas.SetActive(false);
        gun_player.SetActive(true);
        rifle_player.SetActive(false);
    }
}
