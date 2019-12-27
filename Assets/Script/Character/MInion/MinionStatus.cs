using UnityEngine;

/// <summary>
/// ミニオンのステータス
/// </summary>
public class MinionStatus : MonoBehaviour
{
    // 体力
    [SerializeField]
    private int hp;

    /// <summary>
    /// 初期化処理
    /// </summary>
    public void Start()
    {
        Debug.Log("MinionStatus StartFunction Start");
        Debug.Log("MinionStatus StartFunction Finish");
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    public void Update()
    {
        Debug.Log("MinionStatus UpdateFunction Start");

        if(hp <= 0)
        {
            Destroy(this.gameObject);
        }

        Debug.Log("MinionStatus UpdateFunction Finish");
    }

    /// <summary>
    /// 衝突処理
    /// </summary>
    /// <param name="other">衝突対象</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CannonBall")
        {
            hp = hp - 50;
        }
    }
}
