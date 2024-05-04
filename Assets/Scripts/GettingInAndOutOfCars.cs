using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class GettingInAndOutOfCars : MonoBehaviour
{
    [Header("Human")]
    [SerializeField] private GameObject human = null;
    
    [Space, Header("Car Stuff")] [SerializeField]
    private GameObject car = null;

    [SerializeField] private CarUserControl carController = null;
    
    [Header("Input")]
    [SerializeField] private KeyCode enterExitKey = KeyCode.E;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(enterExitKey))
        {
            human.SetActive(!human.activeSelf);
            if(!human.activeSelf )GetOutOfCar();
        }
    }

    void GetOutOfCar()
    {
        //human.SetActive(true);
        human.transform.position = car.transform.position + car.transform.TransformDirection(Vector3.left) * 2;
        carController.enabled = false;
    }
}
