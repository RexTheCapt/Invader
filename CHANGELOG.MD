# Changelog

## 23/11/18

### Updated Unity from 2018.2.16f1 to 2018.2.17f1

### Added features
- Found an [ReverseNormal](http://wiki.unity3d.com/index.php?title=ReverseNormals) script that let's you see the insides of a object.

### Changes
- Moved every scripts starting on *Bullet* into *BulletScripts*.
- Redone the entire nuke object from multiple bullets to an sphere.
- Moved every scripts starting on *Player* into *PlayerScripts*.
- Changed script name *Nuke* to *NukeScript*.
- Added some text formats to the changelog.
- Created an nuke prefab.
- Renamed scene *SampleScene* to *Game*.
- The nuke now expands and destroys every enemies in it's path.
- When the nuke reaches the size 100 it get's deleted.
- Can now edit the Nuke's expansion speed.
- Created and added a material to the Nuke.

## 22/11/18

### Added features
- [README.MD](README.MD) and [CHANGELOG.MD](CHANGELOG.MD).
- Nuke bullet.
- Shield bullet.
- Auto enemy spawn, enemies spawns automatically now.

### Changes
- Reformatted the changelog

### Fixes
- Fixed a bug where the special bullet object was not destroyed.
- Fixed a bug where the shield did not get properly removed from the world
