# Final Project README

The Gang: _Fan Jiang, Jason Lee, Trevor Maco_

Element       | Element Requirements | Date
------------- | ---------------------|-----
Interruptible Coroutine  | Animations, including combat, movement, power ups{COD nuke,etc.}, map changes |
Game Mechanic 1  | The core idea stems from a capture the flag model. The point system and objective of the game to move the flag from one side to another is a core mechanic. |
Game Mechanic 2  | Power ups and obtaining them by completing puzzles is another core mechanic. The power ups will affect the state of the game/character depending on the power up. |
Sound Effects    | We will gather free online sound effects and or produce sounds ourselves. Some sounds may include: players dropping, players attack, players die, etc.|
Animation        |We will have fixed animation as well as dynamic animation. For example, flags will constantly fly in the air; the terrain will change with smooth animation when a trigger gets pulled, etc.|
Hierarchical Modeling | Most likely the character model (arms/feet moving and set as children to the torso), power ups will be layered to include animations and sounds, etc. |
Camera dynamics | We will make the camera in third person, and there will be one camera following each player.|
Collision Detection | We will utilize collision detection for player interactions. Specifically, when players attack, push each other, collision happens, which will lead to reasonable physical results.|
Multiple inputs | Movement controls, puzzle interactions, jumping, etc |
Puzzle          | Puzzles which provide power ups upon successfully completing them or anti power ups if the player fails the puzzle |
Creativity      | This game is primarily inspired by Fall Guys and Among Us. We came up with most of the game mechanisms and puzzles.|

## Stream of conscious:

- Map
  - terrain
  - islands
  - bases
  - dynamic pathway setup (possibly static)
- Model designs (base, flag, power ups?)
- Core logic:
  - Point system (each flag capture is 1 point)
  - HP
  - Respawning
- Puzzles (2-3 unique puzzles) -> among us puzzles vibe (nothing too complicated)
- Character design (low res, not complicated)
- Animations (combat, movement, power ups{COD nuke,etc.}, map changes)
- Collision detection (slapping people, boulder, etc.)
- Camera (3rd person)
- Controls (movement, interact with puzzles/powerups, jumping) 

- Traps
  - Power ups-cod nuke, enhanced range, more dmg, dmg resistance, hp boost, increased movement speed, super jump, knockback resistance, knockback boost, attack speed boost, flashbang, claymores, 
  - anti-powerups(when you fail the hardest puzzle puzzle)-0 dmg nerf, no jump, increased knockback to self, increased dmg intake, lower hp
- Puzzles:
  - connect wires
  - flip certain switches to light up all green
  - rearrange numbers in 3x3 grid
  - CHALLENGE PUZZLE-> hardcore parkor in the center of the map, if you fail this and die in the center you get an anti power up
-Multiplayer aspect/networking->connecting players to same lobby->someone generates lobby and people can join open lobby

## ASSETS/SOUNDS 
### Responsible:
- Base creation->				-Trevor Maco
- Dynamic pathways/layout->			-Jason Lee
- Islands->					-Jason Lee
- Puzzles->					-Jason Lee
- Resources(flag, powerups, weapons)->	-Trevor Maco
- Random kill sound effect on death->		-Jason Lee
- Announcer for start/end/capture->		-Jason Lee
- Skybox/HellBox->				-Jason Lee
- Traps->					-Fan Jiang
- Attack sounds->				-Fan Jiang
- Character models->				-Trevor Maco
- Movement animation->			-Trevor Maco
- Map change animation->			-Fan Jiang
- Trap animation->				-Fan Jiang
- Puzzle animation->				-Fan Jiang
- Resource use/pickup animation->		-Fan Jiang
- UI->						-Trevor Maco
- Networking->					-Trevor Maco
- Game rules and state counter/enforcer->	-Fan Jiang

### Rough Schedule:
- [ ] Employs an interruptible coroutine (11/21/20)
- [ ] Includes sound effects (11/21/20)
- [ ] Game mechanic 1 (11/28/20)
- [ ] Game mechanic 2 (12/5/20)
- [ ] Animation (11/21/20)
- [ ] Hierarchical modeling (11/14/20)
- [ ] Camera dynamics (11/14/20)
- [ ] Collision detection (11/28/20)
- [ ] Multiple inputs (11/14/20)
- [ ] A puzzle (11/28/20)
- [ ] Creativity (11/10/20)
