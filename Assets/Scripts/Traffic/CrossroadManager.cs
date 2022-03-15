using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossroadManager : MonoBehaviour
{
    public GameObject crossroad_x1;
    public GameObject crossroad_x2;
    public GameObject crossroad_z1;
    public GameObject crossroad_z2;
    public bool xRoadAllow = true;
    public bool zRoadAllow = false;
    public bool xRoadLastAllowed;
    public float timer = 10;

    void Update()
    {
        //MaJ du chrono
        timer -= Time.deltaTime;

        //Prépration de l'autorisation d'un des deux axes si le timer atteint 0, en fonction du dernier axe autorisé 
        if(timer < 0 && xRoadAllow)
        {
            xRoadAllow = false;
            xRoadLastAllowed = true;
        }
        if (timer < 0 && zRoadAllow)
        {
            zRoadAllow = false;
            xRoadLastAllowed = false;
        }

        //Blocage des deux axes pour transition
        if(timer < 0)
        {
            crossroad_z1.SetActive(true);
            crossroad_z2.SetActive(true);
            crossroad_x1.SetActive(true);
            crossroad_x2.SetActive(true);
        }

        //Autorisation d'un axe si ce dernier était bloqué au dernier cycle
        if (timer < -3)
        {
            if (xRoadLastAllowed)
            {
                zRoadAllow = true;
                crossroad_z1.SetActive(false);
                crossroad_z2.SetActive(false);
                crossroad_x1.SetActive(true);
                crossroad_x2.SetActive(true);
            }
            else
            {
                xRoadAllow = true;
                crossroad_z1.SetActive(true);
                crossroad_z2.SetActive(true);
                crossroad_x1.SetActive(false);
                crossroad_x2.SetActive(false);
            }
            timer = 10;
        }
    }
}
