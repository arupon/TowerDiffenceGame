using UnityEngine;

/// <summary>
/// 大砲の弾が着弾した時の挙動
/// </summary>
public class Arrow : MonoBehaviour
{
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
    /// <param name="other">衝突対象</param>
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("CannonBall OnCollisionEnter Method Start");

        // マップかキャラクターに衝突したら
        if (other.gameObject.tag == "Map" || other.gameObject.tag == "Character")
        {
            // 矢を削除
            Destroy(gameObject);
        }

        Debug.Log("CannonBall OnCollisionEnter Method End");
    }
}
