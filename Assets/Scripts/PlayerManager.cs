using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    private int speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 6;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horzontalInput = Input.GetAxis("Horizontal");

        transform.Translate( new Vector3(horzontalInput, 0, verticalInput).normalized * speed * Time.deltaTime);

        LookMousePosition();

    }

    private void LookMousePosition() 
    {
        Vector3 mouseLookPos = Input.mousePosition;
        this.transform.Rotate(new Vector3(0, mouseLookPos.y, 0).normalized * speed * Time.deltaTime);
    }
}
