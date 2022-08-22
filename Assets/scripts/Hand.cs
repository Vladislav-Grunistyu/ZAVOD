using UnityEngine;
[RequireComponent(typeof(Animator))]

public class Hand : MonoBehaviour
{
    [SerializeField]
    private GameObject _targetForBox;
    private GameObject _box;
    private Animator _anim;
    private bool _boxInHand;
    void Start()
    {
        _anim = GetComponent<Animator>();
        _boxInHand = false;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<Box>() && _box == null)
        {
            _box = other.gameObject;
            _anim.SetBool("BoxInTrigger",true);
        }
    }

    private void PickupBox()
    {
        _boxInHand = true;
    }
    private void Update()
    {
        if (_boxInHand)
        {
            _box.transform.position = _targetForBox.transform.position;
            _box.transform.rotation = _targetForBox.transform.rotation;
        }
    }
    private void PutBox()
    {
        _anim.SetBool("BoxInTrigger", false);
        _box = null;
        _boxInHand = false;
    }
}
