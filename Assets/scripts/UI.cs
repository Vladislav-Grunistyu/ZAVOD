using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField]
    private Text _sqareTextField;
    [SerializeField]
    private Text _circleTextField;

    private int _sqareCountScore = 0;
    private int _circleCountScore = 0;
    private void OnEnable()
    {
        Sale.onSquareSale += AddSquareScore;
        Sale.onCircleSale += AddCircleScore;
    }
    private void OnDisable()
    {
        Sale.onSquareSale -= AddSquareScore;
        Sale.onCircleSale -= AddCircleScore;
    }

    private void AddSquareScore()
    {
        _sqareCountScore++;
        _sqareTextField.text = _sqareCountScore.ToString();
    }
    private void AddCircleScore()
    {
        _circleCountScore++;
        _circleTextField.text = _circleCountScore.ToString();
    }
}
