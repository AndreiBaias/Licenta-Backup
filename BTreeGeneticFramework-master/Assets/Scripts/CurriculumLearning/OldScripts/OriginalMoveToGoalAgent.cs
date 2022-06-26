using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;



public class RandomGoalPositionAgent : Agent
{
//     [SerializeField] private GameObject goalObject;
//     private Rigidbody AgentRigidbody;
//     // EnvironmentParameters ResetParams;
//     // public override void Initialize()
//     // {
//     //     ResetParams = Academy.Instance.EnvironmentParameters;
//     // }
//     public Material sMaterial;
//     public Material fMaterial;
//     public GameObject bounds;
//     private GameObject backWall;
//     private Material bMaterial;
//     public Material msMaterial;
// //and than your can get you value for example in OnEpisodeBeginn()
// // distanceToAgent = m_ResetParams.GetWithDefault("distanceToAgent", 1.0f);
    
//     public override void Initialize()
//     {
//         goalObject = GameObject.FindGameObjectWithTag("Goal");
//         bMaterial = bounds.transform.GetChild(0).gameObject.GetComponent<Renderer>().material;
//         AgentRigidbody = GetComponent<Rigidbody>();
//     }
//     public override void OnEpisodeBegin()
//     {  
//         float lessonValue = Academy.Instance.EnvironmentParameters.GetWithDefault("tankPos", 0.0f);
//         transform.localPosition = new Vector3(-30, 0, -5*lessonValue);
//         backWall = bounds.transform.GetChild(1).gameObject;
//         backWall.transform.localPosition = transform.localPosition + new Vector3(0, 0, -5);
//         transform.rotation = Quaternion.identity;
//         Debug.Log("Lesson number: " + lessonValue);
//     }
    
//     private void FixedUpdate()
//     {
//         if(StepCount >= 4500)
//         {
//             SetReward(-1.2f);
//             Debug.Log("Max steps reached");
//             changeMaterial(msMaterial);
//             EndEpisode();
//         }
//         // AddReward(-1/MaxStep);
//     }
//     // private float DistanceToGoal()
//     // {
//     //     return (transform.position - goalObject.transform.position).magnitude;
//     // }
//     public override void CollectObservations(VectorSensor sensor)
//     {
//         sensor.AddObservation(transform.position);
//         sensor.AddObservation(transform.rotation);
//         sensor.AddObservation(goalObject.transform.position);
//         //sensor.AddObservation(DistanceToGoal());
//         sensor.AddObservation(transform.forward);
//         sensor.AddObservation((goalObject.transform.position - transform.position).normalized);
//     }
//     private void Move(float MovementInputValue, float MovementSpeed)
//     {
//         // Create a vector in the direction the tank is facing with a magnitude based on the input, speed and the time between frames.
//         Vector3 movement = transform.forward * MovementInputValue * MovementSpeed * Time.deltaTime;

//         // Apply this movement to the rigidbody's position.
//         AgentRigidbody.MovePosition(AgentRigidbody.position + movement);
//     }

//     //https://docs.unity3d.com/ScriptReference/Transform-eulerAngles.html

//     private void Turn(float TurnInputValue, float TurnSpeed)
//     {
//         // Determine the number of degrees to be turned based on the input, speed and time between frames.
//         float turn = TurnInputValue * TurnSpeed * Time.deltaTime;

//         // Make this into a rotation in the y axis.
//         Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);

//         // Apply this rotation to the rigidbody's rotation.
//         AgentRigidbody.MoveRotation(AgentRigidbody.rotation * turnRotation);
//     }
//     public override void OnActionReceived(ActionBuffers actions)
//     {
//         int move = actions.DiscreteActions[0];
//         int rotate = actions.DiscreteActions[1];

//         float moveSpeed = 5f;
//         float rotateSpeed = 180f;
        
//         if(move == 1)
//             Move(move, moveSpeed);
//         if(move == 2)
//             Move(-1, moveSpeed);
//         if(rotate == 1)
//             Turn(rotate, rotateSpeed);
//         if(rotate == 2)
//             Turn(-1, rotateSpeed);
        
//         // AddReward(0.05f - DistanceToGoal()/150);
//     }
    
//     public override void Heuristic(in ActionBuffers actionsOut)
//     {
//         ActionSegment<int> DiscreteActions = actionsOut.DiscreteActions;
//         if(Input.GetAxis("Vertical3") > 0)
//             DiscreteActions[0] = 1;
//         else
//             if(Input.GetAxis("Vertical3") < 0)
//                 DiscreteActions[0] = 2;
//             else
//                 DiscreteActions[0] = 0;
//         if(Input.GetAxis("Horizontal3") > 0)
//             DiscreteActions[1] = 1;
//         else
//             if(Input.GetAxis("Horizontal3") < 0)
//                 DiscreteActions[1] = 2;
//             else
//                 DiscreteActions[1] = 0;
//     }
//    private void OnTriggerEnter(Collider other) {
//         if(other.tag == "Goal")
//         {
//         SetReward(+1f);
//         Debug.Log("Success");
//         StartCoroutine(changeMaterial(sMaterial));
//         // Debug.Log(GetCumulativeReward());
//         EndEpisode();    
//         }
//         if(other.tag == "Bounds")
//         {
//             SetReward(-1f);
//             // Debug.Log("Failure distance: " + (-Math.Abs(DistanceToGoal())).ToString());
//             // Debug.Log(GetCumulativeReward());
//             Debug.Log("Failure");
//             StartCoroutine(changeMaterial(fMaterial));
//             EndEpisode();
//         }
//         Debug.Log(other.name);

//     }

//     private IEnumerator changeMaterial(Material m)
//     {
//         foreach(Transform child in bounds.transform)
//         {
//             child.gameObject.GetComponent<Renderer>().material = m;
//         }
//         yield return new WaitForSeconds(2);
//         foreach(Transform child in bounds.transform)
//         {
//             child.gameObject.GetComponent<Renderer>().material = bMaterial;
//         }
//     }

   
}