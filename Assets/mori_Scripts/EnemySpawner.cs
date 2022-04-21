﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // 生成するプレハブ格納用
    public GameObject EnemyPrefab;
    //敵の数カウント用
    int count;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        count = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (count == 50) return;
        // 30フレーム毎にシーンにプレハブを生成
        if (Time.frameCount % 120 == 0)
        {
            // プレハブの位置をランダムで設定
            float x = Random.Range(-5.0f, 5.0f);
            float z = Random.Range(-5.0f, 5.0f);
            Vector3 pos = new Vector3(x, 0.0f, z);

            // プレハブを生成
            Instantiate(EnemyPrefab, pos, Quaternion.identity);
        }
    }
}