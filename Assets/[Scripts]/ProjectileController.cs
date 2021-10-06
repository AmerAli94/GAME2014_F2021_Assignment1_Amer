// ===============================
// PROGRAM NAME: GAME Programming (T163)
// STUDENT ID : 101206769
// AUTHOR     : AMER ALI MOHAMMED
// CREATE DATE     : SEP 27, 2021
// PURPOSE     : GAME2014_F2021_ASSIGNMENT1
// SPECIAL NOTES:
// ===============================
// Change History:
// Instantiating bullets and update bullet count UI.
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

    private void Start()
    {
        bulletAmount = 100;
    }
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
