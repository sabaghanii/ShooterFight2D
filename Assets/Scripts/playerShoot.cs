using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerShoot : MonoBehaviour
{
    public gameManager gm;
    [SerializeField]
    private GameObject gunBulletPF;
    [SerializeField]
    private Transform gun_firePoint;
    public Transform gun_player;

    private float speed = 250f;
    private float lifeTime = 1.5f;

    //Rifle variables
    private float rifleSpeed = 650;
    [SerializeField]
    private GameObject rifleBulletPF;
    [SerializeField]
    private Transform rifle_firepoint;
    public Transform rifle_player;


    public void findPlayer()
    {
        if (gm.weaponIndex == 1)
        {
            shootGunBullet();
        }
        else if (gm.weaponIndex == 2)
        {
            shootRifleBullet();
        }
    }

    private void shootGunBullet()
    {
        Debug.Log("Shooting gun bullet");
        GameObject gunBulletInstance = Instantiate(gunBulletPF, gun_firePoint.position, gun_firePoint.rotation);
        Rigidbody2D rb = gunBulletInstance.GetComponent<Rigidbody2D>();
        rb.velocity = -gunBulletInstance.transform.right * speed * Time.deltaTime;
        Destroy(gunBulletInstance, lifeTime);
     }
    private void shootRifleBullet()
    {
        Debug.Log("shooting rifle bullet");
        GameObject rifleBulletInstance = Instantiate(rifleBulletPF, rifle_firepoint.position, rifle_firepoint.rotation);
        Rigidbody2D rb = rifleBulletInstance.GetComponent<Rigidbody2D>();
        rb.velocity = -rifleBulletInstance.transform.right * rifleSpeed * Time.deltaTime;
        Destroy (rifleBulletInstance, lifeTime);
    }
}
