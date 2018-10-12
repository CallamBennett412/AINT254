using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {
    
    private GameObject[] m_dotArray;

    [SerializeField]
    private GameObject m_prefabDot;
    
    private Transform m_transform;

    private Camera cam;

    private Vector3 m_Direction;
    
    private float m_gravity = 9.81f;
    
    public float force = 10.0f;

    private Rigidbody m_projectRigidBody;


	// Use this for initialization
	void Start ()
    {
        m_transform = transform;
        cam = Camera.main;
        m_projectRigidBody = m_transform.GetComponent<Rigidbody>();

        m_dotArray = new GameObject[10];

        for (int i = 0; i < m_dotArray.Length; i++)
        {
            GameObject tempObject = Instantiate(m_prefabDot);

            m_dotArray[i] = tempObject;

            m_dotArray[i].SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 projectilePos = cam.WorldToScreenPoint(m_transform.position);
            projectilePos.z = 0;
            m_Direction = (Input.mousePosition - projectilePos).normalized;

            Aim();
        }

        if (Input.GetMouseButtonUp(0))
        {
            m_projectRigidBody.AddForce(m_Direction * force, ForceMode.Impulse);

            for (int i = 0; i < m_dotArray.Length; i++)
            {
                m_dotArray[i].SetActive(false);
            }
        }
        
    }


    private void Aim()
    {
        float sx = m_Direction.x * force;
        float sy = m_Direction.y * force;

        for (int i = 0; i < m_dotArray.Length; i++)
        {
            float t = i * 0.1f;

            float dx = sx * t;

            float dy = ((sx * t) - (0.5f * m_gravity * t * t));

            m_dotArray[i].transform.position = new Vector3(m_transform.position.x + dx, m_transform.position.y + dy, m_transform.position.z);

            m_dotArray[i].SetActive(true);
        }


    }
}
