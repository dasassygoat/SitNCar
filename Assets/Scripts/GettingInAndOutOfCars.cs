using UnityEngine;
using UnityEngine.Serialization;
using UnityStandardAssets.Cameras;
using UnityStandardAssets.Vehicles.Car;

public class GettingInAndOutOfCars : MonoBehaviour
{
    [FormerlySerializedAs("camera")] [Header("Camera")] [SerializeField] AutoCam mCamera = null;

    [Header("Human")] [SerializeField] private GameObject human = null;

    [Space, Header("Car Stuff")] [SerializeField]
    private GameObject car = null;

    [SerializeField] private CarUserControl carController = null;

    [Header("Input")] [SerializeField] private KeyCode enterExitKey = KeyCode.E;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(enterExitKey))
        {
            human.SetActive(!human.activeSelf);
            if (human.activeSelf) GetOutOfCar();
            else GetIntoCar();
        }
    }

    private void GetIntoCar()
    {
        carController.enabled = true;
    }

    void GetOutOfCar()
    {
        human.transform.position = car.transform.position + car.transform.TransformDirection(Vector3.left) * 2;
        mCamera.SetTarget(human.transform);
        carController.enabled = false;
    }
}
