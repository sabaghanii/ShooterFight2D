using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float followSpeed;
    public float yOffset;
    public float xOffset;
    public Transform target_gunplayer;
    public Transform target_riflePlayer;

    // Update is called once per frame
    void Update()
    {
        if (target_gunplayer != null)
        {
            Vector3 newPos = new Vector3(target_gunplayer.position.x + xOffset, target_gunplayer.position.y + yOffset, -8f);
            transform.position = Vector3.Slerp(transform.position, newPos, followSpeed * Time.deltaTime);
        }
        if (target_riflePlayer != null) {
            //Debug.Log("following rifle player");
            Vector3 newPos = new Vector3(target_riflePlayer.position.x + xOffset, target_riflePlayer.position.y + yOffset, -8f);
            transform.position = Vector3.Slerp(transform.position, newPos, followSpeed * Time.deltaTime);
        }
        
    }
}
