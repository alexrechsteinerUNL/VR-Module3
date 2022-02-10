using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blaster : MonoBehaviour
{
    private ProjectilePool m_ProjectilePool = null;

    public GameObject m_ProjectilePrefab = null;

    private void Awake()
    {
        m_ProjectilePool = new ProjectilePool(m_ProjectilePrefab, 10);
    }
}
