
# This contains the flowchart of the gameplay loop

#### The flow chart will be done using the mermaid extension

#### Here are a few extensions that are needed:

```
- Markdown Preview Mermaid Support
- Marmaid Markdown Syntax
- Flowchart
- Live Share
```

```mermaid
---
title: Basic Gameplay Loop
---
flowchart TD
    start[Start of the game]
    ending[End of the game]
    choice[Have you played this game before?]
    tutorial[Tutorial Sequence]
    gameplay-loop[Gameplay Loop]

    gameplay-start[Start of the gameplay]
    early-game["`
    Early Game (1 to 2 mins) :
    - Zombies come out after a little bit of time
    - Zombies come out slowly
    - Player starts planting Sun Flowers
    `"]
    mid-game["`
    Mid Game (3 to 8 mins) :
    - Zombies start ramping up in numbers
    - A few wave that get bigger and bigger
    - Player starts planting his main defence
    `"]
    late-game["`
    Late Game (9 to 10 mins) :
    - Player has finished set up their defence
    - Final wave which is the biggest wave
    `"]
    brain-eaten[Zombie reached house]
    gameplay-end[End of the gameplay]

    start --- choice
    choice --- tutorial
    choice --- gameplay-loop
    tutorial --- gameplay-loop
    gameplay-loop --- ending

    gameplay-start --- early-game
    early-game --- mid-game
    mid-game --- late-game
    late-game --- gameplay-end
    early-game --- brain-eaten
    mid-game --- brain-eaten
    late-game --- brain-eaten
    brain-eaten --- gameplay-end
```