using UnityEngine;

/// <summary>
/// ユニットをマウスに追従させるスクリプト
/// </summary>
public class MouseTracking : MonoBehaviour
{
    private Vector3 screenPoint;
    private Rigidbody myRigidbody;

    /// <summary>
    /// 初期化設定
    /// </summary>
    public void Start()
    {
        screenPoint = Vector3.zero;
        myRigidbody = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// 更新
    /// </summary>
    public void Update()
    {
        // マウスに追従
        Tracking();
    }

    /// <summary>
    /// マウスに追従する処理
    /// </summary>
    private void Tracking()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo = new RaycastHit();

        if(Physics.Raycast(ray, out hitInfo) == true)
        {
            myRigidbody.position = hitInfo.point;
        }
        Debug.DrawRay(ray.origin, ray.direction * 1000.0f);
    }
}
