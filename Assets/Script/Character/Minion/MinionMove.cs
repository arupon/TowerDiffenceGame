using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// ミニオンの移動処理
/// </summary>
public class MinionMove : MonoBehaviour
{
    /// <summary>
    /// 目標地点
    /// </summary>
    [SerializeField]
    private Transform goalPoint;

    /// <summary>
    /// 初期化処理
    /// </summary>
    public void Start()
    {
        Debug.Log("MinionMove Start Method Start");

        // NavMeshAgentコンポーネントを取得
        NavMeshAgent agent = GetComponent<NavMeshAgent>();

        // NavMeshAgentの目標地点を設定
        agent.destination = goalPoint.position;

        Debug.Log("MinionMove Start Method End");
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    public void Update()
    {
        Debug.Log("MinionMove Update Method Start");

        Debug.Log("MinionMove Update Method End");
    }
}
