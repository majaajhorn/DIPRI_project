using UnityEngine;
using UnityEngine.UI;

public class MiniMapPlayerIcon : MonoBehaviour
{
    public Transform player;
    public RectTransform miniMapPanel;

    public float mapScale = 1.0f;  // prilagodi ovisno o veličini terena i mape

    void Update()
    {
        if (player == null || miniMapPanel == null) return;

        Vector2 playerPos = new Vector2(player.position.x, player.position.z) * mapScale;

        // Postavi poziciju ikone unutar mini mape
        GetComponent<RectTransform>().anchoredPosition = playerPos;
    }
}