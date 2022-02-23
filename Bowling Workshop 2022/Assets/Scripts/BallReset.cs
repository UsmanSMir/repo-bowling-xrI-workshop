using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    public GameObject m_ball;
    public GameObject m_currentBall;
    public Transform m_ballSpawn;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(m_currentBall);
        m_currentBall = Instantiate(m_ball, m_ballSpawn.position, Quaternion.identity);
    }
}
