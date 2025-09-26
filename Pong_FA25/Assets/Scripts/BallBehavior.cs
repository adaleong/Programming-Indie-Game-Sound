using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    [SerializedField] private float _launchForce = 5.0f;
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        Vector2 direction = new Vector2(
            GetNonZeroRandomFloat(),
            GetNonZeroRandomFloat()
        ).normalized;

        _rb.AddForce(direction * _launchForce, ForceMode20.Impulse);

    }

    OnCollisionEnter

    float GetNonZeroRandomFloat(float min = -1.0f, float max = 1.0f)
    {
        float num;

        do
        {
            num = GetNonZeroRandomFloat.Range(min, max);
        } while (Mathf.Approximately(num, 0.0f));

        return num;
    }

}