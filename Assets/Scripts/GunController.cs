using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] private Transform bulletInitialPoint;
    [SerializeField] private GameObject bulletHitPrefab;
    [SerializeField] private AudioSource shootSound;
    [SerializeField] private LineRenderer laser;


    private bool is10Hit;
    private bool is9Hit;
    private bool is8Hit;
    private bool is7Hit;
    private bool is6Hit;
    private bool is5Hit;

    private void Start()
    {
        laser = GetComponentInChildren<LineRenderer>();
        laser.enabled = false;
    }

    public void Shoot()
    {
        RaycastHit[] hits;
        hits = Physics.RaycastAll(bulletInitialPoint.transform.position, bulletInitialPoint.transform.TransformDirection(Vector3.forward), Mathf.Infinity);

        foreach (RaycastHit hit in hits)
        {
            if (hit.collider.transform.parent.GetComponent<TargetManager>() != null )
            {
                GameObject bulletHit = Instantiate(bulletHitPrefab, hit.point, Quaternion.identity);
                bulletHit.transform.SetParent(hit.collider.transform.parent);

                if (hit.collider.transform.parent.GetComponent<TargetManager>().colliderP10 == hit.collider)
                {
                    is10Hit = true;
                }
                if (hit.collider.transform.parent.GetComponent<TargetManager>().colliderP9 == hit.collider)
                {
                    is9Hit = true;
                }
                if (hit.collider.transform.parent.GetComponent<TargetManager>().colliderP8 == hit.collider)
                {
                    is8Hit = true;
                }
                if (hit.collider.transform.parent.GetComponent<TargetManager>().colliderP7 == hit.collider)
                {
                    is7Hit = true;
                }
                if (hit.collider.transform.parent.GetComponent<TargetManager>().colliderP6 == hit.collider)
                {
                    is6Hit = true;
                }
                if (hit.collider.transform.parent.GetComponent<TargetManager>().colliderP5 == hit.collider)
                {
                    is5Hit = true;
                }
            }
        }

        if (is10Hit == true)
            WatchController.instance.UpdateScore(10);
        else if (is9Hit == true)
            WatchController.instance.UpdateScore(9);
        else if (is8Hit == true)
            WatchController.instance.UpdateScore(8);
        else if (is7Hit == true)
            WatchController.instance.UpdateScore(7);
        else if (is6Hit == true)
            WatchController.instance.UpdateScore(6);
        else if (is5Hit == true)
            WatchController.instance.UpdateScore(5);


        is10Hit = false;
        is9Hit = false;
        is8Hit = false;
        is7Hit = false;
        is6Hit = false;
        is5Hit = false;

        shootSound.Play();
    }

    private void FixedUpdate()
    {
        if (laser.enabled == true)
        {
            RaycastHit hit;

            Physics.Raycast(bulletInitialPoint.transform.position, bulletInitialPoint.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity);


            if (hit.collider != null)
            {
                laser.SetPosition(1, hit.point);
            } 
        }
    }

    public void LaserDisplay()
    { 
        laser.enabled = !laser.enabled;
    }
}
