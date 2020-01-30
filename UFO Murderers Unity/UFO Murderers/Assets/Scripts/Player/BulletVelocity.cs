// Rory Clark - https://rory.games - 2019
using UnityEngine;

public class BulletVelocity : MonoBehaviour
{
    Rigidbody m_rigidbody;

    [SerializeField]
    float m_maxVelocity = 100f;

    [SerializeField]
    float m_destroyDistance = 150f;

    private void Awake()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (m_rigidbody.velocity.magnitude > m_maxVelocity)
        {
            m_rigidbody.velocity = Vector3.ClampMagnitude(m_rigidbody.velocity, m_maxVelocity);
        }
        // Destroy the object if it's gone to far
        // Much easier than checking if it's directly off the screen, however has to be manually defined and will not work effectively on different aspect ratios
        if (transform.position.x >= Mathf.Abs(m_destroyDistance))
        {
            Destroy(gameObject);
        }
        

    }

}
