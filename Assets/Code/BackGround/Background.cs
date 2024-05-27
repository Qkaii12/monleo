using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    [SerializeField] private RawImage backGround;
    [SerializeField] private float _x, _y;
    [SerializeField] private float speed;
    [SerializeField] private PlayerMovement moveComponent;

    private void BackGround()
    {
        var scale = transform.localScale;
        if(moveComponent.moveRight == true)
        {
            backGround.uvRect = new Rect(backGround.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, backGround.uvRect.size);
            if(moveComponent.stopGroundLeft == true)
            {
                return;
            }
        }
        if (moveComponent.moveLeft == true)
        {
            backGround.uvRect = new Rect(backGround.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, backGround.uvRect.size);
            if (moveComponent.stopGroundRight == true)
            {
                return;
            }
        }
    }
    void Update()
    {
        BackGround();
    }
}
