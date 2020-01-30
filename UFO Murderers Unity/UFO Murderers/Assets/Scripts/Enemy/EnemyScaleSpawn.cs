// Rory Clark - https://rory.games - 2019
using UnityEngine;

// Small utility script that will scale the object from 0 to desired over time
// Once the scale is reached it will then remove itself (only the script) from the object to prevent it using any further performance
public class EnemyScaleSpawn : MonoBehaviour
{
    [SerializeField]
    float m_desiredScale = 2f, m_lerpTime = 1f;

    float m_time = 0, m_currentScale = 0f;

    private void Awake()
    {
        transform.localScale = Vector3.zero;
    }

    private void Update()
    {
        m_time += Time.deltaTime;

        if(m_time > m_lerpTime)
        {
            m_time = m_lerpTime;
        }

        m_currentScale = Mathf.Lerp(0, m_desiredScale, m_time/m_lerpTime);

        transform.localScale = new Vector3(m_currentScale, m_currentScale, m_currentScale);

        if(m_time >= m_lerpTime)
        {
            Destroy(this);
        }
    }

}
