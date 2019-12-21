using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFiring : MonoBehaviour
{
    /// <summary>
    /// 射出するオブジェクト
    /// </summary>
    [SerializeField, Tooltip("射出するオブジェクトを設定する")]
    private GameObject cannonBall;

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
    /// 射出するまでの時間
    /// </summary>
    [SerializeField, Tooltip("射出するまでの時間を設定する")]
    private float attackInterval;


    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log("CannonFiring StartFunctio Start");

        // 当たり判定を取得
        Collider collider = GetComponent<Collider>();

        // 当たり判定が存在したら
        if (collider != null)
        {
            // トリガーをOnにする
            collider.isTrigger = true;
        }

        Debug.Log("CannonFiring StartFunctio End");
    }

    // Update is called once per frame
    public void Update()
    {
        Debug.Log("CannonFiring StartFunctio Start");

        // 射出するまでの時間を減少
        attackInterval = attackInterval - Time.deltaTime;

        // 射出時間になれば
        if(attackInterval <= 0)
        {
            // 射出
            Firing();
            attackInterval = 3.0f;
        }

        Debug.Log("CannonFiring StartFunctio End");
    }

    /// <summary>
    /// 弾発射
    /// </summary>
    private void Firing()
    {
        // cannonBallとtargetObjectが設定されていれば
        if (cannonBall != null && targetObject != null)
        {
            // cannonBallを作成
            GameObject ball = Instantiate(cannonBall, this.transform.position, Quaternion.identity);

            // 標的のオブジェクトの座標を取得
            Vector3 targetPosition = targetObject.transform.position;

            // 射出角度を取得
            float angle = throwAngle;

            // CalculateVelocityメソッドから弾の移動量を取得
            Vector3 velocity = CalculateVelocity(this.transform.position, targetPosition, angle);

            // 弾のRigidbodyを取得
            Rigidbody rigidbody = ball.GetComponent<Rigidbody>();

            // 弾に移動量を付与
            rigidbody.AddForce(velocity * rigidbody.mass, ForceMode.Impulse);
        }
    }

    /// <summary>
    /// 弾道計算
    /// </summary>
    /// <param name="pointA">大砲のオブジェクトの座標</param>
    /// <param name="pointB">標的のオブジェクトの座標</param>
    /// <param name="angle">弾の角度</param>
    /// <returns></returns>
    private Vector3 CalculateVelocity(Vector3 pointA, Vector3 pointB, float angle)
    {
        // 球の角度をラジアン値に変換
        float radian = angle * Mathf.PI / 180;

        // 大砲から標的の距離を取得
        float x = Vector2.Distance(new Vector2(pointA.x, pointA.z), new Vector2(pointB.x, pointB.z));
        float y = pointA.y - pointB.y;

        // 弾の速度を計算
        float speed = Mathf.Sqrt(-Physics.gravity.y * Mathf.Pow(x, 2) / (2 * Mathf.Pow(Mathf.Cos(radian), 2) * (x * Mathf.Tan(radian) + y)));
        
        // 弾の速度が0だったら
        if(float.IsNaN(speed))
        {
            Debug.Log("うんち");
            //うんち
            return Vector3.zero;
        }

        // 弾の方向、速度を返す
        return new Vector3(pointB.x - pointA.x, x * Mathf.Tan(radian), pointB.z - pointA.z).normalized * speed;
    }

    /// <summary>
    /// 範囲内に入った時の処理
    /// </summary>
    /// <param name="other">相手のオブジェクト</param>
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Character")
        {
            targetObject = other.gameObject;
        }
    }

    /// <summary>
    /// 範囲から出た時の処理
    /// </summary>
    /// <param name="other">相手のオブジェクト</param>
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Character")
        {
            targetObject = null;
        }
    }
}
