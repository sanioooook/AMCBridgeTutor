# DOES POINT BELONG TO 3D SEGMENT
### **Description**
There are a point and a segment in 3D space. Check whether the point belongs to the segment. A point belongs to a segment if the distance between them is less than `1e-8`.
### **Input:**
Nine reals, the 3D coordinates of:
1. The given point.
2. Two ends of the segment.
### **Output:**
An integer:
- Either one if the point belongs to the segment,
- Or zero if not.

Project code: DoesPointBelongTo3DSegment
### **Examples:**
Input:

`0.0 1.0 0.0 0.0 3.0 0.0 0.0 2.0 0.0`

Output:

`0`

Input:

`0.0 1.0 0.0 0.0 0.0 0.0 0.0 2.0 0.0`

Output:

`1`
