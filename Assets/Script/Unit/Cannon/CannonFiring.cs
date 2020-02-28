using UnityEngine;

<<<<<<< HEAD
/// <summary>
/// 大砲の弾の弾道計算
/// </summary>
=======
>>>>>>> origin/master
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
<<<<<<< HEAD
        Debug.Log("CannonFiring Start Method Start");

        interval = attackInterval;

        Debug.Log("CannonFiring Start Method End");
=======
        Debug.Log("CannonFiring StartFunctio Start");

        interval = attackInterval;

        Debug.Log("CannonFiring StartFunctio End");
>>>>>>> origin/master
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    public void Update()
    {
<<<<<<< HEAD
        Debug.Log("CannonFiring Update Method Start");
=======
        Debug.Log("CannonFiring StartFunctio Start");
>>>>>>> origin/master

        // 射出するまでの時間を減少
        interval = interval - Time.deltaTime;

        // 射出時間になれば
        if(interval <= 0)
        {
            // 射出
            Firing();
<<<<<<< HEAD

            // 射出時間をリセット
=======
>>>>>>> origin/master
            interval = attackInterval;
        }

        // 標的がいれば
        if(targetObject != null)
        {
            // 標的に方向を向ける
<<<<<<< HEAD
            // transform.LookAt(targetObject.transform);
        }

        Debug.Log("CannonFiring Update Method End");
=======
            transform.LookAt(targetObject.transform);
        }

        Debug.Log("CannonFiring StartFunctio End");
>>>>>>> origin/master
    }

    /// <summary>
    /// 弾発射
    /// </summary>
    private void Firing()
    {
<<<<<<< HEAD
        Debug.Log("CannonFiring Firing Method Start");

=======
>>>>>>> origin/master
        // cannonBallとtargetObjectが設定されていれば
        if (cannonBall != null && targetObject != null)
        {
            // cannonBallを作成
<<<<<<< HEAD
            GameObject ball = Instantiate(cannonBall, transform.position + new Vector3(0, 2, 0), Quaternion.identity);
=======
            GameObject ball = Instantiate(cannonBall, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
>>>>>>> origin/master

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
<<<<<<< HEAD

        Debug.Log("CannonFiring Firing Method End");
=======
>>>>>>> origin/master
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
<<<<<<< HEAD
        Debug.Log("CannonFiring CalculateVelocity Method Start");

=======
>>>>>>> origin/master
        // 球の角度をラジアン値に変換
        float radian = angle * Mathf.PI / 180;

        // 大砲から標的の距離を取得
        float x = Vector2.Distance(new Vector2(pointA.x, pointA.z), new Vector2(pointB.x, pointB.z));
        float y = pointA.y - pointB.y;
       
        // 弾の速度が0だったら
        if(float.IsNaN(speed))
        {
<<<<<<< HEAD
            // うんち
            return Vector3.zero;
        }

        Debug.Log("CannonFiring CalculateVelocity Method End");

=======
            Debug.Log("うんち");
            //うんち
            return Vector3.zero;
        }

>>>>>>> origin/master
        // 弾の方向、速度を返す
        return new Vector3(pointB.x - pointA.x, x * Mathf.Tan(radian), pointB.z - pointA.z).normalized * speed;
    }

    /// <summary>
    /// 範囲内に入った時の処理
    /// </summary>
    /// <param name="other">相手のオブジェクト</param>
    public void OnTriggerEnter(Collider other)
    {
<<<<<<< HEAD
        Debug.Log("CannonFiring OnTriggerEnter Method Start");

        // 範囲内に入ったオブジェクトのタグがCharacterであれば
        if (other.gameObject.tag == "Character")
        {
            // 標的のオブジェクトを設定
            targetObject = other.gameObject;
        }

        Debug.Log("CannonFiring OnTriggerEnter Method End");
=======
        if(other.gameObject.tag == "Character")
        {
            targetObject = other.gameObject;
        }
>>>>>>> origin/master
    }

    /// <summary>
    /// 範囲から出た時の処理
    /// </summary>
    /// <param name="other">相手のオブジェクト</param>
    public void OnTriggerExit(Collider other)
    {
<<<<<<< HEAD
        Debug.Log("CannonFiring OnTriggerExit Method Start");

        // 範囲外に出たオブジェクトのタグがCharacterであれば
        if (other.gameObject.tag == "Character")
        {
            // 標的のオブジェクトを設定
            targetObject = null;
        }

        Debug.Log("CannonFiring OnTriggerExit Method End");
=======
        if (other.gameObject.tag == "Character")
        {
            targetObject = null;
        }
>>>>>>> origin/master
    }
}
