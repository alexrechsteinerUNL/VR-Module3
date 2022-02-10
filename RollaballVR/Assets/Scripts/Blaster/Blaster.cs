using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;

public class Blaster : MonoBehaviour
{
    public SteamVR_Action_Boolean m_FireAction = null;
    public int m_Force = 10;
    public Transform m_Barrel = null;
    private ProjectilePool m_ProjectilePool = null;
    private SteamVR_Behaviour_Pose m_pose = null;
    public GameObject m_ProjectilePrefab = null;

    private void Awake()
    {
        m_pose = GetComponentInParent<SteamVR_Behaviour_Pose>();
        m_ProjectilePool = new ProjectilePool(m_ProjectilePrefab, 10);
    }

    private void Update()
    {
        if(m_FireAction.GetStateDown(m_pose.inputSource))
            Fire();
    }

    private void Fire()
    {
        Projectile targetProjectile = m_ProjectilePool.m_Projectiles[0];
        targetProjectile.Launch(this);
    }
}
