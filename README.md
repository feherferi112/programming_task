# Programming_task
## Exercise solutions for dGB Earth Sciences

This repository contains solutions to tasks involving the implementation of classes and methods to handle seismic data structures and related computations.

### Task 3: Position at a Given Distance Along the Track
Implemented the function getPos(float distanceAlongTrack) for the WellTrack class to compute the position at a specified distance along the track.
Assumptions:

The given distanceAlongTrack can be arbitrary, which means it might not align exactly with any specific position in the track.
In such cases, I interpolated the position between two consecutive points to determine the result accurately.

### Task 4: Distance Along the Track for a Given Position
Implemented the function getDistanceAlongTrack(Coord3D pos) for the WellTrack class to compute the cumulative distance along the track up to a given position. This implementation assumes that the positions in the track are sorted.

### Handling Unsorted 3D Position Arrays
Although it wasn't explicitly required in the task description, I considered the possibility of unsorted 3D position arrays. Unfortunately, due to time constraints, I couldn't fully implement this functionality.
However:
I created a CoordsUnsorted class as a placeholder for handling such cases.
The class includes comments describing the approach to sort and process unsorted 3D positions before performing the computations. This serves as a guide for future implementation.
