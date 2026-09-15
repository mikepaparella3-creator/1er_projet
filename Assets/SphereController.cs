using UnityEngine;

public class SphereController : MonoBehaviour
{
    [SerializeField] Vector3 _Direction;
    [SerializeField] float _Speed, _Distance, _Duration, _Scale;
    [SerializeField] Color _Color1, _Color2;
    [SerializeField] Renderer _Renderer;

    Vector3 startPos, targetPos;
    Vector3 startScale, targetScale;
    Material _Material;
    float t = 0;
    float color_t = 0;
    void Start()
    {
        startPos = transform.position;
        targetPos = startPos + _Direction * _Distance;
        startScale = transform.localScale;
        targetScale = startScale * _Scale;
        _Material = _Renderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * _Speed;
        color_t += Time.deltaTime / _Duration;
        t = Mathf.PingPong(t, 1);
        color_t = Mathf.PingPong(color_t, 1);

        transform.position = Vector3.Lerp(startPos, targetPos, t);
        transform.localScale = Vector3.Lerp(startScale, targetScale, t);
        _Material.color = Color.Lerp(_Color1, _Color2, color_t);

    }


}
