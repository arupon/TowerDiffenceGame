using UnityEngine;
using UnityEngine.Rendering;

public class SelectObject : MonoBehaviour
{
    /// <summary>
    /// コマンドバッファ名
    /// </summary>
    private const string CommandBufferName = "StencilImageEffect";

    /// <summary>
    /// イメージエフェクトで使用するマテリアル
    /// </summary>
    [SerializeField]
    private Material material;

    /// <summary>
    /// イメージエフェクト用コマンドバッファ
    /// </summary>
    private CommandBuffer commandBuffer;

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
        
    }

    private void OnEnable()
    {
        if(material == null)
        {
            return;
        }

        if(commandBuffer == null)
        {
            return;
        }

        Camera camera = GetComponent<Camera>();
        CommandBuffer[] commandBuffers = camera.GetCommandBuffers(CameraEvent.BeforeImageEffects);

        foreach( CommandBuffer commandBuffer in commandBuffers)
        {
            if(commandBuffer.name == CommandBufferName)
            {
                return;
            }
        }
        commandBuffer = new CommandBuffer();
        commandBuffer.name = CommandBufferName;

        commandBuffer.Blit(BuiltinRenderTextureType.CameraTarget, BuiltinRenderTextureType.CameraTarget, material);

        camera.AddCommandBuffer(CameraEvent.BeforeImageEffects, commandBuffer);
    }

    private void OnDisable()
    {
        if(commandBuffer == null)
        {
            return;
        }

        Camera camera = GetComponent<Camera>();
        camera.RemoveCommandBuffer(CameraEvent.BeforeImageEffects, commandBuffer);
        commandBuffer = null;
    }
}
