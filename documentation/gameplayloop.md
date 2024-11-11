
# This contains the flowchart of the gameplay loop
## The flow chart will be done using the mermaid extension

```mermaid
---
title: Basic Gameplay Loop
---
flowchart TD
    start[Start of the game]
    ending[End of the game]
    choice[Have you played this game before?]
    tutorial[Tutorial Sequence]
    gameplay[Gameplay Loop]

    start --- choice
    choice --- tutorial
    choice --- gameplay
    tutorial --- gameplay
    gameplay --- ending
```