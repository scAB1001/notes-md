## Introduction

The Implementation chapter is also far too long. Including comments and all the latex code like \section and \table, it sits at:
- words: 4979
- sentences: 853
- paragraphs: 394

The issue is actually the page count as this spans 12 pages of the remaining 7 after the Methodolofu. Font, font size, page margins and linespacing are all fixed.

Similar fixes apply as before:
- Header number and structure (currently at 24)
- Relevance
- Verbosity
- Padding and lengthy, unnecessary information/words

This chapter, along with the remaining will involve far more visuals (or references to them) by nature of their content.

## Requirements
We are aiming for an exceptional, 80% and higher grade for this project. To do this in the Implementation chapter, the following requirements alongside the marking rubric must be consistently met:

- Building off of previous chapters, not repeating content
- Design of the solution, supported by justification of choices made, linking back to the literature and potentially further critical analysis
- Evidence that software was properly managed using a version control system, and followed standard good practice in design and structure.
- Evidence of data collection and preparation.
- Schematic diagrams and description of overall software architecture
- Details of the project management approach that was used, eg. sprints
- Clauses must not exceed unreadble lengths.
- Paragraphs and sections must flow but this does not mean lengthy connecting paragraphs, implicit connections are also permitted when obvious.
- This chapter must not definitively forward reference, i.e. talk about the results and discussion yet only implementation. It must approach this from an implementation position, naturally being picked up on in the Results chapters.
- Where appropriate, visuals are used and/or refferred to. If they do not exist, they should be created.
- Key parts of the literature review must be justifiably linked to the proposed solution/system design here
- Reduce where possible, cover the core functionality the most

### The current content's page for the recent Literature Review chapter and the old Implementation chapter
4 Implementation and Validation
4.1 Hardware Setup
4.2 Software Architecture
4.3 Trial Orchestration
4.3.1 Task Constraint Application via Bitmask
4.3.2 Spatial Dwell Validation
4.4 Telemetry Pipeline
4.4.1 Polling and Memory-Buffered Export
4.4.2 Clutch Count Accumulation
4.4.3 Welford Online Variance
4.5 Gesture Recognition Engine
4.5.1 Formal Definition of the Interaction Automaton
4.5.2 Objective Performance Metrics
4.5.3 Subjective Metrics
4.5.4 Statistical Analysis Plan
4.6 Kinematic Mathematics
4.7 Telemetry and Data Logging
4.8 User Interface and Visual Feedback
4.9 System Validation
4.9.1 Test Architecture and Continuous Integration
4.9.2 Coverage and Limitations
4.9.3 Unit Testing
4.9.4 Integration Testing
4.9.5 Pilot Study (N=5)
4.9.6 Main User Study (N=10-20)

### Available Visuals (appendix)

% % % % % % % % % % % % % % % % % % % %
% TABLE: SUBJECT DATA COLLECTION
% % % % % % % % % % % % % % % % % % % %
\begin{table}[htbp]
    \caption{Classification of Data Types Collected During User Evaluation}
    \label{tbl:form_data_types}
    \centering
    \begin{tabularx}{\textwidth}{@{} l >{\hsize=0.9\hsize}X
                                        >{\hsize=1.1\hsize}X @{}}
        \toprule
        \textbf{Instrument} & \textbf{Raw Item Data Type} &
        \textbf{Aggregated Metric Treatment} \\
        \midrule
        \textbf{RTLX} &
            Discrete Ordinal (1--20 integer scales) &
            Quantitative Interval (mean subscale score) \\ \addlinespace
        \textbf{SUS} &
            Categorical Ordinal (5-point Likert scales) &
            Quantitative Interval (0--100 composite score) \\ \addlinespace
        \textbf{Open Feedback} &
            Qualitative Unstructured (free-text) &
            Categorical Nominal (post-hoc thematic tags) \\
        \bottomrule
    \end{tabularx}
\end{table}

% % % % % % % % % % % % % % % % % % % %
% TABLE: Participant characteristics
% % % % % % % % % % % % % % % % % % % %
\begin{table}[htbp]
    \caption{Baseline Characteristics and Demographics of Study
    Participants ($n = 8$)}
    \label{tbl:participant_characteristics}
    \centering
    \begin{tabularx}{\textwidth}{@{} X l @{}}
        \toprule
        \textbf{Characteristic} & \textbf{Value} \\
        \midrule
        \multicolumn{2}{@{}l}{\textbf{Demographics}} \\
        Age in years, Mean (SD) & 22.9 (2.03) \\
        Age range (Min--Max)    & 21--28 \\
        Sex, $n$ (\%)           & \\
        \quad Male              & 5 (62.5\%) \\
        \quad Female            & 3 (37.5\%) \\
        Handedness, $n$ (\%)    & \\
        \quad Right-handed      & 7 (87.5\%) \\
        \quad Left-handed       & 1 (12.5\%) \\
        \addlinespace
        \multicolumn{2}{@{}l}{\textbf{Professional Background}} \\
        Domain Expertise, $n$ (\%) & \\
        \quad Surgical / Medical & 3 (37.5\%) \\
        \quad Non-surgical       & 5 (62.5\%) \\
        \addlinespace
        \multicolumn{2}{@{}l}{\textbf{Prior Technology Experience}} \\
        VR / XR Experience, $n$ (\%) & \\
        \quad None                        & 2 (25.0\%) \\
        \quad Novice (1--5 hours)         & 4 (50.0\%) \\
        \quad Experienced ($>$5 hours)    & 2 (25.0\%) \\
        Video Gaming Frequency, $n$ (\%) & \\
        \quad Daily             & 1 (12.5\%) \\
        \quad Weekly            & 3 (37.5\%) \\
        \quad Rarely / Never    & 4 (50.0\%) \\
        Specific Modality Exposure, $n$ (\%) & \\
        \quad Prior VR Controller Use & 4 (50.0\%) \\
        \quad Prior Hand-Tracking Use & 1 (12.5\%) \\
        \bottomrule
    \end{tabularx}
    \vspace{1ex}
    \raggedright
    \footnotesize{\textit{Note:} SD = Standard Deviation; VR = Virtual
    Reality; XR = Extended Reality.}
