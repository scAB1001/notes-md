# Plan

Using these inputs:
00: Tracking Loss Override
01: Hardware Swap Reset
02: Initiate Grab
03: Release to Clutch
04: Initiate Bimanual Scaling
05: Partial Release (Drop to Monomanual)
06: Full Release (Drop to Clutch)
07: Re-engage Grab
08: Abandon Object

Let the states be aliased as follows: IDLE (A), CLUTCHING (B), TRANSFORMING(C), SCALING (D):

Following the format of transitions: (input1 from current state->resulting state after input1), (input2,input3 from current state->resulting state after input2,input3), etc.

The following define all the connections between states:

q_0: (01->q0), (02->q_2) = State A has two transition arcs.

q_1: (01,08->q0), (07->q_2) = State B has two transition arcs.

q_2: (01->q0), (00,03->q_1), (04->q_3) = State C has three transition arcs.

q_3: (01->q0), (00,06->q_1), (05->q_2) = State D has three transition arcs.

