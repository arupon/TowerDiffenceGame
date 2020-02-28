using UnityEngine;

<<<<<<< HEAD
/// <summary>
/// 大砲の弾が着弾した時の挙動
/// </summary>
public class CannonBall : MonoBehaviour
{
    /// <summary>
    /// 爆風オブジェクト
=======
public class CannonBall : MonoBehaviour
{
    /// <summary>
    /// 爆風
>>>>>>> origin/master
    /// </summary>
    [SerializeField]
    private GameObject cannonBomb;

    /// <summary>
<<<<<<< HEAD
    /// 生成されているかの判定
=======
    /// 生成されているか
>>>>>>> origin/master
    /// </summary>
    private bool isInstntiate;

    /// <summary>
    /// 初期化処理
    /// </summary>
<<<<<<< HEAD
    private void Start()
    {
        Debug.Log("CannonBall Start Method Start");

        // 生成されていない判定
        isInstntiate = false;

        Debug.Log("CannonBall Start Method End");
=======
    public void Start()
    {
        Debug.Log("CannonBall StartFunctio Start");

        // 生成されていない
        isInstntiate = false;
        Debug.Log("CannonBall StartFunctio End");
>>>>>>> origin/master
    }

    /// <summary>
    /// 更新処理
    /// </summary>
<<<<<<< HEAD
    private void Update()
    {
        Debug.Log("CannonBall Update Method Start");

        Debug.Log("CannonBall Update Method End");
=======
    public void Update()
    {
        Debug.Log("CannonBall UpdateFunctio Start");
        Debug.Log("CannonBall UpdateFunctio End");
>>>>>>> origin/master
    }

    /// <summary>
    /// 衝突判定
    /// </summary>
    /// <param name="collision">衝突対象</param>
    public void OnCollisionEnter(Collision collision)
    {
<<<<<<< HEAD
        Debug.Log("CannonBall OnCollisionEnter Method Start");

=======
>>>>>>> origin/master
        // マップに衝突したら
        if (collision.gameObject.tag == "Map")
        {
            // 弾を削除
            Destroy(gameObject);

            // 爆風が発生していなければ
<<<<<<< HEAD
            if (isInstntiate == false)
=======
            if(isInstntiate == false)
>>>>>>> origin/master
            {
                // 爆風を発生
                Instantiate(cannonBomb, transform.position, Quaternion.identity);
                // 発生している
                isInstntiate = true;
            }
        }
<<<<<<< HEAD

        Debug.Log("CannonBall OnCollisionEnter Method End");
=======
>>>>>>> origin/master
    }
}
