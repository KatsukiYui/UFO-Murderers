// Rory Clark - https://rory.games - 2019
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    GameObject m_enemyPrefab = null;

    [SerializeField]
    float m_minSpawnTime = 0.2f, m_maxSpawnTime = 1.5f;

    [SerializeField]
    float m_warmupTime = 1f;
    float m_currentTime = 1f;

    [SerializeField]
    float m_minMaxSpawnWidth = 8f;
    [SerializeField]
    float m_minSpawnWidth = 1f;

    private void Start()
    {
        m_currentTime = m_warmupTime;
        m_minSpawnWidth = -m_minMaxSpawnWidth;

    }

    void Update()
    {
        m_currentTime -= Time.deltaTime;
        if (m_currentTime <= 0)
        {
            m_currentTime = Random.Range(m_minSpawnTime, m_maxSpawnTime);
            SpawnPrefab();
        }
    }

    void SpawnPrefab()
    {
        GameObject go = Instantiate(m_enemyPrefab);
        go.transform.SetParent(transform);
        go.transform.localPosition = new Vector3(0, 0, Random.Range(m_minSpawnWidth, m_minMaxSpawnWidth));
    }
}
