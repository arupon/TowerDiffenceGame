using UnityEngine;

/// <summary>
/// ミニオンのステータス
/// </summary>
public class MinionStatus : MonoBehaviour
{
<<<<<<< HEAD
    /// <summary>
    /// ミニオンの体力
    /// </summary>
=======
    // 体力
>>>>>>> origin/master
    [SerializeField]
    private int hp;

    /// <summary>
    /// 初期化処理
    /// </summary>
<<<<<<< HEAD
    private void Start()
    {
        Debug.Log("MinionStatus Start Method Start");

        Debug.Log("MinionStatus Start Method End");
=======
    public void Start()
    {
        Debug.Log("MinionStatus StartFunction Start");
        Debug.Log("MinionStatus StartFunction Finish");
>>>>>>> origin/master
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    public void Update()
    {
<<<<<<< HEAD
        Debug.Log("MinionStatus Update Method Start");

        // ミニオンの体力が0を下回ったら
        if (hp <= 0)
        {
            // ミニオンを削除
            Destroy(gameObject);
        }

        Debug.Log("MinionStatus Update Method End");
=======
        Debug.Log("MinionStatus UpdateFunction Start");

        if(hp <= 0)
        {
            Destroy(this.gameObject);
        }

        Debug.Log("MinionStatus UpdateFunction Finish");
>>>>>>> origin/master
    }

    /// <summary>
    /// 衝突処理
    /// </summary>
    /// <param name="other">衝突対象</param>
    private void OnTriggerEnter(Collider other)
    {
<<<<<<< HEAD
        Debug.Log("MinionStatus OnTriggerEnter Method Start");

        // 衝突対象のタグがCannonBallであれば
        if (other.gameObject.tag == "CannonBall")
        {
            // ミニオンのHPを50減らす
            hp = hp - 50;
        }

        Debug.Log("MinionStatus OnTriggerEnter Method End");
=======
        if (other.gameObject.tag == "CannonBall")
        {
            hp = hp - 50;
        }
>>>>>>> origin/master
    }
}
