using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
}
