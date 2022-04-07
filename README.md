# No Name Serious Game Unity

## Introduction

This is the implementation of [NNSG](https://github.com/gabrielrossier/NNSG) in a Unity game. This readme only talks about Unity and how NNSG was implemented. Check the repository linked previously if you wish to know more about NNSG itself.

## Requirements

- Unity version 2020.3.24f

## Asset folder structure
### Folder naming convention
![image](https://user-images.githubusercontent.com/31761067/157824568-ca7dc80a-b62f-4a56-b3f6-672812288334.png)

To clearly separate assets inside the **Assets** folder, folders are prefixed with an underscore to make them appear on top of the list. This way we can clearly see what's our content and what's coming from imported assets. We could move / rename those assets but if we need to reimport them Unity will place them at the root of **Assets** folder.
The only exception is the **NNSG** folder which is also considered as an imported asset to make it easier to merge progress made on original repo while this project is setting up.

## Game structure

Unity serves here as a graphic representation of the simulation ran by NNSG. Everything works the same except for the Time. Even if a timer system was implemented in NNSG, it makes more sense to use Unity's time because it's one of it's core features and it works really fine. **Update()** method from **MonoBehavior** runs a timer and triggers **TickAll()** from **NNSG.Time**

## GUI

The whole GUI is updated each tick. In most GUI elements in games, it would be done through an event to avoid unnecessary calls and draws. But with NNSG, it is done on a regular basis and values have a high probability to change at each tick. 

The only exception is sliders because their values only change on sporadic event : user input.

## Village scene

The current scene serves no purpose except for embellishing the simulation and illustrating disasters.

## Improvements

### Balancing

Currently the game needs balancing because the simulation either reach a state were every person dies or reach exponential values which leads to reducing any risk to zero. It requires complex maths and takes a lot of time to tune and it wasn't the main goal of the project.

### Better visual feed back

With simple details like adding more building as population grows will provides a better feedback about how the simulation is doing and helps to interpret the values displayed in the GUI.

