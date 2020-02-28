using UnityEngine;

/// <summary>
/// 大砲の弾が着弾した時の挙動
/// </summary>
public class CannonBall : MonoBehaviour
{
    /// <summary>
    /// 爆風オブジェクト
    /// </summary>
    [SerializeField]
    private GameObject cannonBomb;

    /// <summary>
    /// 生成されているかの判定
    /// </summary>
    private bool isInstntiate;

    /// <summary>
    /// 初期化処理
    /// </summary>
    private void Start()
    {
        Debug.Log("CannonBall Start Method Start");

        // 生成されていない判定
        isInstntiate = false;

        Debug.Log("CannonBall Start Method End");
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    private void Update()
    {
        Debug.Log("CannonBall Update Method Start");

        Debug.Log("CannonBall Update Method End");
    }

    /// <summary>
    /// 衝突判定
    /// </summary>
    /// <param name="collision">衝突対象</param>
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CannonBall OnCollisionEnter Method Start");

        // マップに衝突したら
        if (collision.gameObject.tag == "Map")
        {
            // 弾を削除
            Destroy(gameObject);

            // 爆風が発生していなければ
            if (isInstntiate == false)
            {
                // 爆風を発生
                Instantiate(cannonBomb, transform.position, Quaternion.identity);
                // 発生している
                isInstntiate = true;
            }
        }

        Debug.Log("CannonBall OnCollisionEnter Method End");
    }
}
