using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{

    [SerializeField] LayerMask _movementMask;

    Camera _cam;

    PlayerMotor _motor;

	// Use this for initialization
	void Start ()
	{
	    _cam = Camera.main;
	    _motor = GetComponent<PlayerMotor>();
	}
	
	// Update is called once per frame
	void Update ()
	{
        
	    if (Input.GetMouseButtonDown(0))
	    {
	        Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
	        RaycastHit hit;
	        if (Physics.Raycast(ray, out hit, 100, _movementMask))
	        {
                _motor.MoveToPoint(hit.point);
	        }
	    }

	    if (Input.GetMouseButtonDown(1))
	    {
	        Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
	        RaycastHit hit;
	        if (Physics.Raycast(ray, out hit, 100))
	        {

	        }
	    }
	}
}
