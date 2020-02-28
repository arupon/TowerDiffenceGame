using UnityEngine;

<<<<<<< HEAD
/// <summary>
/// ユニットの設置
/// </summary>
public class UnitAttachment : MonoBehaviour
{
    /// <summary>
    /// ユニット
    /// </summary>
=======
public class UnitAttachment : MonoBehaviour
{
>>>>>>> origin/master
    private GameObject unit;

    /// <summary>
    /// 初期化処理
    /// </summary>
    private void Start()
    {
<<<<<<< HEAD
        Debug.Log("UnitAttachment Start Method Start");

        Debug.Log("UnitAttachment Start Method End");
=======
        
>>>>>>> origin/master
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    private void Update()
    {
<<<<<<< HEAD
        Debug.Log("UnitAttachment Update Method Start");

        Debug.Log("UnitAttachment Update Method End");
    }

    /// <summary>
    /// タイルにユニットを設定
    /// </summary>
    /// <param name="gameObject">設定するユニット</param>
    public void SetUnit(GameObject gameObject)
    {
        Debug.Log("UnitAttachment SetUnit Method Start");

        // タイルにユニットを設定
        unit = gameObject;

        Debug.Log("UnitAttachment SetUnit Method End");
    }

    /// <summary>
    /// ユニットを取得
=======
        
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
>>>>>>> origin/master
    /// </summary>
    /// <returns>ユニット</returns>
    public GameObject GetUnit()
    {
<<<<<<< HEAD
        Debug.Log("UnitAttachment GetUnit Method Start");

        Debug.Log("UnitAttachment GetUnit Method End");

=======
>>>>>>> origin/master
        return unit;
    }
}
