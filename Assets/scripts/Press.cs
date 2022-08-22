using UnityEngine;

public class Press : MonoBehaviour
{
    [SerializeField]
    private GameObject _sticker;
    [SerializeField]
    Sticker StickerPress;

    private Animator _anim;
    private GameObject _boxInPress;
    
    void Start()
    {
        _anim = GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        _anim.SetBool("HitPress", true);
        if (_boxInPress != null)
        {
            SetSticker(_boxInPress);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Box>())
        {
            _boxInPress = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Box>())
        {
            _boxInPress = null;
        }
    }
    private void SetSticker(GameObject box)
    {
        box.gameObject.GetComponent<Box>().Sticker = StickerPress;
        if (box.transform.childCount > 0)
        {
            Destroy(box.transform.GetChild(0).gameObject);
        }
        GameObject parent = Instantiate(_sticker, box.transform.position + new Vector3(0f, 0.082f,-0.077f), Quaternion.Euler(0, 90, 0));
        parent.transform.parent = box.transform;
    }
    private void EndAnimation()
    {
        _anim.SetBool("HitPress", false);
    }
}
