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
