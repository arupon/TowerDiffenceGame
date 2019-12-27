using UnityEngine;

public class CannonBall : MonoBehaviour
{
    /// <summary>
    /// 爆風
    /// </summary>
    [SerializeField]
    private GameObject cannonBomb;

    /// <summary>
    /// 生成されているか
    /// </summary>
    private bool isInstntiate;

    /// <summary>
    /// 初期化処理
    /// </summary>
    public void Start()
    {
        Debug.Log("CannonBall StartFunctio Start");

        // 生成されていない
        isInstntiate = false;
        Debug.Log("CannonBall StartFunctio End");
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    public void Update()
    {
        Debug.Log("CannonBall UpdateFunctio Start");
        Debug.Log("CannonBall UpdateFunctio End");
    }

    /// <summary>
    /// 衝突判定
    /// </summary>
    /// <param name="collision">衝突対象</param>
    public void OnCollisionEnter(Collision collision)
    {
        // マップに衝突したら
        if (collision.gameObject.tag == "Map")
        {
            // 弾を削除
            Destroy(gameObject);

            // 爆風が発生していなければ
            if(isInstntiate == false)
            {
                // 爆風を発生
                Instantiate(cannonBomb, transform.position, Quaternion.identity);
                // 発生している
                isInstntiate = true;
            }
        }
    }
}
