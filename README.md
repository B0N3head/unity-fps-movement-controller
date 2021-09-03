# Unity Fps Movement Controller
A simple to setup easy to edit unity fps movement controller using rigidbodies in c#. Feel free to use it if you'd like!

### Features
- Walking
- Mouse lock
- Sprinting
- Crouching (toggle/hold) (midair/on ground only)
- Jumping
- Labled inspector
- Configurable speeds for crouching, walking, sprinting etc.
- Smoothing of the camera, controlled by the mouse
- Clamped look directions
- No slippery movement
- Slower movement while jumping and extra gravity
- Configurable keys for actions
- Fast auto setup in one button button push
  - Creates and sets up rigidbody
  - Creates and sets up camera 
  - Sets gravity to -19

### Controls
This script is currently setup with the following controls.
These are all configurabe in the editor (don't require coding)

| Key(s) | Action |
| ------ | ------ |
| WSAD | Simple movement |
| Space | Jump |
| Z | Crouch |
| Q | Lock/Unlock Mouse |

### How to setup the character

Download and add the files to your assets folder

![alt text](https://raw.githubusercontent.com/B0N3head/unity-fps-movement-controller/main/readmeAssets/1.PNG)

Add a capsule to your scene

![alt text](https://raw.githubusercontent.com/B0N3head/unity-fps-movement-controller/main/readmeAssets/2.PNG)

Add the Player Movement script through Component -> Player Movement and Camera Controller

![alt text](https://raw.githubusercontent.com/B0N3head/unity-fps-movement-controller/main/readmeAssets/3.PNG)

Click the "Setup Player" button

![alt text](https://raw.githubusercontent.com/B0N3head/unity-fps-movement-controller/main/readmeAssets/4.PNG)

Done, this is what you should be left with

![alt text](https://raw.githubusercontent.com/B0N3head/unity-fps-movement-controller/main/readmeAssets/5.PNG)

