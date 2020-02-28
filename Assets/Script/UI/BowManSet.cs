using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 大砲ユニットを設置
/// </summary>
public class BowManSet : MonoBehaviour
{
    /// <summary>
    /// ゲームコントローラーオブジェクト
    /// </summary>
    [SerializeField]
    private GameObject gameController;

    /// <summary>
    /// 大砲オブジェクト
    /// </summary>
    [SerializeField]
    private GameObject bowman;

    /// <summary>
    /// 所持金オブジェクト
    /// </summary>
    [SerializeField]
    private GameObject money;

    /// <summary>
    /// 大砲ユニットの金額コスト
    /// </summary>
    [SerializeField]
    private int unitCost;

    /// <summary>
    /// 初期化処理
    /// </summary>
    private void Start()
    {
        Debug.Log("CannonSet Start Method Start");

        // ボタンのテキストを変更
        GetComponentInChildren<Text>().text = "BowMan = " + unitCost;

        Debug.Log("CannonSet Start Method End");
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    private void Update()
    {
        Debug.Log("CannonSet Update Method Start");
        Debug.Log("CannonSet Update Method End");
    }

    /// <summary>
    /// クリック時
    /// </summary>
    public void Onclick()
    {
        Debug.Log("CannonSet Onclick Method Start");

        // Playerが選択中のオブジェクトを取得
        GameObject selectObject = gameController.GetComponent<ClickSelect>().GetSelectObject();

        // Playerが選択中のオブジェクトが存在しなければ
        if (selectObject == null)
        {
            // 終了
            return;
        }

        // Playerが選択中のオブジェクトのユニット情報を取得
        GameObject unitObject = selectObject.GetComponent<UnitAttachment>().GetUnit();

        // ユニットが配置されていなく、大砲ユニットの金額コストが所持金を上回っていれば
        if (unitObject == null && money.GetComponent<Money>().GetMoney() >= unitCost)
        {
            // 大砲ユニットを設置
            GameObject createCannon = Instantiate(bowman, selectObject.transform.position + new Vector3(0.0f, 1.0f, 0.0f), Quaternion.identity);

            // Playerが選択中のオブジェクトに大砲ユニットを設定
            selectObject.GetComponent<UnitAttachment>().SetUnit(createCannon);

            // 所持金を大砲ユニットの金額コスト分消費
            money.GetComponent<Money>().SubtractionMoney(unitCost);
        }

        Debug.Log("CannonSet Onclick Method End");
    }
}
