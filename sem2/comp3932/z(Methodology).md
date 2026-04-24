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

A: (01->A), (02->C) = State A has two transition arcs.

B: (01,08->A), (07->C) = State B has two transition arcs.

C: (01->A), (00,03->B), (04->D) = State C has three transition arcs.

D: (01->A), (00,06->B), (05->C) = State D has three transition arcs.


# Results

Yes, your DFSM is **still entirely correct** conceptually, but to satisfy the strict mathematical definition of the 5-tuple $(Q, \Sigma, \delta, q_0, F)$ you just provided, we must make one important academic adjustment: **The Transition Function ($\delta$) must be total.**

In automata theory, a DFA cannot have "missing" arrows. The domain of $\delta$ is $Q \times \Sigma$, meaning there must be a defined mathematical output for *every* input symbol at *every* state. As we discussed previously, software engineering uses "implicit self-loops" for unhandled inputs, but in formal mathematics, we must explicitly declare those self-loops.

Here is the formal, 5-tuple mathematical definition of your VR Interaction DFSM, followed by the LaTeX code for a professional Transition Table.

### The Formal 5-Tuple Definition

Let $M = (Q, \Sigma, \delta, q_0, F)$ be the deterministic finite automaton driving the interaction framework, where:

**1. The States ($Q$)**
$Q = \{A, B, C, D\}$
Where $A = \text{IDLE}$, $B = \text{CLUTCHING}$, $C = \text{TRANSFORMING}$, and $D = \text{SCALING}$.

**2. The Alphabet ($\Sigma$)**
$\Sigma = \{00, 01, 02, 03, 04, 05, 06, 07, 08\}$
These represent the discrete, parsed hardware events (e.g., $01 = \text{Hardware Swap}$, $02 = \text{Initiate Grab}$).

**3. The Start State ($q_0$)**
$q_0 = A$
The system universally initializes in the IDLE state.

**4. The Accepting States ($F$)**
$F = \{A\}$
*Academic Caveat:* Traditional DFAs are "String Recognizers" that halt after reading a finite string to output *accept* or *reject*. A game engine FSM is a "Reactive Automaton" that runs continuously in an infinite loop (e.g., $60$ frames per second) until the application closes. However, for formal classification, $A$ (IDLE) serves as the accepting/resting state, as returning to $A$ indicates a safely concluded sequence of interactions where no physical meshes are left in an unstable state.

**5. The Transition Function ($\delta$)**
$\delta : Q \times \Sigma \rightarrow Q$
To ensure the function is total, all inputs that do not trigger a state change explicitly map back to the current state (the self-loops).

### The LaTeX Transition Table
In automata theory, $\delta$ is traditionally displayed as a Transition Table rather than a list of coordinates. This provides a highly readable, matrix-like view of your logic.

Here is the LaTeX code to generate your formal $\delta$ table. *(Note: The $\rightarrow$ denotes the start state, and the $*$ denotes the accepting state, which is standard DFA notation).*

```latex
\begin{table}[htbp]
    \centering
    \caption{Formal Transition Function ($\delta$) for the Interaction FSM}
    \label{tab:dfa_transitions}
    % 'c |' creates a vertical line separating the states from the inputs
    \begin{tabular}{c | c c c c c c c c c}
        \toprule
        \multirow{2}{*}{\textbf{State ($Q$)}} & \multicolumn{9}{c}{\textbf{Input Alphabet ($\Sigma$)}} \\
        \cmidrule{2-10}
        & \textbf{00} & \textbf{01} & \textbf{02} & \textbf{03} & \textbf{04} & \textbf{05} & \textbf{06} & \textbf{07} & \textbf{08} \\
        \midrule
        $\rightarrow *A$ & $A$ & $A$ & $C$ & $A$ & $A$ & $A$ & $A$ & $A$ & $A$ \\
        $B$              & $B$ & $A$ & $B$ & $B$ & $B$ & $B$ & $B$ & $C$ & $A$ \\
        $C$              & $B$ & $A$ & $C$ & $B$ & $D$ & $C$ & $C$ & $C$ & $C$ \\
        $D$              & $B$ & $A$ & $D$ & $D$ & $D$ & $C$ & $B$ & $D$ & $D$ \\
        \bottomrule
    \end{tabular}
\end{table}
```

### Why this elevates your dissertation:
If you include this formal breakdown in your report, you bridge the gap between abstract computer science theory and applied software engineering. You demonstrate that you did not just "hack" a script together in Unity, but engineered a mathematically verifiable, closed-loop automaton that is theoretically sound and safe from undefined behaviour.