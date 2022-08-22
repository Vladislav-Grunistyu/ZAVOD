using System;
using UnityEngine;
[RequireComponent(typeof(BoxCollider))]
public class Sale : MonoBehaviour
{
    public static Action onSquareSale;
    public static Action onCircleSale;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Box>())
        {
            switch (other.gameObject.GetComponent<Box>().Sticker)
            {
                case Sticker.Square:
                    onSquareSale?.Invoke();
                    break;
                case Sticker.Circle:
                    onCircleSale?.Invoke();
                    break;
            }
            Destroy(other.gameObject);
        }
    }
}
