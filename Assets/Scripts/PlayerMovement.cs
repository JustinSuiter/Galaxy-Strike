using Unity.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements.Experimental;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float controlSpeed = 10f;

    Vector2 mvoement;
    void Update()
    {
        ProcessTranslation();
    }


    public void OnMove(InputValue value)
    {
        mvoement = value.Get<Vector2>();
    }
    
    private void ProcessTranslation()
    {
        float yOffset = mvoement.y * controlSpeed * Time.deltaTime;

        float xOffset = mvoement.x * controlSpeed * Time.deltaTime;

        transform.localPosition = new Vector3(transform.localPosition.x + xOffset, transform.localPosition.y + yOffset, 0f);
    }

}
