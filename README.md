# HtF25-Minecraft

The asset packages were created with Unity 2018.4, and tested with 2019.2.

## Getting Started

Create a new project in Unity 2018.4
Install the Probuilder and Progrids packages: 
- In Unity, go to Window > Package Manager
- Click Advanced > Show preview packages
- Search for ProBuilder and click Install
- Search for ProGrids and click Install

Now, if you want to start from scratch, follow along with the instructions from your mentor.

To get a jumpstart, import any of the Asset Packages:
- In Unity, click Assets > Import Package > Custom Package...
- Choose one of the numbered Unity packages, i.e. HtF-Package01.unitypackage
- (More info about the contents of these packages can be found below)

After importing the package, we need to change some settings:
- In Unity, click Edit > Project Settings > Tags and Layers
- Click the Slider icon in the top right of the window, and double click the TagManager preset
- In Unity, click Edit > Project Settings > Physics
- Click the Slider icon in the top right of the window, and double click the PhysicsManager preset
- (This will set up the layers and physics settings that are used in the project)

## Contents of Asset Packages

### HtF-Package01.unitypackage

Scene01, which includes a simple first person character controller, floor, and trigger which resets the position of a falling character back to vector3.zero.
(For a quick way to get started)

### HtF-Package02.unitypackage

Scene02, which includes the same character controller, plus scripts which allow for the placement and destruction of simple blocks. Plus a simple UI image which acts as a crosshair for placement.
(To show off the potential of a Minecraft type project)

### HtF-Package03.unitypackage

Scene03, which includes an inventory scipt, allowing the placement of multiple types of blocks (some assembly required), and puts a limit on the number placed, which can be replenished by picking up broken blocks. Blocks now also have health which can change the amount of time it takes to destroy them, and spawn particle effects during mining.

## More things to try

GameObjects can easily be skinned using ProBuilder.
Levels can be created quickly using ProBuilder.
The Respawn script can be placed on Lava blocks to create traps.

## Links

[https://www.minetest.net/](Minetest) - An open source MineCraft type project. There are lots of downloadable textures here.
[https://docs.unity3d.com/Packages/com.unity.probuilder@4.2/manual/index.html](ProBuilder Manual)
[https://docs.unity3d.com/Packages/com.unity.progrids@3.0/manual/index.html](ProGrids Manual)
