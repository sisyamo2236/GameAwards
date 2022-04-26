using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // 生成するプレハブ格納用
    [SerializeField]
    [Tooltip("追いかける対象")]
    private GameObject enemy;

    [SerializeField, Range(0f, 90f)]
    [Tooltip("Xスポーン範囲")]
    private float rangeX;

    [SerializeField, Range(0f, 90f)]
    [Tooltip("Zスポーン範囲")]
    private float rangeZ;

    [SerializeField, Range(0, 1000)]
    [Tooltip("スポーン制限数")]
    private int SpawnCount = 50;

    [SerializeField, Range(0, 600)]
    [Tooltip("スポーン頻度")]
    private int SpawnSpeed = 240;

    // Start is called before the first frame update
    void Start()
    {
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1f, 0, 0, 0.3f);
        Vector3 pos = new Vector3(0.0f, 0.0f, 0.0f);
        Vector3 size = new Vector3(1.0f + rangeX*2.0f, 1.0f, 1.0f + +rangeZ * 2.0f);
        Gizmos.DrawCube(pos, size);
    }

    // Update is called once per frame
    void Update()
    {
        int count;
        count = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (count == SpawnCount) return;
        // 30フレーム毎にシーンにプレハブを生成
        if (Time.frameCount % SpawnSpeed == 0)
        {
            // プレハブの位置をランダムで設定
            float posx = Random.Range(-rangeX, rangeX);
            float posz = Random.Range(-rangeZ, rangeZ);
            Vector3 pos = new Vector3(posx, 0.0f, posz);

            // プレハブを生成
            Instantiate(enemy, pos, Quaternion.identity);
        }
    }
}