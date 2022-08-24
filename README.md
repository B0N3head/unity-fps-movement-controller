# Unity Fps Movement Controller
A simple to setup easy to edit unity fps movement controller using rigidbodies in c#. Feel free to use it if you'd like!

### Features
- [x] Walking/Sprinting
- [x] Jumping
- [x] Mouse lock
- [x] Crouching 
	- [x] Can be configured to be toggle or hold
	- [x] Config to allow to crouch in midair or on ground only
- [x] Labled inspector
- [x] Configurable speeds for crouching, walking, sprinting etc.
- [x] Variable smoothing of the camera, controlled by the mouse
- [x] Clamped look directions
- [x] Quick and snappy movement
- [x] Slower movement while jumping and extra gravity
- [x] Configurable keys for all actions
- [x] Fast auto setup in one button button click
	- [x] Creates and sets up rigidbody
	- [x] Creates and sets up camera 
	- [x] Sets unity physics gravity to -19
		- [ ] Ask user if they want to set custom gravity
	- [ ] Create floor plane for character to stand on
  

### Controls
This script is currently setup with the following controls.
These are all configurabe in the editor (don't require coding)

| Key(s) | Action |
| ------ | ------ |
| WSAD | Simple character movement |
| Space | Jump |
| Z | Crouch (CTRL in editor runs hotkeys) |
| Q | Lock/Unlock Mouse (For in editor changes)|

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