\end{table}

% % % % % % % % % % % % % % % % % % % %
% FIGURE: CONSORT TRIAL FLOW
% % % % % % % % % % % % % % % % % % % %
\begin{figure}[htbp]
\centering
\begin{tikzpicture}[
    node distance = 0.6cm,
    box/.style     = {rectangle, draw, rounded corners,
                      minimum width=7cm, minimum height=1.2cm,
                      text centered, align=center,
                      font=\small, fill=white},
    arrow/.style   = {-{Stealth}, thick},
]
\node[box] (assessed)
    {Assessed for eligibility ($n = 8$)};
\node[box, below=of assessed] (excluded)
    {\textbf{Excluded} ($n = 0$)\\[2pt]
     {\footnotesize No participants failed inclusion criteria}};
\node[box, below=of excluded] (enrolled)
    {\textbf{Enrolled} ($n = 8$)};
\node[box, below=1.0cm of enrolled] (cond1)
    {\textbf{Condition 1: Controller Tracking}\\[2pt]
     Allocated and received ($n = 8$)};
\node[box, below=0.8cm of cond1] (cond2)
    {\textbf{Condition 2: Hand Tracking}\\[2pt]
     Allocated and received ($n = 8$)};
\node[box, below=0.8cm of cond2] (followup)
    {\textbf{Follow-up}\\[2pt]
     Discontinued: 0\quad Protocol deviations: 0};
\node[box, below=0.8cm of followup] (analysed)
    {\textbf{Analysed} ($n = 5$)\\[2pt]
     {\footnotesize Excluded from analysis ($n = 3$):}\\[1pt]
     {\footnotesize Equipment failure --- see
     Section~\ref{sec:exclusion_criteria}}};
\draw[arrow] (assessed)  -- (excluded);
\draw[arrow] (excluded)  -- (enrolled);
\draw[arrow] (enrolled)  -- (cond1)
    node[midway, right, font=\footnotesize] {Fixed order crossover};
\draw[arrow] (cond1)     -- (cond2);
\draw[arrow] (cond2)     -- (followup);
\draw[arrow] (followup)  -- (analysed);
\node[left=0.4cm of assessed, font=\small\bfseries] {Enrolment};
\node[left=0.4cm of cond1,    font=\small\bfseries] {Allocation};
\node[left=0.4cm of followup, font=\small\bfseries] {Follow-up};
\node[left=0.4cm of analysed, font=\small\bfseries] {Analysis};
\end{tikzpicture}
\caption{CONSORT Pilot and Feasibility Trial Flow Diagram
\citep{Eldridge2016CONSORTTrials}. The fixed-order crossover design
administered both conditions to all enrolled participants ($n = 8$);
three were excluded post-hoc on equipment failure grounds
(Section~\ref{sec:exclusion_criteria}).}
\label{fig:consort}
\end{figure}

% % % % % % % % % % % % % % % % % % % %
% FIGURE: Abstract design FSM diagram
% % % % % % % % % % % % % % % % % % % %
\begin{center}
    \includegraphics[width=0.55\linewidth]{images/architecture_design/design_fsm.png}
    \captionof{figure}{Abstract design of the FSM using core action inputs; the complete DFA is shown in Figure~\ref{fig:dfa_formal}.}
    \label{fig:dfa_design}
\end{center}

% % % % % % % % % % % % % % % % % % % %
% MODALITY USAGE TABLE
% % % % % % % % % % % % % % % % % % % %
\begin{table}[htbp]
\centering
% 'l' for the left-aligned Action column, 'X' for two equal-width, text-wrapping columns
\begin{tabularx}{\textwidth}{
    @{} l >{\hsize=0.95\hsize}X >{\hsize=1.05\hsize}X @{}
}
    \toprule
    \textbf{Action} & \textbf{Using the Varjo Controllers} & \textbf{Using Bare Hands} \\
    \midrule
    Grab &
        Squeeze and hold the side grip button using your middle or ring finger. &
        Pinch your index finger and thumb together, close the other fingers and hold the pose. \\ \addlinespace
    Move &
        While holding the grip button, physically move your arm to drag the model. &
        While holding the pinch, move your hand through the air to drag the model. \\ \addlinespace
    Rotate &
        While holding the grip button, twist your wrist to orient the model. &
        While holding the pinch, twist your wrist to orient the model. \\ \addlinespace
    Scale &
        Push the thumbstick UP to enlarge the model, or DOWN to shrink it. &
        While holding the pinch, pinch with the other hand and pull this hand away to enlarge or push it closer to shrink. \\
    \bottomrule
\end{tabularx}
\caption{Participant Instruction Guide: How to Interact with the Target Model}
\label{tbl:modality_user_guide}
\end{table}

