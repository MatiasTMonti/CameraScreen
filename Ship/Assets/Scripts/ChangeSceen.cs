using UnityEngine;
using UnityEngine.UI;

public class ChangeSceen : MonoBehaviour
{
    [SerializeField] private Image imagePanel;
    [SerializeField] private TMPro.TextMeshProUGUI text;

    public void SetActiveText()
    {
        text.text = "El boton cambia el color de fondo";
    }

    public void DesactiveText()
    {
        text.text = "";
    }

    public void ChangeScreen()
    {
        imagePanel.color = Color.red;
    }
}
