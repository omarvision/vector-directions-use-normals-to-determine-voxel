# vector-directions-use-normals-to-determine-voxel
Use the mesh face normal to calculate the coordinate of the voxel hit in a voxel grid.  Vector direction... normals???  "Normals" are vectors sized down to 1 unity unit, that are perpendicular to the mesh face from which they protrude.  You know what that means? that means I can use a normal to figure out what voxel position I just mouse clicked on in a voxel terrain.    I can use the normal combined with the hit point to get the coordinates of a voxel I just clicked on (and multiple the normal by a negative amount to go in the opposite direction)   Or I can use the normal and multiple by a positive amount to move forward into the neighboring voxel's coordinate.

YouTube:  https://youtu.be/xL1Jxe2-Wuw
