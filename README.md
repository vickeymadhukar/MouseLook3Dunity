# mouselook Unity Script

The "mouselook" script provides a first-person camera control system in Unity, responding to mouse input for a smooth and interactive experience. It includes sensitivity settings for both overall movement and mouse input.

## How to Use

### 1. Download Script
Download the "mouselook.cs" script and add it to your Unity project's "Scripts" folder.

### 2. Attach Script
- Attach the script to the player's camera GameObject.
- Assign the player's body transform to the "Body" field in the inspector.

### 3. Adjust Sensitivity
Fine-tune the `sensi` and `mousesensi` variables in the inspector for desired movement and mouse input sensitivity.

### 4. Playtest
Run your Unity scene, and navigate the first-person character using the mouse.

## Script Details

### Variables
- **sensi:** Overall movement sensitivity.
- **mousesensi:** Mouse input sensitivity.
- **xrotation:** Vertical camera rotation angle.

### Methods
- **Start():** Initialization method (currently empty).
- **Update():** Called every frame, processes mouse input, and updates camera rotations accordingly.

### Camera Movement
- Vertical rotation is limited between -90 and 90 degrees to prevent unnatural camera angles.
- Horizontal rotation is applied to the body transform, allowing the player to look around.

## Example
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    public float sensi = 100f;
    public float mousesensi = 10f;
    float xrotation = 0f;
    public Transform body;

    void Update()
    {
        float mousex = Input.GetAxis("Mouse X") * mousesensi * Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y") * mousesensi * Time.deltaTime;
        xrotation -= mousey;
        xrotation = Mathf.Clamp(xrotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xrotation, 0f, 0f);
        body.Rotate(Vector3.up * mousex);
    }
}
