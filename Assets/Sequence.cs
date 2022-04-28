using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Sequence : MonoBehaviour
{
    public List<GameObject> prefabs;
    int currentId = -1;
    GameObject currentObject;

    public InputAction nextAction;
    float timeInState = 0;

    enum State{
        Active,
        Waiting
    }
    State state = State.Waiting;

    // Start is called before the first frame update
    void Start()
    {
        nextAction.Enable();

        Create();
    }

    void Update(){

        timeInState += Time.deltaTime;

        if(nextAction.WasPressedThisFrame())
        {
            Fall();
        }

        if(state == State.Waiting && timeInState > 2)
        {
            Create();
        }
        
    }

    void Fall(){

        // makes it fall, if exists
        if(currentObject != null){
            
            MobilePhysics physics = currentObject.GetComponent<MobilePhysics>();
            

            if(physics != null)
            {
                physics.Fall();
            }
            else{
                Destroy(currentObject);
            }

        }

        SetState(State.Waiting);
    }

    void Create()
    {
        // next id
        currentId += 1;
        if( currentId >= prefabs.Count )
            currentId = 0;


        // creates a new one
        GameObject prefab = prefabs[currentId];
        currentObject = Instantiate(prefab); // add to the scene


        SetState(State.Active);
    }

    void SetState(State newState)
    {
        state = newState;
        timeInState = 0;
    }
}
