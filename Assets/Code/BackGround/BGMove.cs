using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : MonoBehaviour
{
    public Transform player; // Kéo và thả player object vào đây trong Inspector
    public float parallaxSpeedX = 1; // Tốc độ di chuyển của background theo trục X
    public float parallaxSpeedY = 0; // Tốc độ di chuyển của background theo trục Y

    private Vector3 lastPlayerPosition; // Vị trí cuối cùng của người chơi

    void Start()
    {
        lastPlayerPosition = player.position;
    }

    void Update()
    {
        // Tính toán sự chênh lệch giữa vị trí hiện tại của người chơi và vị trí cuối cùng của người chơi
        float deltaX = player.position.x - lastPlayerPosition.x;
        float deltaY = player.position.y - lastPlayerPosition.y;

        // Nếu người chơi di chuyển theo trục X, di chuyển background theo trục X
        if (deltaX != 0)
        {
            transform.position += new Vector3(deltaX * parallaxSpeedX, 0, 0);
        }

        // Nếu người chơi di chuyển theo trục Y, di chuyển background theo trục Y
        if (deltaY != 0)
        {
            transform.position += new Vector3(0, deltaY * parallaxSpeedY, 0);
        }

        // Cập nhật vị trí cuối cùng của người chơi
        lastPlayerPosition = player.position;
    }
}
