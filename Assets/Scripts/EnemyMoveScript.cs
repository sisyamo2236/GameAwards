using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoveScript : MonoBehaviour
{
    [SerializeField]
    [Tooltip("追いかける対象")]
    private GameObject player;

    [SerializeField]
    [Tooltip("スピード")]
    private float spd;
    void Start()
    {

    }

    void Update()
    {
        Transform playerTransform = player.transform;

        transform.LookAt(playerTransform);
        transform.position += transform.forward * spd * Time.deltaTime;
    }
}
