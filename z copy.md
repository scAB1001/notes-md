\chapter{Methodology}
\label{chap3:meth}

This chapter follows a chronological flow aligned with the four stages of
the project lifecycle:
$\rightarrow$ (1) What are the constraints?
$\rightarrow$ (2) How was the apparatus built and verified?
$\rightarrow$ (3) How was the human experiment designed?
$\rightarrow$ (4) How is the data analysed?

% =============================================================================
\section{Project Scope and Engineering Lifecycle}
\label{sec:scope_lifecycle}
% =============================================================================

% This section proves to the examiner that your software is mathematically
% stable and developed using industry-standard practices before any human testing begins.

\subsection{System Overview and Project Scope}
\label{sec:sys_overview_scope}

The scope of this project is bounded by the following hardware, software and experimental constraints:

\begin{itemize}
    \item \textbf{Hardware.} The bespoke hardware comprised a Varjo XR-4 headset (base model), native Varjo Controllers and an Ultraleap Leap Motion Controller 2 (LMC2). All devices were operated on a single graphics-focused workstation running Windows~11, equipped with an Intel~i7-11700 processor, 32\,GB RAM and an NVIDIA RTX~3080.

    \item \textbf{Software.} The simulation was built in Unity 2022 LTS using the High Definition Render Pipeline (HDRP) template. Hardware integration was provided by Varjo Base and Ultraleap Hyperion.

    \item \textbf{Tasks.} Interaction was constrained to a liver alignment simulation decomposed into four progressive sub-tasks of increasing kinematic complexity, as detailed in Section~\ref{sec:experimental_design}.

    \item \textbf{Participants.} A convenience sample of 5 to 15 university participants without prior VR training was targeted, establishing a na\"{i}ve baseline consistent with the pilot feasibility design described in Section~\ref{sec:experimental_design}.
\end{itemize}

% =============================================================================
\subsection{Project Management and Agile Development}
\label{sec:agile_management}
% =============================================================================

As established in Section~\ref{sec:agile}, \citet{Sommerville2016GlobAlEdiTioN} identifies iterative, sprint-based Agile development as the industry standard for projects with evolving requirements. This project adopted a hybrid release and sprint planning approach: four high-level Milestones provided the release structure, while sprint-level GitHub Issues decomposed each Milestone into individually trackable tickets.

\subsubsection{Milestone Planning}
\label{sec:milestones}

The development process was decomposed into four Milestones, each with a defined scope and a set of key deliverables:

\begin{description}
    \item[Milestone 1 --- Foundation \& Tracking Configuration] Initialised the development environment, secured version control and validated raw hardware data streams. This Milestone ensured architectural stability and a calibrated hardware coordinate space before any 3D models or custom interaction logic were introduced. \textit{Key deliverable:} Dual-layer version control and large-file tracking initialisation.

    \item[Milestone 2 --- Environment \& Kinematic Model Setup] Established the controlled experimental environment and configured the physics-free 3D anatomical models. This Milestone constructed a distraction-free spatial arena and implemented the static translucent target model required for the docking task. \textit{Key deliverables:} Clinical void environment; solid and holographic liver model configurations.

    \item[Milestone 3 --- Spatial Transformations \& Kinematic Framework] Engineered the modular interaction architecture. By decoupling raw input detection from the underlying transformation mathematics, this Milestone ensured a scientifically valid, 1:1 comparative testing environment between Controller Tracking and Hand Tracking. \textit{Key deliverable:} Extensible DFSM governing all interaction states.

    \item[Milestone 4 --- Telemetry, Orchestration \& Final Release] Integrated the high-frequency metrics engine and automated trial progression system. This Milestone finalised the experimental methodology, enabling precise extraction of kinematic data without manual researcher intervention. \textit{Key deliverables:} Real-time metrics engine; state-driven trial orchestrator; spatial dwell-time validation; persistent CSV export pipeline; final tagged release.
\end{description}

\subsubsection{Issue Tracking and Backlog Management}
\label{sec:issue_tracking}

