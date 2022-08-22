using UnityEngine;
[RequireComponent(typeof(BoxCollider))]
public class Conveyor : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<Box>())
        {
            other.transform.position += gameObject.transform.forward * _speed * Time.fixedDeltaTime;
        }
    }
}