% % % % % % % % % % % % % % % % % % % %
% FIGURE: Software Milestone diagram
% % % % % % % % % % % % % % % % % % % %
\begin{center}
    \includegraphics[width=1\linewidth]{images/architecture_design/system_overview.png}
    \captionof{figure}{System Overview organised by Milestone and its Key deliverables, following \citeauthor{Sommerville2016GlobAlEdiTioN}'s hybrid release and sprint approach.}
    \label{fig:sys_overview}
\end{center}


% % % % % % % % % % % % % % % % % % % %
% FIGURE: UML component diagram
% % % % % % % % % % % % % % % % % % % %
\begin{center}
    \includegraphics[width=1\linewidth]{images/architecture_design/uml_component_detailed.png}
    \captionof{figure}{UML Component Diagram illustrating the decoupled interaction architecture. The \texttt{InteractionOrchestrator} consumes only the abstract \texttt{BaseInteractionProvider} contract, ensuring both modalities traverse identical transformation and telemetry pipelines.}
    \label{fig:uml_detailed}
\end{center}

% % % % % % % % % % % % % % % % % % % %
% TASK, TASK NAME, DoF, CONSTRAINS TBL
% % % % % % % % % % % % % % % % % % % %
\begin{table}[htbp]
    \centering
    % p{0.8cm} for Task, p{2.8cm} for Name, p{3.4cm} for DoF, and X for the wrapping description
    \begin{tabularx}{\textwidth}{@{}
        p{0.8cm}
        >{\raggedright\arraybackslash}p{2.7cm}
        >{\raggedright\arraybackslash}p{2.8cm}
        X
        @{}}
        \toprule
        \textbf{Task} & \textbf{Task Name} & \textbf{Active DoF} & \textbf{Kinematic Description} \\
        \midrule

        \textbf{T1} & Pure Translation & 3 DoF \newline (Position) &
        Movement is strictly confined to the spatial $X$, $Y$ and $Z$ axes. All rotational and scaling inputs from the user are mathematically locked. \\
        \addlinespace

        \textbf{T2} & Pure Rotation & 3 DoF \newline (Orientation) &
        Interaction is restricted to Pitch, Yaw, and Roll. Spatial translation is locked, the center of the target mesh stays in place while the user orientates it. \\
        \addlinespace

        \textbf{T3} & Translation and Rotation & 6 DoF \newline (Position + Orientation) &
        Simultaneous translation and rotation are enabled, allowing the user to seamlessly move and twist the model. Uniform scaling remains locked. \\
        \addlinespace

        \textbf{T4} & Bimanual Scaling & 7 DoF \newline (6-DoF + Scale) &
        Full spatial manipulation combined with uniform size adjustments, triggered via bimanual hand-tracking or thumbstick engagement. \\

        \bottomrule
    \end{tabularx}
    \caption{Experimental Tasks, Kinematic Constraints and Degrees of Freedom (DoF)}
    \label{tbl:task_dof_descriptions}
\end{table}


% % % % % % % % % % % % % % % % % % % %
% MATHS AND LOGIC
% % % % % % % % % % % % % % % % % % % %
\section{Mathematics and Logic}
\label{}


% % % % % % % % % % % % % % % % % % % %
% FSM, Q={A,B,C,D} All
% % % % % % % % % % % % % % % % % % % %
\begin{table}[htbp]
    \centering
    % 'c |' creates a vertical line separating the states from the inputs
    \begin{tabular}{c | c c c c c c c c c}
        \toprule
        \multirow{2}{*}{
            \textbf{State ($Q$)}
        } &
        \multicolumn{9}{c}{
            \textbf{Input Alphabet ($\Sigma$)}
        } \\
        \cmidrule{2-10} &
        \textbf{0} & \textbf{1} & \textbf{2} &
        \textbf{3} & \textbf{4} & \textbf{5} &
        \textbf{6} & \textbf{7} & \textbf{8} \\
        \midrule
        $\rightarrow *A$ & $A$      & $\bm{A}$ & $\bm{C}$ & $A$ & $A$ & $A$ & $A$& $A$ & $A$ \\
        $B$              & $B$      & $\bm{A}$ & $B$ & $B$      & $B$ & $B$ & $B$& $\bm{C}$  & $\bm{A}$ \\
        $C$              & $\bm{B}$ & $\bm{A}$ & $C$ & $\bm{B}$ & $\bm{D}$ & $C$ & $C$       & $C$ & $C$ \\
        $D$              & $\bm{B}$ & $\bm{A}$ & $D$ & $D$      & $D$ & $\bm{C}$ & $\bm{B}$  & $D$ & $D$ \\
        \bottomrule
    \end{tabular}
    \caption{Formal Transition Function ($\delta$) for the FSM with Actionable State Changes in Bold}
    \label{tbl:dfa_transitions_letters}
\end{table}


% % % % % % % % % % % % % % % % % % % %
% FSM, Q={A,B,C,D} Actionable Only
% % % % % % % % % % % % % % % % % % % %
\begin{table}[htbp]
    \centering
    \begin{tabular}{c | c c c c c c c c c}
        \toprule
        \multirow{2}{*}{
            \textbf{State ($Q$)}
        } &
        \multicolumn{9}{c}{
            \textbf{Input Alphabet ($\Sigma$)}
        } \\
        \cmidrule{2-10} &
        \textbf{0} & \textbf{1} & \textbf{2} &
        \textbf{3} & \textbf{4} & \textbf{5} &
        \textbf{6} & \textbf{7} & \textbf{8} \\
        \midrule
        $A$ &     & $A$ & $C$ &     &     &     &     &     &     \\
        $B$ &     & $A$ &     &     &     &     &     & $C$ & $A$ \\
        $C$ & $B$ & $A$ &     & $B$ & $D$ &     &     &     &     \\
        $D$ & $B$ & $A$ &     &     &     & $C$ & $B$ &     &     \\
        \bottomrule
    \end{tabular}
    \caption{Partial Transition Matrix (Actionable State Changes Only)}
    \label{tbl:dfa_transitions_partial_letters}
\end{table}


% % % % % % % % % % % % % % % % % % % %
% PINCH ALGO MONOSCPACED
% % % % % % % % % % % % % % % % % % % %
\begin{lstlisting}[caption={Using the thumb and index finger positions to define the pinch vector.}, label=alg:get_pinch]
1: procedure GetPinch (hand)
2:    if hand = null then
3:        return Vector3.Zero
4:    end if
5:
6:    Vector3 thumbTip ← hand.fingers[Thumb].TipPosition
7:    Vector3 indexTip ← hand.fingers[Index].TipPosition
8:
9:    return Vector3.Lerp(thumbTip, indexTip, 0.5)
10: end procedure
\end{lstlisting}
\label{alg:get_pinch_mono}


% % % % % % % % % % % % % % % % % % % %
% FIGURE: Edit/PlayMode test results
% % % % % % % % % % % % % % % % % % % %
\begin{figure*}[t!]
    \centering
    \subfloat[EditMode Results]{%
        \includegraphics[width=0.75\linewidth]{images/unity/editmode_results.png}%
        \label{subfig:editmode_results}%
    } \\
    \subfloat[PlayMode Results]{%
        \includegraphics[width=0.75\linewidth]{images/unity/playmode_results.png}%
        \label{subfig:playmode_results}%
    }
    \caption{All unit (EditMode) and integration (PlayMode) tests passing in the test runner}
    \label{fig:test_runner_results}
\end{figure*}


% % % % % % % % % % % % % % % % % % % %
% ALGORITHM: Prototype KinematicManipulator — monolithic pinch grab
% % % % % % % % % % % % % % % % % % % %
\begin{algorithm}[htbp]
\caption{Prototype kinematic manipulator (monolithic, Ultraleap-specific).}
\label{alg:proto_kinematic_manipulator}
\begin{algorithmic}[1]

\Statex \textbf{State:} \texttt{isGrabbing} $\gets$ \textbf{false};\enspace \texttt{activeHandId} $\gets -1$;\enspace \texttt{positionOffset};\enspace \texttt{rotationOffset}

\Statex

\Procedure{Update}{}
    \If{\texttt{leapProvider.CurrentFrame} $=$ \textbf{null}} \Return \EndIf
    \If{$\neg$\texttt{isGrabbing}}
        \State \Call{TryBeginGrab}{\texttt{CurrentFrame}}
    \Else
        \State \Call{UpdateGrab}{\texttt{CurrentFrame}}
    \EndIf
\EndProcedure

\Statex

\Procedure{TryBeginGrab}{\texttt{frame}}
    \For{each \texttt{hand} $\in$ \texttt{frame.Hands}}
        \If{\texttt{hand.PinchDistance} $\leq$ \texttt{grabThreshold}}
            \State \texttt{activeHandId} $\gets$ \texttt{hand.Id}
            \State \texttt{isGrabbing} $\gets$ \textbf{true}
            \State \texttt{positionOffset} $\gets$ \texttt{targetMesh.position} $-$ \Call{PinchCenter}{\texttt{hand}}
            \State \texttt{rotationOffset} $\gets$ $\texttt{hand.Rotation}^{-1} \otimes \texttt{targetMesh.rotation}$
            \State \textbf{break}
        \EndIf
    \EndFor
\EndProcedure

\Statex

\Procedure{UpdateGrab}{\texttt{frame}}
    \State \texttt{hand} $\gets$ \texttt{frame.Hand(activeHandId)}
    \If{\texttt{hand} $=$ \textbf{null} \textbf{or} \texttt{hand.PinchDistance} $\geq$ \texttt{releaseThreshold}}
        \State \texttt{isGrabbing} $\gets$ \textbf{false};\enspace \texttt{activeHandId} $\gets -1$
        \State \Return
    \EndIf
    \If{\texttt{allowTranslation}}
        \State \texttt{targetMesh.position} $\gets$ \Call{PinchCenter}{\texttt{hand}} $+$ \texttt{positionOffset}
    \EndIf
    \If{\texttt{allowRotation}}
        \State \texttt{targetMesh.rotation} $\gets$ \texttt{hand.Rotation} $\otimes$ \texttt{rotationOffset}
    \EndIf
\EndProcedure

\Statex

\Procedure{PinchCenter}{\texttt{hand}}
    \State \texttt{thumb} $\gets$ \texttt{hand.fingers[THUMB].TipPosition}
    \State \texttt{index} $\gets$ \texttt{hand.fingers[INDEX].TipPosition}
    \State \Return $\texttt{Lerp}(\texttt{thumb},\ \texttt{index},\ 0.5)$
\EndProcedure

\end{algorithmic}
\end{algorithm}


\section{GitHub Related}
\label{}


% % % % % % % % % % % % % % % % % % % %
% PRE-COMMIT HOOKS
% % % % % % % % % % % % % % % % % % % %
\begin{table}[htbp]
\centering
\begin{tabularx}{\textwidth}{@{} p{5.1cm} X p{3.2cm} @{}}
    \toprule
    \textbf{Hook ID} & \textbf{Purpose} & \textbf{Source (LTS)} \\
    \midrule

    \multicolumn{3}{@{}l}{\textbf{General File Hygiene}} \\[2pt]
    \texttt{trailing-whitespace}     & Removes trailing whitespace from all tracked files          & pre-commit-hooks \\[4pt]
    \texttt{end-of-file-fixer}       & Ensures files end with a single newline                      & pre-commit-hooks \\[4pt]
    \texttt{check-merge-conflict}    & Rejects commits containing unresolved merge conflict markers & pre-commit-hooks \\[4pt]
    \texttt{check-json}              & Validates JSON file syntax                                  & pre-commit-hooks \\[4pt]
    \texttt{check-yaml}              & Validates YAML file syntax                                  & pre-commit-hooks \\[4pt]
    \texttt{check-added-large-files} & Blocks files exceeding 5\,MB from being committed outside Git LFS & pre-commit-hooks \\
    \midrule

    \multicolumn{3}{@{}l}{\textbf{Code and Configuration Formatting}} \\[2pt]
    \texttt{dotnet-format}           & Enforces C\# whitespace rules via \texttt{dotnet format}; fails if any file requires changes & Local \\[4pt]
    \texttt{oxfmt}                   & Formats JSON, YAML, and Markdown files; excludes Unity \texttt{.asset} files & Local: oxfmt \\
    \midrule

    \multicolumn{3}{@{}l}{\textbf{Unity Asset Integrity}} \\[2pt]
    \texttt{check-unity-meta}        & Verifies a \texttt{.meta} file exists for every tracked asset under \texttt{Assets/} & Local \\
    \midrule

    \multicolumn{3}{@{}l}{\textbf{Workflow and Commit Linting}} \\[2pt]
    \texttt{actionlint}              & Validates GitHub Actions workflow syntax and action references & actionlint \\[4pt]
    \texttt{commitlint}              & Enforces Conventional Commits specification on every commit message & commitlint-pre-commit-hook \\

    \bottomrule
\end{tabularx}
\vspace{1ex}
\raggedright
\footnotesize{\textit{Note:} Hooks are configured in \texttt{.pre-commit-config.yaml}. Unity directories (\texttt{Library/}, \texttt{Temp/}, \texttt{Logs/}, \texttt{obj/}, \texttt{bin/}) are globally excluded. \texttt{dotnet-format} targets \texttt{UnityProject/FormatOnly.sln} and runs once per commit.}
\caption{Pre-Commit Hook Configuration Summary}
\label{tbl:pre_commit_hooks}
\end{table}


% % % % % % % % % % % % % % % % % % % %
% ISSUE LABELS
% % % % % % % % % % % % % % % % % % % %
\begin{table}[htbp]
    \centering
    \begin{tabularx}{\textwidth}{l X @{}}
        \toprule
        \textbf{Label} & \textbf{Purpose} \\
        \midrule
        \texttt{bug}        & Something isn't working. \\
        \texttt{chore}      & Maintenance tasks; no production code changes. \\
        \texttt{config}     & Specific hardware/pipeline setup. \\
        \texttt{docs}       & Improvements or additions to documentation. \\
        \texttt{experiment} & UI, trial flow and user evaluation orchestration. \\
        \texttt{feat}       & New production functionality. \\
        \texttt{fix}        & Bug fixes. \\
        \texttt{release}    & Stable milestones and final submission builds. \\
        \texttt{research}   & Literature-based design decisions. \\
        \texttt{telemetry}  & Telemetry-related changes. \\
        \texttt{test}       & Test-related changes. \\
        \bottomrule
    \end{tabularx}
    \caption{Repository Issue and Commit Labels}
    \label{tbl:repo_labels}
\end{table}


% % % % % % % % % % % % % % % % % % % %
% VISIBLE FIELDS IN PROJECT VIEWS
% % % % % % % % % % % % % % % % % % % %
\begin{table}[htbp]
    \centering
    \begin{tabularx}{\textwidth}{@{} l X @{}}
        \toprule
        \textbf{Board View} & \textbf{Ordered: Visible Fields and Functionality} \\
        \midrule
        \textbf{Kanban}  & Title, Linked pull requests, Priority (P0--P2), Sprint (1--3), Parent issue, Sub-issue progress, Labels, Status, Assignees. \\

        \textbf{Backlog} & Priority (P0--P2), Title, Status, Labels, Start date, Target date, Sprint (1--3), Linked pull requests, Milestone. \\

        \textbf{Roadmap} & Displays a horizontal timeline of issues, featuring versatile grouping, filtering, and slicing options to track long-term milestones. \\
        \bottomrule
    \end{tabularx}
    \caption{Project Board Views and Visible Configurations}
    \label{tbl:board_views}
\end{table}

% \includegraphics[width=0.55\linewidth]{images}
% \captionof{figure}{The .}
% \label{fig:}

% \includegraphics[width=0.55\linewidth]{images}
% \captionof{figure}{The .}
% \label{fig:}

% \includegraphics[width=0.55\linewidth]{images}
% \captionof{figure}{The .}
% \label{fig:}

% \includegraphics[width=0.55\linewidth]{images}
% \captionof{figure}{The .}
% \label{fig:}


% % % % % % % % % % % % % % % % % % % %
% KANBAN
% % % % % % % % % % % % % % % % % % % %
\begin{center}
    \includegraphics[width=0.9\linewidth]{images/github/kanban.png}
    \captionof{figure}{Project Kanban view showing the In-progress column at maximum issue capacity.}
    \label{fig:kanban_ex}
\end{center}


% % % % % % % % % % % % % % % % % % % %
% ISSUE #11
% % % % % % % % % % % % % % % % % % % %
\begin{figure*}[t!]
    \centering
    \subfloat[Contents]{%
        \includegraphics[width=1\linewidth]{images/github/issue_example.png}%
        \label{subfig:issue_ex_content}%
    } \\
    \subfloat[History]{%
        \includegraphics[width=.8\linewidth]{images/github/issue_example_audit_trail.png}%
        \label{subfig:issue_ex_audit}%
    }
    \caption{The full contents and audit trail for Issue \#11}
    \label{fig:issue_ex}
\end{figure*}


% % % % % % % % % % % % % % % % % % % %
% PR #81
% % % % % % % % % % % % % % % % % % % %
\begin{figure*}[t!]
    \centering
    \subfloat[Contents]{%
        \includegraphics[width=.8\linewidth]{images/github/pr_ex_pt_1.png}%
        \label{subfig:pr_ex_1}%
    } \\
    \subfloat[History]{%
        \includegraphics[width=.8\linewidth]{images/github/pr_ex_pt_2.png}%
        \label{subfig:pr_ex_2}%
    }
    \caption{The full (blank) template for a Pull Request \#81}
    \label{fig:pr_ex}
\end{figure*}


% % % % % % % % % % % % % % % % % % % % %
% ROADMAP
% % % % % % % % % % % % % % % % % % % % %
\begin{figure*}[t!]
    \centering
    \subfloat[No slice selected]{%
        \includegraphics[width=1\linewidth]{images/github/roadmap_slice_group_by_milestone_filter_by_parent.png}%
        \label{subfig:roadmap_ex_no_slice}%
    } \\
    \subfloat[Milestone 4 slice selected]{%
        \includegraphics[width=1\linewidth]{images/github/roadmap_slice_group_by_milestone_filter_by_parent_m4.png}%
        \label{subfig:roadmap_ex_m04_slice}%
    }
    \caption{Project Roadmap view grouped and sliced by milestone, filtered by parent issue}
    \label{fig:roadmap_ex}
\end{figure*}


% % % % % % % % % % % % % % % % % % % % %
% BACKLOG
% % % % % % % % % % % % % % % % % % % % %
\begin{figure*}[t!]
    \centering
    \subfloat[No slice selected]{%
        \includegraphics[width=1\linewidth]{images/github/backlog.png}%
        \label{subfig:backlog_ex_no_slice}%
    } \\
    \subfloat[Milestone 4 slice selected]{%
        \includegraphics[width=1\linewidth]{images/github/backlog_sliced.png}%
        \label{subfig:backlog_ex_m04_slice}%
    }
    \caption{Project Backlog view grouped and sliced by milestone, filtered by parent issue}
    \label{fig:backlog_ex}
\end{figure*}

\section{Images}
\label{}


% % % % % % % % % % % % % % % % % % % % %
% % TABLE: Action-modality comparison %TODO: Refer to in implementation for data-types
% % % % % % % % % % % % % % % % % % % % %
\begin{table}[htbp]
    \caption{Comparison of Interaction Modality Input Mechanisms for Mesh Manipulation}
    \label{tbl:modality_comparison}
    \centering
    \begin{tabularx}{\textwidth}{@{} l X X @{}}
        \toprule
        \textbf{Action} & \textbf{Controller Tracking} & \textbf{Hand Tracking} \\
        \midrule
        Grab      & Grip button actuation        & Index-thumb precision pinch \\ \addlinespace
        Translate & Controller positional vector & Pinch centre positional vector \\ \addlinespace
        Rotate    & Controller quaternion rotation & Hand quaternion rotation \\ \addlinespace
        Scale     & Thumbstick Y-axis deflection & Bimanual pinch distance delta \\
        \bottomrule
    \end{tabularx}
    \vspace{1ex}
    \raggedright
    \footnotesize{\textit{Note:} Mappings are specified at the mathematical data-type level. Hardware-specific thresholds and gesture signature parameters are omitted for brevity and are detailed in Section~\ref{sec:gesture_fsm_design}. For participant-facing interaction instructions see Table~\ref{tbl:modality_user_guide}.}
\end{table}


\begin{center}

% CITE? []
% https://uk.robotshop.com/products/ultraleap-leap-motion-controller-2?qd=55e5f461d95f24acd40ad66efaf9e9c5
% % % % % % % % % % % % % % % % % % % %
% LMC2 View
% % % % % % % % % % % % % % % % % % % %
    \includegraphics[width=0.45\linewidth]{images/devices/leap_motion_2_fov.jpg}
    \captionof{figure}{The Ultraleap Leap Motion Controller 2 showing $160 \degree \times 160 \degree$ Field of View and X, Y and Z axes.}
    \label{fig:lmc2_fov}


% % % % % % % % % % % % % % % % % % % %
% VARJO CONTROLLER MAPPINGS
% % % % % % % % % % % % % % % % % % % %
    \includegraphics[width=0.55\linewidth]{images/devices/labelled_varjo_controller_mappings.png}
    \captionof{figure}{The Varjo XR-4 Controller showing simulation control mappings for various input mediums.}
    \label{fig:varjo_ctr_schema}

% % % % % % % % % % % % % % % % % % % %
% DoF of Hand
% % % % % % % % % % % % % % % % % % % %
    %% Move?
    \includegraphics[width=0.35\linewidth]{images/anatomy/labelled_hand_dof.png}
    \captionof{figure}{Labelled DoF of the human hand.}
    \label{fig:hand_dof}
    %%


% % % % % % % % % % % % % % % % % % % %
% LEAP FINGER ENUMS
% % % % % % % % % % % % % % % % % % % %
    \includegraphics[width=0.55\linewidth]{images/anatomy/leap_finger_enums.jpg}
    \captionof{figure}{Labelled Leap recognised parts of the human hand.}
    \label{fig:hand_leap_enums}


% % % % % % % % % % % % % % % % % % % %
% BONES OF HAND
% % % % % % % % % % % % % % % % % % % %
    \includegraphics[width=0.45\linewidth]{images/anatomy/labelled_bones_human_hand.png}
    \captionof{figure}{Labelled skeleton of the human hand.}
    \label{fig:hand_skeleton}


% % % % % % % % % % % % % % % % % % % %
% HANDS AND CONTROLLERS IN SCENE VIEW
% % % % % % % % % % % % % % % % % % % %
    \includegraphics[width=0.75\linewidth]{images/unity/scene_view_hands_controller_livers.png}
    \captionof{figure}{Both modalities visible in the surgical simulation in the Unity scene view.}
    \label{fig:scene_hands_controllers}


%% % % % % % % % % % % % % % % % % % %
% HANDS IN GAME VIEW
% % % % % % % % % % % % % % % % % % % %
    \includegraphics[width=0.75\linewidth]{images/unity/game_view_hands_liver.png}
    \captionof{figure}{Hand modality visible in the surgical simulation in the Unity game view.}
    \label{fig:scene_hands_controllers}


% % % % % % % % % % % % % % % % % % % %
% FOUR TASKS IN SCENE VIEW
% % % % % % % % % % % % % % % % % % % %
    % Move to Implementation?
     \begin{figure*}[t!]
        \subfloat[Task 1: Pure Translation (3 DoF)]{%
            \includegraphics[width=.5\linewidth]{images/unity/scene_view_task_1.png}%
            \label{subfig:task_1}%
        }\; \
        \subfloat[Task 2: Pure Rotation (3 DoF)]{%
            \includegraphics[width=.5\linewidth]{images/unity/scene_view_task_2.png}%
            \label{subfig:task_2}%
        }\\
        \subfloat[3: Translation and Rotation (6 DoF)]{%
            \includegraphics[width=.5\linewidth]{images/unity/scene_view_task_3.png}%
            \label{subfig:task_3}%
        }\; \
        \subfloat[Task 4: Translation, Rotation and Scaling]{%
            \includegraphics[width=.5\linewidth]{images/unity/scene_view_task_4.png}%
            \label{subfig:task_4}%
        }
        \caption{The four surgical liver docking simulation tasks, progressing through various DoF in the Unity scene view)}
        \label{fig:experiment_sim_tasks}
    \end{figure*}
    %%%%%

% % % % % % % % % % % % % % % % % % % %
% 3D PRINT -> GAME VIEW -> SCENE VIEW
% % % % % % % % % % % % % % % % % % % %
    % Move to Implementation?
     \begin{figure*}[t!]
        \subfloat[3D printed model]{%
            \includegraphics[angle=90, width=.23\linewidth]{images/anatomy/3d_print_liver_inside_view.jpg}%
            \label{subfig:task_1}%
        } \
        \subfloat[Unity game view]{%
            \includegraphics[width=.315\linewidth]{images/anatomy/game_view_liver.png}%
            \label{subfig:task_2}%
        } \
        \subfloat[Unity in-situ scene view]{%
            \includegraphics[width=.443\linewidth]{images/anatomy/scene_view_liver_axes.png}%
            \label{subfig:task_3}%
        }
        \caption{Three views of the liver: a 3D printed model and two Unity scene and game views)}
        \label{fig:experiment_sim_tasks}
    \end{figure*}
    %%%%%

\end{center}

% % % % % % % % % % % % % % % % % % % %
% TABLE: SUS grade thresholds
% % % % % % % % % % % % % % % % % % % %
\begin{table}[htbp]
    \caption{System Usability Scale (SUS) Adjective-Anchored Grade Thresholds}
    \label{tbl:sus_grades}
    \centering
    \begin{tabularx}{\textwidth}{@{} c l X @{}}
        \toprule
        \textbf{Score Range} & \textbf{Grade} & \textbf{Interpretation} \\
        \midrule
        $> 80.3$       & Excellent   & Exceeds the usability of most commercial software systems. \\
        \addlinespace
        $68.0$--$80.3$ & Good        & Meets the average usability threshold for commercial software. Broadly acceptable for deployment. \\
        \addlinespace
        $51.0$--$67.9$ & Okay / Fair & Below average. Usability concerns are present and should be addressed before broader deployment. \\
        \addlinespace
        $25.0$--$50.9$ & Poor        & Significant usability problems; requires substantial redesign. \\
        \addlinespace
        $< 25.0$       & Awful       & Unusable. Fundamental interaction design failures are present. \\
        \bottomrule
    \end{tabularx}
    \vspace{1ex}
    \raggedright
    \footnotesize{\textit{Note:} Grade boundaries and adjective labels follow \citet{Brooke1995SUS:Scale}. }
    \item The Good threshold at 68.0 represents the average SUS score across the majority of commercial software evaluations and is the standard benchmark for contextualising scores in comparative HCI studies.
\end{table}

% % % % % % % % % % % % % % % % % % % %
% TABLE: Variance algorithm comparison
% % % % % % % % % % % % % % % % % % % %
\begin{table}[htbp]
    \caption{Comparison of Online Variance Algorithms for High-Frequency
    Metric Accumulation}
    \label{tbl:variance_algorithms}
    \centering
    \begin{tabularx}{\textwidth}{@{} l l X  X @{}}
        \toprule
        \textbf{Algorithm} &
        \textbf{Memory} &
        \textbf{Limitations} &
        \textbf{Suitability} \\
        \midrule

        \textbf{Two-Pass}  &
        $O(n)$ &
        Dynamic array allocation triggers garbage collection at unpredictable intervals in C\#, producing frame-time spikes at 90\,Hz &
        Unsuitable. GC pressure directly degrades simulation fidelity. \\

        \addlinespace

        \textbf{Naïve} \hfill \\ \textbf{Single-Pass} &
        $O(1)$ &
        Error magnitude grows with $n$; particularly dangerous in long multi-task trials where grip samples accumulate across conditions &
        Unsuitable. Cancellation worsens across the four-task sequence, producing unreliable grip variance at later tasks. \\

        \addlinespace

        \textbf{Shifted} \hfill \\ \textbf{Data}  &
        $O(1)$ &
        Stability guarantee degrades as the true mean drifts from the initial anchor. In a within-subjects crossover design, grip mean shifts between CTR and HTR conditions, progressively destabilising the accumulator & Unsuitable. Anchor staleness across condition swaps reintroduces the cancellation the algorithm was designed to prevent. \\

        \addlinespace

        \textbf{Welford's} &
        $O(1)$ &
        One floating-point division per observation ($\approx$27,000 divisions over a five-minute task at 90\,Hz). Cost is negligible on modern hardware &
        \textbf{Selected.} $O(1)$ space, no GC pressure, and unconditional stability across arbitrary interaction sequences and condition resets. \\

        \bottomrule
    \end{tabularx}
    \vspace{1ex}
    \raggedright
    \footnotesize{\textit{Note:} $n$ denotes the number of observations accumulated. $O(1)$ space indicates that memory consumption is constant and independent of trial duration. GC = Garbage Collector. The proposed system accumulates grip strength samples at 90\,Hz inside \texttt{FixedUpdate}; algorithms requiring $O(n)$ storage or producing unstable results across condition transitions are architecturally unsuitable.}
\end{table}


% % % % % % % % % % % % % % % % % % % %
% ALGORITHM: WELFORD'S VARIANCE
% % % % % % % % % % % % % % % % % % % %
\begin{algorithm}[htbp]
\caption{Welford's online variance algorithm.}
\label{alg:welford_procedural}
\begin{algorithmic}[1]
\Procedure{Variance}{samples}
    \State $M \gets 0$; \quad $S \gets 0$; \quad $k \gets 0$
    \For{each $x$ in samples}
        \State $k \gets k + 1$
        \State $\mathit{oldM} \gets M$
        \State $M \gets M + (x - M) \;/\; k$
        \State $S \gets S + (x - M) \times (x - \mathit{oldM})$
    \EndFor
    \State \Return $S \;/\; (k - 1)$
\EndProcedure
\end{algorithmic}
\end{algorithm}

\end{appendices}


% % % % % % % % % % % % % % % % % % % %
% TABLE: Statistical methods summary
% % % % % % % % % % % % % % % % % % % %
\begin{table}[htbp]
    \caption{Summary of Statistical Methods: Purpose and Presentation}
    \label{tbl:stat_methods_summary}
    \centering
    \begin{tabularx}{\textwidth}{@{} l X X l @{}}
        \toprule
        \textbf{Method} &
        \textbf{Purpose} &
        \textbf{Application} &
        \textbf{Visual} \\
        \midrule

        Shapiro-Wilk &
        Assess normality of paired difference scores &
        All metrics (SUS, RTLX, telemetry) &
        Table \\
        \addlinespace

        Wilcoxon \hfill \\ Signed-Rank &
        Primary non-parametric inferential test &
        All metrics; primary for ordinal data &
        Tables \\
        \addlinespace

        Paired $t$-Test &
        Parametric complement where normality not rejected &
        Continuous telemetry metrics &
        Tables \\
        \addlinespace

        Cohen's $d$ &
        Effect size for paired $t$-test &
        All parametric comparisons &
        Tables \\
        \addlinespace

        Rank-Biserial $r$ &
        Effect size for Wilcoxon test &
        All non-parametric comparisons &
        Tables \\
        \addlinespace

        Bland-Altman &
        Agreement pattern between modalities &
        TCT, positional error, rotational error &
        Figures \\
        \addlinespace

        Pearson $r$ + \hfill \\ Regression &
        Learning curve and efficiency frontier &
        TCT vs.\ task number; TCT vs.\ clutch count &
        Figures \\
        \addlinespace

        RMSSD &
        Workload profile variability across subscales &
        Six RTLX subscales per condition &
        Table \\

        \bottomrule
    \end{tabularx}
    \vspace{1ex}
    \raggedright
    \footnotesize{\textit{RMSSD}; Root Mean Squared Standard Deviation}
    \item \textit{Note:} All tests were pre-specified prior to data collection.
    \item The Wilcoxon Signed-Rank test is foregrounded as the primary inferential statistic for all ordinal data regardless of the normality outcome.
    \item Where parametric and non-parametric results diverge, the Wilcoxon result is reported as the primary finding.
    \item Effect sizes are reported for all comparisons as the primary evidence of practical significance for the sample size.
\end{table}

If this is understood, let me know and I will provide you with the chapter for you to apply these points to.

