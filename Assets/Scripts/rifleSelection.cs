using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rifleSelection : MonoBehaviour
{
    public GameObject panelCanvas;
    public gameManager gm;
    [SerializeField] GameObject gun_player;
    [SerializeField] GameObject rifle_player;

    public void select_rifle()
    {
        gm.weaponIndex = 2;
        panelCanvas.SetActive(false);
        gun_player.SetActive(false);
        rifle_player.SetActive(true);
    }
}
