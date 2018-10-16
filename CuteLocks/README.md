# CuteLocks

This package contains a cute lock animation and related files.  
It uses Vector Graphics Package (at least 1.0.0-preview-2.0).  
The main struggle in this project is properly animating gameobject/s changing position, rotation, scale and sprite values.
Default implementation (scene) shows straightforward implementation after the struggle.  
Proper implementation (scene) shows/will show the 'correct' way.

## Requirements for the proper implementation  

* Hand movement and click animations should be separate animations.
* There should be direct transition from the state which uses hand movement animation to the state which uses click animation.
* Click animation should play 5 times.
  
These are the only requirements, you can change anything however you like.  
It would be best if you explain additional changes for public knowledge.
