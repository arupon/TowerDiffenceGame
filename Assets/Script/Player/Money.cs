using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    [SerializeField]
    private string moneyTextInitialized;

    private Text moneyText;

    [SerializeField]
    private float money;

    /// <summary>
    /// 初期化処理
    /// </summary>
    private void Start()
    {
        Debug.Log("Money Start Method Start");

        // 所持金表示用テキスト取得
        moneyText = GetComponent<Text>();

        // 所持金表示用テキスト初期表示
        moneyText.text = moneyTextInitialized;

        Debug.Log("Money Start Method End");
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    private void Update()
    {
        Debug.Log("Money Update Method Start");

        // 所持金追加
        AddMoney(Time.deltaTime);

        // 現在の所持金を所持金表示用テキストに反映
        moneyText.text = moneyTextInitialized.Replace("#money#", Mathf.Floor(money).ToString());

        Debug.Log("Money Update Method End");
    }

    /// <summary>
    /// 所持金追加
    /// </summary>
    /// <param name="addMoney">追加する金額</param>
    public void AddMoney(float addMoney)
    {
        Debug.Log("Money AddMoney Method Start");

        // 所持金を追加
        money = money + addMoney;

        Debug.Log("Money AddMoney Method End");
    }

    /// <summary>
    /// 所持金を消費
    /// </summary>
    /// <param name="subtractionMoney">消費する金額</param>
    public void SubtractionMoney(float subtractionMoney)
    {
        Debug.Log("Money SubtractionMoney Method Start");

        // 所持金を消費
        money = money - subtractionMoney;

        Debug.Log("Money SubtractionMoney Method End");
    }

    /// <summary>
    /// 所持金を取得
    /// </summary>
    /// <returns>所持金</returns>
    public float GetMoney()
    {
        Debug.Log("Money GetMoney Method Start");

        Debug.Log("Money GetMoney Method End");

        // 所持金を取得
        return money;
    }
}