Following \citeauthor{Sommerville2016GlobAlEdiTioN}'s guidance on product backlog management, all development work was captured as GitHub Issues. Approximately four to five parent issues were created per Milestone, each written to a template comprising a User Story, Implementation Details and Acceptance Criteria. This structure preserved context for tasks that would not be addressed for extended periods. Each parent issue was further decomposed into sub-issues representing the individual acceptance criteria, enabling granular progress tracking. Sub-Figure~\ref{subfig:issue_ex_content} shows a representative parent issue and Sub-Figure~\ref{subfig:issue_ex_audit} shows its corresponding audit trail.

To aid navigation and filtering, a taxonomy of eleven labels was developed (Table~\ref{tbl:repo_labels}). Labels were applied to both issues and commit messages; for example, an issue concerning simulation logic received both the \texttt{feat} and \texttt{experiment} labels. Issue templates were created per label type, pre-populating the required headings so that developers could populate rather than design the structure from scratch, improving throughput.

\subsubsection{Project Board Views}
\label{sec:project_board}

Three project views were configured on the GitHub Projects board: a Kanban board, a product Backlog and a Development Roadmap. Table~\ref{tbl:board_views} details the visible fields and configuration of each view.

The Kanban board (Figure~\ref{fig:kanban_ex}) used four columns: To Do, In Progress, In Review and Done. A work-in-progress limit was applied to the In Progress column, enforcing the serial, iterative process advocated by \citet{Sommerville2016GlobAlEdiTioN}. A custom Sprint field and a Priority field (P0--P2) were added to support sprint assignment and ticket ordering within each sprint.

The Backlog (Figure~\ref{fig:backlog_ex}) acted as the primary planning surface for creating and organising issues before sprint assignment. The Roadmap (Figure~\ref{fig:roadmap_ex}) provided a calendar-based timeline view with start and target dates, enabling workload distribution across Milestones to be monitored and adjusted proactively.

Several automated GitHub workflows ran behind the scenes to reduce administrative overhead. When a sub-issue was moved to the Done column, the parent issue's progress was updated automatically; when all sub-issues were closed, the parent issue was closed and the associated Milestone's progress indicator advanced. This provided continuous, zero-effort progress feedback throughout the development cycle.

\subsubsection{Branching, Commits and Pull Requests}
\label{sec:branching_commits}

A Git Feature Branch workflow was adopted, following the established industry practice of branching off \texttt{main}, implementing a feature in isolation and merging back via a pull request (PR). Branches were named according to the format \texttt{label/issue-number/description}, making the purpose and provenance of any active branch immediately legible from the repository view.

