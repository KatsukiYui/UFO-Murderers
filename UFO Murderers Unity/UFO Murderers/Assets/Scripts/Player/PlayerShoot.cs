using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    [SerializeField]
    GameObject bulletPrefab = null;

    [SerializeField]
    Transform spawnPosition = null;


    [SerializeField]
    float fireRate = 0.25f;
    float currentFireTimer = 0f;

    void Update()
    {
        if (currentFireTimer > 0)
        {
            currentFireTimer -= Time.deltaTime;
        }

        if ((Input.touchCount > 0) && currentFireTimer <= 0 && PlayerHealth.health >= 0)
        {
            currentFireTimer = fireRate;
            SpawnBullet();
        }
    }

    void SpawnBullet()
    {
        GameObject go = Instantiate(bulletPrefab);
        go.transform.position = spawnPosition.position;
    }
   
}
