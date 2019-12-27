using UnityEngine;

/// <summary>
/// クリック動作した時の処理
/// </summary>
public class UnitSelectClickAction : MonoBehaviour
{
    /// <summary>
    /// 初期化処理
    /// </summary>
    public void Start()
    {
        
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    public void Update()
    {
        if (Input.GetMouseButtonDown(1) == true)
        {
            Destroy(gameObject);
        }
    }
}