Commit messages followed the Conventional Commits specification \citep{ConventionalCommits}, using the format \texttt{label(scope): headline} written in the active voice. This format provides a machine-readable audit trail, supports automated changelog generation and allows repository workflows to be triggered by specific commit patterns. For example, commits containing the \texttt{Closes \#N} keyword automatically close the referenced issue upon merge, eliminating manual housekeeping.

Pull requests were assigned to the project board, labelled, and linked to their closing issues. A PR template enforced a structured description of the change. Critically, no PR could be merged into \texttt{main} without passing all mandatory CI status checks, as governed by branch protection rules described in Section~\ref{sec:vcs_qa}.

\subsubsection{Releases and Semantic Versioning}
\label{sec:releases}

Releases followed Semantic Versioning \citep{SemanticVersioning}, with version numbers of the form \texttt{MAJOR.MINOR.PATCH}. A Release Drafter GitHub Action generated release notes automatically by categorising commits under headings derived from their labels. The version increment was resolved by label: \texttt{release} triggered a major bump, \texttt{feat} a minor bump and all remaining labels (\texttt{fix}, \texttt{chore}, \texttt{telemetry}, \textit{et al.}) a patch bump. A dedicated tag-and-release workflow created the versioned tag on every push to \texttt{main}, ensuring that every stable state of the codebase was permanently addressable. This aligns with \citeauthor{Sommerville2016GlobAlEdiTioN}'s release planning principle: Milestones map directly to minor version increments, providing a traceable relationship between project planning and version history.

% =============================================================================
\subsection{Version Control, Quality Assurance and Testing}
\label{sec:vcs_qa}
% =============================================================================

\subsubsection{Repository Initialisation and File Tracking}
\label{sec:repo_init}

Milestone~1 established the version control foundation. A Git repository was initialised and hosted on GitHub, selected over Unity Version Control (formerly Plastic SCM) for two reasons. First, Unity Version Control is optimised for live-operations game development and provides branch-per-scene merging features that are redundant in a single-machine research context. Second, GitHub's native integration with Actions, Issues and Projects enabled the tight coupling between issue tracking, automated CI validation and semantic release management that the Agile workflow required.

Computer graphics projects present atypical file-tracking challenges: asset files are numerous and large relative to other software domains. A layered \texttt{.gitignore} strategy was adopted to manage this. A rigorous Unity-specific ignore template was nested at the Unity project root, excluding engine-generated artefacts such as \texttt{Library/}, \texttt{Temp/} and \texttt{Logs/}. A second, outer-layer ignore file at the workspace root handled non-Unity files, providing two independent levels of tracking granularity without requiring a single monolithic ignore file.

For assets exceeding the per-file size limits specified in the GitHub Acceptable Use Policies \citep{GitHubDocs}, Git Large File Storage (LFS) was used. A pre-commit hook enforced LFS tracking for any file exceeding 5\,MB, preventing large binary assets from entering the standard object store and degrading repository performance.

\subsubsection{Shift-Left Quality Assurance and Pre-Commit Hooks}
\label{sec:precommit}

A shift-left quality assurance strategy was adopted, intercepting defects  at the earliest possible stage of the development pipeline rather than  deferring them to review or testing \citep{WhatIBM}. The primary mechanism  was a suite of pre-commit hooks configured via \texttt{.pre-commit-config.yaml}  and summarised in Table~\ref{tbl:pre_commit_hooks}. These hooks intercept  every commit before it leaves the developer's machine, enforcing file  hygiene, code formatting, asset integrity and commit message convention  without requiring manual review.

The \texttt{dotnet-format} hook deserves particular attention. As described in Section~\ref{sec:agile}, the C\# codebase is governed by a whitespace formatting rule set applied via \texttt{dotnet format}. The hook runs in \texttt{--verify-no-changes} mode, rejecting the commit if any staged C\# file deviates from the rule set. This guarantees that no unformatted code can enter version control, regardless of the developer's local IDE configuration.

The \texttt{commitlint} hook operates on the \texttt{commit-msg} stage rather than the \texttt{pre-commit} stage, validating every commit message against the Conventional Commits specification and the project-defined scope taxonomy. Scope is mandatory on all commit types; a bare \texttt{fix:} without a scope is rejected, enforcing the discipline required for automated changelog generation.

\subsubsection{Continuous Integration Pipeline}
\label{sec:ci_pipeline}

Server-side quality gates were enforced through a GitHub Actions CI workflow triggered on every push to a feature branch or \texttt{main}. The workflow executed three jobs in sequence: \texttt{dotnet-format} verification, static linting via \texttt{actionlint} and the full unit and integration test suite. A PR could not be merged unless all three jobs passed, creating an automated enforcement mechanism that complemented the local pre-commit hooks.

Dependency security was managed by Dependabot, configured to monitor \texttt{nuget}, \texttt{npm}, \texttt{uv} and \texttt{pre-commit} dependency graphs. Rather than applying updates automatically, Dependabot was configured to open a PR for each available update, placing the merge decision with the developer. This exercised appropriate control while maintaining visibility of available patches. The relevance of timely dependency management is illustrated by the Microsoft CVE-2025-59287 disclosure in October 2025, in which a remote, unauthenticated attacker could gain Remote Code Execution privileges on unpatched Windows Server instances via unsafe object deserialisation \citep{CrowdStrike2026}. While this specific vulnerability was not applicable to this project's architecture, it demonstrates that even mature enterprise software requires continuous vigilance; Dependabot provided that vigilance automatically.

\subsubsection{Branch Protection and Repository Rules}
\label{sec:branch_protection}

Branch protection rules were applied to \texttt{main} and to versioned release tags matching the pattern \texttt{v*}. The rules enforced the following constraints: all CI status checks must pass before a merge is permitted; force pushes are blocked; tag deletions and branch deletions are restricted. GitHub Actions workflows were granted read and write permissions and the authority to create and approve PRs, enabling the automated release drafter to function without manual intervention. These rules collectively ensured that \texttt{main} was always in a deployable, tested state.

\subsubsection{System Validation and Testing}
\label{sec:testing}

As established in Section~\ref{sec:tdd}, Test-Driven Development was adopted for testable modules, with tests written before implementation code. Two categories of test were defined:

\textbf{Unit Testing.} The \texttt{Diagnostics} class and the \texttt{TrialTask} bitmask logic were validated with unit tests, verifying that each logical unit behaved correctly in isolation across all defined input conditions.

\textbf{Integration Testing.} The XR Device Simulator was used to inject known kinematic values into the interaction pipeline, verifying that the telemetry logger produced correct output without requiring a physical headset or participant. This allowed the data pipeline to be validated deterministically against ground-truth inputs, providing confidence in the integrity of the CSV exports before human trials commenced.

It is acknowledged that Unity's tight coupling between \texttt{MonoBehaviour} lifecycle methods and scene state limits the applicability of pure TDD to certain modules. Components that depend on the Unity physics engine or the XR runtime cannot be instantiated in a standard test runner without a scene context. For these components, integration testing via the XR Device Simulator served as the primary validation mechanism, consistent with \citeauthor{Sommerville2016GlobAlEdiTioN}'s categorisation of release testing as a complement to unit testing rather than a substitute for it.

% =============================================================================
\subsection{Research Management and Approach}
\label{sec:research_management}
% =============================================================================

Ethical approval for the participant study was obtained from the University of Leeds Faculty of Engineering and Physical Sciences Research Ethics Committee prior to any data collection. All participants provided written informed consent before the session began. The consent form, project information sheet, and blank copies of all questionnaires administered during the trial are reproduced in Appendix~\ref{doc:consent} through Appendix~\ref{doc:feedback}.

As noted in Section~\ref{sec:prototype}, prototyping was used as a risk-reduction strategy prior to full implementation. A monolithic \texttt{KinematicManipulator} script was developed as an initial proof of concept, validating that the Varjo and Ultraleap hardware could produce stable 6-DoF input before the modular DFSM architecture was committed to. This preliminary investigation revealed the limitations of a hardcoded, provider-specific approach and directly motivated the pivot to the decoupled \texttt{BaseInteractionProvider} abstraction described in Section~\ref{sec:hardware_arch}.

% =============================================================================
\section{Apparatus and Interaction Design}
\label{sec:apparatus}
% =============================================================================

\subsection{Hardware and Software Architecture}
\label{sec:hardware_arch}

The simulation stack comprised three hardware layers and four software layers. At the hardware level, the Varjo XR-4 provided stereoscopic mixed-reality rendering at a resolution and refresh rate suitable for clinical spatial tasks. The Varjo Controllers provided the Controller Tracking modality via OpenXR, while the Ultraleap LMC2 --- mounted on the headset --- provided the Hand Tracking modality via the Ultraleap Hyperion runtime. The sub-millimetre accuracy of the LMC2 under controlled conditions has been independently validated \citep{Matuszczyk2025Comparative2}, providing an empirical baseline for the tracking fidelity of the Hand Tracking condition.

At the software level, the Unity 2022 LTS engine with the HDRP template provided the rendering pipeline. Varjo Base handled headset initialisation and OpenXR device registration. The Ultraleap Hyperion SDK exposed the skeletal hand model to Unity. All interaction logic was implemented in C\# within a custom \texttt{\_Project} hierarchy, isolated from Unity-managed and SDK-managed assets to maintain a clean separation between authored code and third-party dependencies.

The software architecture was designed as a decoupled, object-oriented system. As shown in Figure~\ref{fig:uml_detailed}, the solution comprises three functional categories: interaction logic, experimental orchestration and diagnostic logging. The central design decision was to introduce a \texttt{BaseInteractionProvider} abstract class that defines the mathematical contracts --- positional delta, quaternion rotation, grip strength --- that the \texttt{InteractionOrchestrator} consumes. Concrete implementations (\texttt{UltraleapInteractionProvider} and \texttt{VarjoInteractionProvider}) satisfy these contracts using modality-specific SDK calls, but the orchestrator has no knowledge of which provider is active. This architecture guarantees a 1:1 comparative testing environment: both modalities traverse exactly the same transformation mathematics and telemetry pipeline, ensuring that any measured performance difference is attributable to the input modality alone.

% % % % % % % % % % % % % % % % % % % %
% FIGURE: UML component diagram
% % % % % % % % % % % % % % % % % % % %
\begin{center}
    \includegraphics[width=1\linewidth]{images/architecture_design/uml_component_detailed.png}
    \captionof{figure}{UML Component Diagram illustrating the decoupled interaction architecture. The \texttt{InteractionOrchestrator} consumes only the abstract \texttt{BaseInteractionProvider} contract, ensuring both modalities traverse identical transformation and telemetry pipelines.}
    \label{fig:uml_detailed}
\end{center}

% =============================================================================
\subsection{Interaction Design and Finite State Machine}
\label{sec:fsm_design}
% =============================================================================

As established in Section~\ref{sec:dfsm_theory}, safety-critical interactive systems must operate under formally defined, deterministic transition logic. Accordingly, the interaction framework was designed as a Deterministic Finite State Machine (DFSM), ensuring that every hardware event --- from either the Controller Tracking or Hand Tracking provider --- produces a single, unambiguous state transition.

The DFSM governs all interactions with the 3D liver model. Four interaction states were defined to isolate the distinct kinematic phases of the docking task:

\begin{enumerate}[nosep, label=$q_{\arabic*}$, start=0]
    \item \textbf{(IDLE):} The resting state. No transformations are applied to the model.
    \item \textbf{(CLUTCHING):} The spatial lock state. Model coordinates are frozen to allow wrist repositioning without displacing the liver.
    \item \textbf{(TRANSFORMING):} The monomanual active state. Translation and rotation deltas from the primary hand or controller are applied continuously.
    \item \textbf{(SCALING):} The bimanual active state. Uniform scaling is calculated relative to a locked spatial pivot point, preventing mesh distortion.
\end{enumerate}

Nine discrete hardware events constitute the input alphabet $\Sigma$, representing the full range of interaction primitives available across both modalities. These events are defined at the hardware abstraction level, ensuring that the FSM logic remains modality-agnostic: the same transition function governs both Controller Tracking and Hand Tracking inputs. A full specification of the transition function $\delta$ and the formal computation proof are provided in Section~\ref{sec:fsm_definition}.

% % % % % % % % % % % % % % % % % % % %
% DFSM DIAGRAM
% % % % % % % % % % % % % % % % % % % %
\begin{center}
    \includegraphics[width=0.6\linewidth]{images/architecture_design/dfsm.png}
    \captionof{figure}{Deterministic Finite Automaton governing the interaction framework. States represent kinematic phases; transitions are triggered by discrete hardware events from either modality. Implicit self-loops for unhandled inputs are omitted for visual clarity; the complete transition function is defined in Table~\ref{tbl:dfa_transitions}.}
    \label{fig:dfa_method}
\end{center}

% % % % % % % % % % % % % % % % % % % %
% ACTION-MODALITY COMPARISON TABLE
% % % % % % % % % % % % % % % % % % % %
\begin{table}[htbp]
    \caption{Comparison of Interaction Modality Input Mechanisms for
    Mesh Manipulation}
    \label{tbl:modality_comparison}
    \centering
    \begin{tabularx}{\textwidth}{@{} l X X @{}}
        \toprule
        \textbf{Action} & \textbf{Controller Tracking} &
        \textbf{Hand Tracking} \\
        \midrule
        Grab      & Grip button actuation           &
                    Index-thumb pinch \\ \addlinespace
        Translate & Controller positional vector    &
                    Pinch positional vector \\ \addlinespace
        Rotate    & Controller quaternion rotation  &
                    Hand quaternion rotation \\ \addlinespace
        Scale     & Thumbstick Y-axis deflection    &
                    Bimanual pinch distance delta \\
        \bottomrule
    \end{tabularx}
    \vspace{1ex}
    \raggedright
    \footnotesize{\textit{Note:} Mappings are specified at the mathematical
    data-type level. Hardware-specific thresholds (e.g.\
    \texttt{pinchThreshold < 0.3}) are omitted for brevity. For
    participant-facing instructions see Table~\ref{tbl:modality_user_guide}.}
\end{table}

% =============================================================================
\section{Experimental Methodology}
\label{sec:experimental_methodology}
% =============================================================================

\subsection{Research Paradigm and Approach}
\label{sec:research_paradigm}

To comprehensively evaluate the viability of Natural User Interfaces in clinical spatial computing, this study adopts a mixed-methods research paradigm. Evaluating human-computer interaction requires balancing the objective realities of hardware physics with the subjective cognitive psychology of the user. The approach therefore triangulates quantitative kinematic telemetry --- spatial error, inefficiency ratios and clutch count --- with ordinal workload and usability measures from the RTLX and SUS instruments introduced in Section~\ref{sec:subjective_instruments}.

Evaluating spatial interfaces within application-specific environments introduces confounding variables that threaten internal validity. As established in Section~\ref{sec:testbed_evaluation}, the research approach adheres to the Testbed Evaluation framework \citep{Bowman2001TestbedTechniques}, which mandates decomposing complex procedures into isolated, controlled sub-tasks. By evaluating the liver docking procedure within a sterile virtual testbed, the independent variable --- input modality --- can be strictly manipulated while dependent metrics are captured without the cognitive interference of secondary surgical elements.

\subsection{Experimental Design and Protocol}
\label{sec:experimental_design}

This study was conducted as a pilot crossover feasibility trial in accordance with the CONSORT extension for pilot and feasibility trials \citep{Eldridge2016CONSORTTrials}. A within-subjects crossover design was selected so that each participant served as their own control, eliminating inter-individual variance in motor skill and spatial ability from the between-condition comparison. The participant flow is shown in Figure~\ref{fig:consort}.

\subsubsection{Condition Order and Learning Effects}
\label{sec:condition_order}

All participants completed Controller Tracking (CTR) as Condition~1 before Hand Tracking (HTR) as Condition~2. This fixed order was chosen for two reasons. First, controllers provide a physically grounded, familiar baseline: four of the eight enrolled participants had prior VR controller experience (Table~\ref{tbl:participant_characteristics}), whereas only one had prior hand-tracking experience. Administering the more familiar condition first reduces the risk that residual unfamiliarity with the VR environment contaminates the Hand Tracking measurements. Second, as demonstrated by \citet{Pardo2026AnalyzingUsers}, optical hand tracking involves a genuinely novel motor skill that does not transfer from controller experience. Presenting it second therefore isolates the hand-tracking interface as the novel independent variable rather than confounding it with general VR acclimatisation.

The fixed order does introduce a potential learning effect: participants may perform better in Condition~2 simply because it is their second time completing the docking tasks regardless of the modality. This risk is acknowledged as a limitation of the design, consistent with the pilot feasibility classification, and is addressed in the statistical analysis plan through a carry-over effect check (Section~\ref{sec:stat_plan}).

\subsubsection{Task Design and Kinematic Complexity}
\label{sec:task_design}

Four tasks of escalating kinematic complexity were designed following the Testbed Evaluation principle of isolating specific degrees of freedom \citep{Bowman2001TestbedTechniques}. The progressive structure ensures that performance differences between modalities can be attributed to specific kinematic demands rather than general task difficulty. The task specifications are reproduced in full in Table~\ref{tbl:task_dof_descriptions} in the appendix; a summary is provided here:

\begin{description}
    \item[T1 --- Pure Translation (3 DoF)] Translation along $X$, $Y$
    and $Z$ axes only. Rotation and scaling inputs are mathematically
    locked at the FSM level.

    \item[T2 --- Pure Rotation (3 DoF)] Pitch, Yaw and Roll only.
    Translational displacement of the liver centroid is locked.

    \item[T3 --- Translation and Rotation (6 DoF)] Simultaneous
    translation and rotation without scaling. This is the first task
    requiring concurrent multi-axis coordination.

    \item[T4 --- Bimanual Scaling (7 DoF)] Full 6-DoF manipulation
    combined with uniform scaling via bimanual pinch (HTR) or thumbstick
    deflection (CTR).
\end{description}

Task completion was validated by a 3.0-second spatial dwell criterion: the participant's liver model must continuously satisfy both Euclidean positional error $\leq 0.05$\,m and angular rotational error $\leq 5.0\degree$ for the full dwell duration before the task is accepted. This deterministic criterion eliminates researcher judgement from task completion, a property essential for maintaining the internal validity of the testbed.

% % % % % % % % % % % % % % % % % % % %
% CONSORT FLOW DIAGRAM
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

% =============================================================================
\subsection{Participant Recruitment and Characterisation}
\label{sec:participants}
% =============================================================================

Participants were recruited via a convenience sample of University of Leeds students and staff. Inclusion criteria required normal or corrected-to-normal vision and no self-reported history of severe motion sickness susceptibility. No prior VR or surgical experience was required, targeting a na\"{i}ve baseline consistent with the pilot feasibility design. Baseline characteristics of all eight enrolled participants are reported in Table~\ref{tbl:participant_characteristics}.

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

\subsubsection{Participant Exclusion Criteria}
\label{sec:exclusion_criteria}

Prior to data collection, the following post-hoc exclusion criteria were defined. Any participant session satisfying one or more of the following conditions would be excluded from the inferential analysis:

\begin{itemize}
    \item \textbf{Straight-lining:} the participant provided identical responses to all items on one or both questionnaires, indicating inattentive responding.
    \item \textbf{Protocol deviation:} the participant demonstrably failed to follow the task instructions as observed by the researcher during the session.
    \item \textbf{Equipment failure:} sustained hardware tracking loss resulted in a malformed or temporally discontinuous telemetry export in which the integrity of the kinematic record could not be guaranteed.
\end{itemize}

Exclusion on equipment failure grounds is a recognised practice in VR human factors research, where hardware reliability cannot be guaranteed within a single-session within-subjects design \citep{Bowman2001TestbedTechniques}. The decision to exclude rather than impute was taken because data loss arising from a hardware fault satisfies the missing-not-at-random (MNAR) condition, under which imputation would itself introduce systematic bias \citep{Sterne2009MultiplePitfalls}. The number of participants meeting this criterion and the resulting analytic sample size are reported in Section~\ref{sec:participant_flow}.

% =============================================================================
\section{Evaluation and Statistical Analysis}
\label{sec:eval_stat}
% =============================================================================


% % % % % % % % % % % % % % % % % % % %
% DATA TYPE CLASSIFICATION TABLE
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
        \textbf{RTLX}          & Discrete Ordinal (1--20 integer scales)   &
                                  Quantitative Interval (mean subscale score) \\
        \addlinespace
        \textbf{SUS}           & Categorical Ordinal (5-point Likert scales) &
                                  Quantitative Interval (0--100 composite score) \\
        \addlinespace
        \textbf{Open Feedback} & Qualitative Unstructured (free-text)       &
                                  Categorical Nominal (post-hoc thematic tags) \\
        \bottomrule
    \end{tabularx}
\end{table}

\subsection{Objective Performance Metrics}
\label{sec:objective_metrics}

All objective metrics were logged by the \texttt{SessionTelemetryLogger} at 20\,Hz via a memory-buffered pipeline and exported atomically to CSV at task completion. The following metrics were captured:

\textbf{Task Completion Time (TCT).} The elapsed time from task start to successful spatial dwell validation, measured in seconds. TCT is the primary objective performance metric, consistent with the systematic review evidence that VR-trained groups complete spatial procedures 18--43\% faster than control groups \citep{Mao2021ImmersiveReview}. In accordance with Fitts' Law \citep{Soukoreff2004TowardsHCI}, TCT is expected to scale with task Index of Difficulty, providing a mathematical basis for comparing performance across the four tasks of increasing kinematic complexity.

\textbf{Positional Error (m) and Rotational Error ($\degree$).} Final Euclidean distance between the liver centroid and the docking target, and \texttt{Quaternion.Angle} between the liver orientation and the target orientation, measured at the moment the dwell criterion is first satisfied. The use of quaternion-based angular error is mandatory, as established in Section~\ref{sec:sensor_noise}, to prevent Gimbal Lock singularities \citep{Fang1998RealQuaternions}. These metrics serve as the direct quantification of spatial accuracy referenced by the dwell thresholds ($\leq 0.05$\,m and $\leq 5.0\degree$).

\textbf{Path Inefficiency and Rotation Inefficiency.} The ratio of the actual path length (or total rotation) traversed by the liver to the theoretical minimum required to reach the docking pose. A ratio of 1.0 indicates a perfectly direct trajectory; values above 1.0 quantify wasted motion. These metrics extend the Testbed framework \citep{Bowman2001TestbedTechniques} by capturing the quality of the trajectory rather than only its endpoint.

\textbf{Clutch Count.} The number of discrete grab-release cycles executed during a task. As established by \citet{Rantamaa2023ComparisonReality} using identical Varjo and Ultraleap hardware, repeated interaction events serve as a reliable proxy for optical tracking instability and interaction frustration. A high clutch count indicates that the user was unable to maintain a continuous grip, necessitating repeated re-engagements.

\textbf{Grip Variance.} The running unbiased sample variance of raw grip strength (pinch strength for HTR; analog trigger deflection for CTR) during active manipulation frames, computed using Welford's online algorithm (Section~\ref{sec:welford}). Higher variance indicates less stable and consistent actuation, consistent with the biomechanical evidence that optical hand tracking produces greater grip variability than mechanically grounded physical controllers \citep{Allgaier2022ATraining}.

% =============================================================================
\subsection{Subjective Metrics}
\label{sec:subjective_metrics}
% =============================================================================

Subjective data was collected using the two instruments formally introduced in Section~\ref{sec:subjective_instruments}. Blank copies of both questionnaires are reproduced in Appendix~\ref{doc:rtlx} and Appendix~\ref{doc:sus} respectively.

The RTLX was administered immediately after each of the four tasks, capturing the workload profile specific to each subtask's kinematic demands before memory of the experience degraded. The SUS was administered once per condition, after all four tasks for a given modality had been completed, reflecting its design intent as a holistic system usability measure \citep{Brooke1996SUS:Scale}.

An open feedback form (Appendix~\ref{doc:feedback}) was administered post-condition, inviting free-text responses on modality preference, perceived fatigue and gesture effectiveness. Responses will be analysed via post-hoc thematic coding and reported as qualitative evidence supplementing the quantitative findings.

% =============================================================================
\subsection{Statistical Analysis Plan}
\label{sec:stat_plan}
% =============================================================================

\textbf{Normality testing.} Prior to inferential testing, the Shapiro-Wilk test will be applied to all difference scores (HTR minus CTR per metric). At $n = 5$, Shapiro-Wilk is the appropriate normality test as it has greater power than alternatives for small samples.

\textbf{Primary inferential statistics.} For metrics where difference scores are normally distributed, a paired sample $t$-test will be reported. For non-normally distributed metrics, and as the primary statistic given the ordinal nature of the RTLX and SUS data, the Wilcoxon Signed-Rank test will be used. Both tests will be reported alongside Cohen's $d$ (paired) and rank-biserial $r$ as effect size measures. At $n = 5$ the Wilcoxon cannot produce $p < .05$ unless the result is perfectly one-directional; effect sizes are therefore the primary evidence for practical significance \citep{Wobbrock2011TheProcedures}.

\textbf{Post-hoc power analysis.} A post-hoc power analysis will confirm the minimum detectable effect size at $\alpha = .05$ and $1 - \beta = .80$ for $df = 4$, quantifying the study's sensitivity and providing parameters for powering a future confirmatory trial.

\textbf{Carry-over effect check.} Because the condition order was fixed rather than counterbalanced, a period $\times$ treatment interaction check will be conducted to test whether any observed differences are attributable to learning or fatigue effects rather than modality. If a significant carry-over effect is detected, it will be reported as a confound and the affected metrics flagged for cautious interpretation.

\textbf{Non-parametric factorial analysis.} As established in Section~\ref{sec:welford}, standard parametric ANOVAs applied to ordinal Likert data produce inflated Type~I error rates. The Aligned Rank Transform (ART) ANOVA \citep{Wobbrock2011TheProcedures} will therefore be applied to evaluate Condition $\times$ Task interaction effects on the RTLX and SUS data, providing a mathematically valid factorial analysis of the ordinal subjective measures.