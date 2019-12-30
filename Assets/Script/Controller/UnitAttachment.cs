using UnityEngine;

public class UnitAttachment : MonoBehaviour
{
    private GameObject unit;

    /// <summary>
    /// 初期化処理
    /// </summary>
    private void Start()
    {
        
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    private void Update()
    {
        
    }

    /// <summary>
    /// タイルにユニットを設置
    /// </summary>
    /// <param name="gameObject"></param>
    public void SetUnit(GameObject gameObject)
    {
        unit = gameObject;
    }

    /// <summary>
    /// ユニットを渡す
    /// </summary>
    /// <returns>ユニット</returns>
    public GameObject GetUnit()
    {
        return unit;
    }
}
