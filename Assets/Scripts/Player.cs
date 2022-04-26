using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region//パブリック変数
    [Header("速度")] public float speed; //速度
    [Header("回転速度")] public float smooth; //回転速度
    #endregion

    #region//プライベート変数 

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target_dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //Run
        if (target_dir.magnitude > 0.1)
        {
            //体の向きを変更
            Quaternion rotation = Quaternion.LookRotation(target_dir);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * smooth);
            //前方へ移動
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }
    }
}
