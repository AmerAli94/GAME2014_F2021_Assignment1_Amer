// ===============================
// PROGRAM NAME: GAME Programming (T163)
// STUDENT ID : 101206769
// AUTHOR     : AMER ALI MOHAMMED
// CREATE DATE     : SEP 27, 2021
// PURPOSE     : GAME2014_F2021_ASSIGNMENT1
// SPECIAL NOTES:
// ===============================
// Change History:
// Added Enemy Spawns and File Headers for the project
//==================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProjectileController : MonoBehaviour
{
    public GameObject BulletPrefab;
    public int bulletAmount = 100;
    public TextMeshProUGUI bulletValueTextholder;
    

    // Update is called once per frame
    void Update()
    {
        bulletValueTextholder.text = bulletAmount.ToString();
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(BulletPrefab, this.transform.position, transform.rotation, transform);
        bulletAmount--;

        Destroy(bullet, 1.5f);
    }
}
