using UnityEngine;

/// <summary>
/// ミニオンのステータス
/// </summary>
public class MinionStatus : MonoBehaviour
{
    /// <summary>
    /// ミニオンの体力
    /// </summary>
    [SerializeField]
    private int hp;

    /// <summary>
    /// 初期化処理
    /// </summary>
    private void Start()
    {
        Debug.Log("MinionStatus Start Method Start");

        Debug.Log("MinionStatus Start Method End");
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    public void Update()
    {
        Debug.Log("MinionStatus Update Method Start");

        // ミニオンの体力が0を下回ったら
        if (hp <= 0)
        {
            // ミニオンを削除
            Destroy(gameObject);
        }

        Debug.Log("MinionStatus Update Method End");
    }

    /// <summary>
    /// 衝突処理
    /// </summary>
    /// <param name="other">衝突対象</param>
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("MinionStatus OnTriggerEnter Method Start");

        switch (other.gameObject.tag)
        {
            // 衝突対象のタグがCannonBombであれば
            case "CannonBomb":
                // ミニオンのHPを50減らす
                hp = hp - 50;
                break;
            // 衝突対象のタグがArrowであれば
            case "Arrow":
                // ミニオンのHPを25減らす
                hp = hp - 25;
                break;
        }

        Debug.Log("MinionStatus OnTriggerEnter Method End");
    }
}
