using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    private MeshRenderer meshRenderer => _meshRenderer ?? (_meshRenderer = GetComponent<MeshRenderer>());

    [SerializeField] private float animationSpeed = 1f; //this will change for background and ground.

    private void Update()
    {
        OffSetChanger();
    }

    private void OffSetChanger()
    {
        var mat = meshRenderer.material;
        var textureOffset = mat.mainTextureOffset;

        if (GameManager.isBirdEnable)
        {
            textureOffset.x += animationSpeed * Time.deltaTime;
        }
        textureOffset.x = Mathf.Repeat(textureOffset.x, 1f);

        mat.mainTextureOffset = textureOffset;
    }
}
