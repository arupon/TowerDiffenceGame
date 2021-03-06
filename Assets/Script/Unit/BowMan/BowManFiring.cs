﻿using UnityEngine;

/// <summary>
/// 矢の弾道計算
/// </summary>
public class BowManFiring : MonoBehaviour
{
    /// <summary>
    /// 射出するオブジェクト
    /// </summary>
    [SerializeField, Tooltip("射出するオブジェクトを設定する")]
    private GameObject arrow;

    /// <summary>
    /// 標的のオブジェクト
    /// </summary>
    [SerializeField, Tooltip("標的のオブジェクトを設定する")]
    private GameObject targetObject;

    /// <summary>
    /// 射出するオブジェクトの角度
    /// </summary>
    [SerializeField, Range(0F, 90F), Tooltip("射出するオブジェクトの角度を設定する")]
    private float throwAngle;

    /// <summary>
    /// 射出するまでの時間(初期値)
    /// </summary>
    [SerializeField, Tooltip("射出するまでの時間を設定する")]
    private float attackInterval;

    /// <summary>
    /// 弾速
    /// </summary>
    [SerializeField]
    private float speed;
    
    /// <summary>
    /// 射出するまでの時間
    /// </summary>
    private float interval;

    /// <summary>
    /// 初期化処理
    /// </summary>
    public void Start()
    {
        Debug.Log("CannonFiring Start Method Start");

        interval = attackInterval;

        Debug.Log("CannonFiring Start Method End");
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    public void Update()
    {
        Debug.Log("CannonFiring Update Method Start");

        // 射出するまでの時間を減少
        interval = interval - Time.deltaTime;

        // 射出時間になれば
        if(interval <= 0)
        {
            // 射出
            Firing();

            // 射出時間をリセット
            interval = attackInterval;
        }

        // 標的がいれば
        if(targetObject != null)
        {
            // 標的に方向を向ける
            // transform.LookAt(targetObject.transform);
        }

        Debug.Log("CannonFiring Update Method End");
    }

    /// <summary>
    /// 弾発射
    /// </summary>
    private void Firing()
    {
        Debug.Log("CannonFiring Firing Method Start");

        // cannonBallとtargetObjectが設定されていれば
        if (arrow != null && targetObject != null)
        {
            // cannonBallを作成
            GameObject ball = Instantiate(arrow, transform.position + new Vector3(0, 2, 0), Quaternion.identity);

            // 標的のオブジェクトの座標を取得
            Vector3 targetPosition = targetObject.transform.position;

            // 射出角度を取得
            float angle = throwAngle;

            // CalculateVelocityメソッドから弾の移動量を取得
            Vector3 velocity = CalculateVelocity(transform.position, targetPosition, angle);

            // 弾のRigidbodyを取得
            Rigidbody rigidbody = ball.GetComponent<Rigidbody>();

            // 弾に移動量を付与
            rigidbody.AddForce(velocity * rigidbody.mass, ForceMode.Impulse);
        }

        Debug.Log("CannonFiring Firing Method End");
    }

    /// <summary>
    /// 弾道計算
    /// </summary>
    /// <param name="pointA">弓兵のオブジェクトの座標</param>
    /// <param name="pointB">標的のオブジェクトの座標</param>
    /// <param name="angle">弾の角度</param>
    /// <returns></returns>
    private Vector3 CalculateVelocity(Vector3 pointA, Vector3 pointB, float angle)
    {
        Debug.Log("CannonFiring CalculateVelocity Method Start");

        // 矢の角度をラジアン値に変換
        float radian = angle * Mathf.PI / 180;

        // 弓兵から標的の距離を取得
        float x = Vector2.Distance(new Vector2(pointA.x, pointA.z), new Vector2(pointB.x, pointB.z));
        float y = pointA.y - pointB.y;
       
        // 弾の速度が0だったら
        if(float.IsNaN(speed))
        {
            // うんち
            return Vector3.zero;
        }

        Debug.Log("CannonFiring CalculateVelocity Method End");

        // 弾の方向、速度を返す
        return new Vector3(pointB.x - pointA.x, x * Mathf.Tan(radian), pointB.z - pointA.z).normalized * speed;
    }

    /// <summary>
    /// 範囲内に入った時の処理
    /// </summary>
    /// <param name="other">相手のオブジェクト</param>
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("CannonFiring OnTriggerEnter Method Start");

        // 範囲内に入ったオブジェクトのタグがCharacterであれば
        if (other.gameObject.tag == "Character")
        {
            // 標的のオブジェクトを設定
            targetObject = other.gameObject;
        }

        Debug.Log("CannonFiring OnTriggerEnter Method End");
    }

    /// <summary>
    /// 範囲から出た時の処理
    /// </summary>
    /// <param name="other">相手のオブジェクト</param>
    public void OnTriggerExit(Collider other)
    {
        Debug.Log("CannonFiring OnTriggerExit Method Start");

        // 範囲外に出たオブジェクトのタグがCharacterであれば
        if (other.gameObject.tag == "Character")
        {
            // 標的のオブジェクトを設定
            targetObject = null;
        }

        Debug.Log("CannonFiring OnTriggerExit Method End");
    }
}
