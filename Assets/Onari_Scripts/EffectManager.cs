using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    [SerializeField] GameObject effect;   // エフェクト
    [SerializeField] GameObject enemy;    // エネミー

    [Range(0, 50), SerializeField]
    int pursuit = 0;

    Vector3 size;
    Vector3 offset;

    void Start()
    {
        size = enemy.transform.localScale;
        offset = enemy.transform.localPosition;

        StartCoroutine("EffectCount");
    }

    void Update()
    {
    }

    IEnumerator EffectCount()
    {
        for (int count = 0; count < pursuit; count++)
        {
            // 円を設定 
            Vector2 position = Random.insideUnitCircle;
            position.x = position.x * size.x + offset.x;
            position.y = position.y * size.y + offset.y;

            // 0.1秒間隔で出現
            yield return new WaitForSeconds(0.1f);

            // 円範囲内でランダムに生成する
            Instantiate(effect, position, Quaternion.identity);
        }
    }

 
}