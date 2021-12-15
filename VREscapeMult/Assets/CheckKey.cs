// Copyright(C) Fyware SC - All Rights Reserved
// Unauthorized copying of this project or any file, via any medium is strictly prohibited
// Proprietary and confidential.
// If you gain access to this project or any file and you are not the recipient, 
// it is hereby notified that, in the event of any disclosure, reproduction, 
// distribution or any action in relation to the content of this project, it is strictly prohibited and could be illegal. 
// If you have received this in error, please notify us immediately by replying to contact@fyware.com and then delete it from your system.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckKey : MonoBehaviour
{
#region Static Variables

	public string tag;
    public Level5Manager level5Manager;
    public Animator pressure;

#endregion

#region Public Variables

	

#endregion

#region Private Variables

	

    #endregion

#region MonoBehaviour Callbacks
	// Awake is called when the script instance is being loaded
    void Awake()
    {
       
    }
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

#endregion

#region Script Methods

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == tag)
        {
            switch(tag)
            {
                case "KeyA":
                print("Contenedor 1");
                level5Manager.key++;
                Destroy(other.gameObject);
                Destroy(gameObject);
                break;

                case "KeyB":
                print("Contenedor 2");
                level5Manager.key++;
                Destroy(other.gameObject);
                Destroy(gameObject);
                break;

                case "KeyC":
                print("Contenedor 3");
                level5Manager.key++;
                Destroy(other.gameObject);
                Destroy(gameObject);
                break;

                 case "KeyD":
                print("Contenedor 3");
                level5Manager.key++;
                pressure.SetBool("KeyOn",true);
                break;

                 case "KeyE":
                print("Contenedor 3");
                level5Manager.key++;
                pressure.SetBool("KeyOn",true);
                break;
            }
        }
    }

    

#endregion
    
}