\chapter{Methodology}
\label{chap3:meth}

For a cohesive narrative, the chapter should follow a chronological flow: \\
$\rightarrow$ 1. What are the constraints? \\
$\rightarrow$ 2. How was the apparatus built and verified? \\
$\rightarrow$ 3. How was the human experiment designed? \\
$\rightarrow$ 4. How is the data analysed?

\section{Project Scope and Engineering Lifecycle}

% This section proves to the examiner that your software is mathematically stable and developed using industry-standard practices before any human testing begins.

\subsection{System Overview and Project Scope}
\label{sec:sys_overview_scope}

Our project constraints are as follows:
\begin{itemize}
\item The bespoke hardware in this project was limited to the Varjo XR-4 (basic model), native Varjo Controllers
        and Ultraleap Leap Motion Controller 2.
        These devices were paired with a graphics-focused computer workstation with the following
        specification:
    \begin{itemize}
        \item A Windows 11 operating system, an Intel i7-11700 processor, 32GB RAM and an NVIDIA RTX 3080
    \end{itemize}
    graphics card.
\item The software in this project comprises the Unity 2022 LTS engine with the High Definition Render
        Pipeline (HDRP) template, Varjo Base and Ultraleap Hyperion.
        \item The tasks were constrained to the liver alignment simulation, segmented into four progressive subtasks.
        \item We also constrained our participants, conducting our pilot crossover feasibility trial of 5 to 15 participants to target individuals without VR training to establish a baseline.
\end{itemize}


\subsection{Project Management and Agile Development}
\label{}

To design the system we leveraged the Agile software development approach, referring to the knowledge of \citeauthor{Sommerville2016GlobAlEdiTioN} from \ref{sec:agile} when needed. Our approach uses an array of high-level Agile planning practices, enabled and powered by the GitHub platform.

First, we set out to define our milestones. We decomposed the entirety of the development process into four distinct phases and an attempt to balance the development load across all phases as to ensure steady progress:

\textbf{Milestone 1: Foundation \& Tracking Configuration}
Here, we prioritised initialising the development environment, securing version control and validating hardware data streams.

\textbf{Milestone 2: Environment \& Kinematic Model Setup}
Here, we established the controlled experimental environment and configuring the physics-free 3D anatomical models. This milestone focuses on creating a distraction-free spatial arena, configuring visually distinct interaction models, and ensuring visual embodiment for the user.

\textbf{Milestone 3: Spatial Transformations \& Kinematic Framework}
Here, we implemented a modular interaction architecture to handle 3D manipulation actions. This phase decouples raw input detection from the underlying transformation mathematics, ensuring a scientifically valid, 1:1 comparative testing environment between optical hand-tracking and traditional 6-DoF controllers.

\textbf{Milestone 4: Telemetry, Orchestration \& Final Release}
Here, we integrated a metrics engine and an automated trial progression system. This phase finalises the experimental methodology, ensuring the precise extraction of user performance data without requiring manual researcher intervention during the trial.

\textbf{The Workflow}
Because the Milestones were defined with workload balance in mind, they were easily converted to sprints.
To be precise: one `set-up' sprint for general project configuration, followed by three core feature-oriented sprints, with the last planned as an official release.

With milestones and sprints well-defined, \citeauthor{Sommerville2016GlobAlEdiTioN} advises us to start the iterative software development process and create a product backlog. We began using GitHub's `Projects' and `Issues' features. The process involved creating issues for all independent development tasks within a single sprint. To be specific, we created approximately 4 to 5 parent issues per milestone. As seen in Sub Figure \ref{subfig:issue_ex_content}, each parent issue represented a larger feature objective and was written according to a template of User Story, Implementation Details and Acceptance Criteria. This helped cement the context and instruction for a task that might not be looked at for a long time. Each parent issue often had several sub-issues attached that made up the completion its acceptance criteria. This helped enhance progress tracking, as shown in Sub Figure \ref{subfig:issue_ex_audit}.

Alongside the parent-issue template itself, many other design features aided in the planning process. GitHub enables the use, creation, modification and deletion of labels that can be attached to these issues. In short, we developed an issue-label taxonomy making development easier to follow for the developer and repository viewer because the nature of an issue is associated via these label groupings. For example an issue is labelled with \texttt{feat} and \texttt{experiment} if the implementation concerns a code related to the simulation. See table \ref{tbl:repo_labels} for all labels and their definitions. To enhance the planning stage, we created templates for these issues, making versions for different labels. For example a `feat' issue could have all the necessary headings and field pre-populated and the developer simply fills in the gaps. These minor additions benefit the project in the long-term, increasing overall output via templates and other helpers.

With a sprint's tickets written, a Project board can be created. This feature uses issues and other built-in features as input for project management displays. Following, \citeauthor{Sommerville2016GlobAlEdiTioN}'s Agile advice, three project views were created within this board: a product Backlog, a Kanban board and a Development Roadmap.

The views are pre-populated with our issues, so the rest of the works concerns custom configurations and general organisation. The following are customisations worth noting.
The Kanban board, which can be seen here \ref{fig:kanban_ex}, was shaped to have four columns: To do, In progress, In review, Done. This matches Agile practices. Columns were given limits: only a certain number of issues, which we will now refer to as `tickets', were permitted to be in the `In progress' column, for example. This restriction behaves as a self-managing tool, ensuring development follows a serial, iterative process and that only a manageable workload is ongoing active development at any given time.

A custom Sprint field was also added to this view to assign to issues that were added to different columns. Priority was also assigned to define the order of tickets in a Sprint. See table \ref{tbl:board_views} for specific board view configurations.

As mentioned, the board, and therefore the views, use the issues as input but we only see the effect of this when we configure Project workflows for these views. Several workflows run behind the scenes each time a project's view is interacted with. For example, when sub-issues in the Kanban board are moved to the `Done' column, the parent-issue's progress is updated and when complete, the parent-issue is closed and the associated milestone's progress is updated. This provides constant progress feedback throughout the development process.

The Backlog and Roadmap views were pre-generated with our issues and then filtered and sliced manually. As guided by \citeauthor{Sommerville2016GlobAlEdiTioN}, our backlog acted as a larger `to-do' list that could be filtered and sliced more easily. See Figure \ref{fig:backlog_ex} for configuration examples. It does not, however, provide active development support unlike the Roadmap which enables a calendar-view; issues can be given start and target dates, ensuring we maintain workload deadlines. See Figure \ref{fig:roadmap_ex} for configuration examples.
Together these views acted as the project manager toolkit for this project. When we wished to create new issues, we referred to the backlog. When we wished to plan the deadlines and releases for issues or milestones, we consulted the roadmap and when it became time to begin implementing a ticket, we updated it's column in the Kanban board.

We chose to follow a conventional commit strategy, an industry-standard specification used for it's detailed work logging.
Leveraging our taxonomy of labels, conventional commits use a format of \texttt{label(subject area): <headline>} and is spoken in the active voice, reading as a set of instructions \citep{ConventionalCommits}. Workflows can also be ran based on text within these messages. For example, we use the `Closes' keyword followed by the hash symbol then issue number to close the issue (is this correct or only valid in PRs?) There are many rules but we care mostly about the first line of the message and these workflow triggers. The use of these commit practices makes auditing the commit history simple from a glance.

Our branching strategy was also important. We adopted the Git Feature Branch workflow as yet another long-established industry practice. The workflow implements an iterative development process: branching off of the main branch, implementing and then merging a pull request back into main, ensuring isolated events. These branches are also categorised by our labels and parent-issues. By following a naming format of label \texttt{prefix/issue number/issue description}, we ... Link back to organisation ... making it clear what is being worked on and when.

- Configuration
    - dependabot
    - Pull request, Feature request and Bug request issue template files
    - Auto-closed issues with merged linked Pull requests


% Talk about repo rules

When it's time to open a pull request to merge into main

\subsubsection{Planning Strategy}
\label{}

% TASK DECOMPOSITION DIAGRAM (WBS) []

\subsubsection{Project Requirements}
\label{}

\subsection{Version Control, Quality Assurance, and Testing}
\label{}

Milestone 1 best describes the usage of version control, quality assurance and testing within this project.

An initial Unity application was created from a template, a skeletal Git repository was configured and the device-appropriate software was installed and validated with the template.

During this phase, there were some decisions to take into consideration. For example, while Unity offers integrated Cloud and Version Control services (formerly Plastic SCM), standard Git alongside GitHub was selected for the project's source control. This decision was driven by the need for tight integration with Agile issue-tracking and other project management practices which Unity Version Control does not offer natively. Furthermore, Unity Cloud is designed for live-operations game development, including a comprehensive suite of features which would act as bloat to this locally ran, single machine project.

Another key decision concerns the nature of computer graphics projects as whole. These projects are far larger both in the number and size of files compared to other fields like web development. Because of this, we took caution when tracking files with Git's source control. The standard solution is to use what's known as a \texttt{.gitignore} file which tells Git's tracking to omit filenames and patterns specified within that file. Git also offers templates for these files and so a rigorous Unity ignore template was used to ensure only necessary files were tracked. However, this templated was tailored to Unity files specifically and did not cover the entire workspace. Instead of altering an already large ignore file, we opted to nest that file in Unity project root directory and created a second, outer-layer ignore file for the rest of the workspace. This behaved as a layered barrier system and allowed us to manage file-tracking across different levels of granularity.

Additionally, there's the issue of storage and sizing. Git does not offer unlimited file storage, specifying in the \textit{GitHub Acceptable Use Policies} that they impose restrictions to ensure performance, typically limiting file sizes per file and per repository \citep{GitHubDocs}. Thankfully, they promote limited free storage in services like \textit{Git Large File Storage (LFS)}. This works well for the 3D model files as they are relatively large. To broaden this, we set a local rule using a pre-commit hook to track all files exceeding 5MB through Git LFS. This milestone ensures the architectural foundation and hardware coordinate spaces are stable before introducing 3D models and custom interaction logic.

Git hooks, specifically committing-workflow hooks were integral to the integrity of this development process. Like many other Version Control Systems, Git executes custom scripts when triggered by certain actions. These are known as `hooks' and they can be triggered in either the client-side by operations such as commits or in the server-side by receiving pushed commits \citep{GitHooks}.
We enforce the use of the pre-commit hook which intercepts the data heading towards GitHub servers and performs checks configured by the developer. We adopted this approach in light of the `Shift-left' testing approach. This approach echoes the teachings of Agile and emphasises the test-first paradigm \citep{WhatIBM}. Arguably the most important project management hook was the commitlint hook which enables the configuration of rules for the commit message. As mentioned, we also enforced file size and formatting restrictions. See Figure \ref{tbl:pre_commit_hooks} for all project hook configurations.

Another commitment to the Shift-left approach and supported by \citeauthor{Sommerville2016GlobAlEdiTioN} is the adoption of cloud-based Continuous Integration, Continuous Development (CI/CD) tools: GitHub's `Actions'. This space enables the creation of further server-side workflows of which we defined several. Most importantly was our CI workflow which ran formatting and linting checks as well as executed our test suite on the newly pushed code. This meant ... and was agile...

% INFO TO WRITE ABOUT IMPORTANT AND CURRENCY OF ISSUES
% On October 23, 2025, Microsoft issued an out-of-band patch
% for CVE-2025-59287, which the company originally disclosed on
% October 14, 2025. A remote, unauthenticated attacker can exploit
% this vulnerability by sending a crafted event that triggers unsafe
% object deserialization, which enables RCE on the targeted instance.
% Only Windows servers with the WSUS server role enabled are
% vulnerable to CVE-2025-59287 exploitation; by default, the WSUS
% server role is disabled for Windows servers.

CrowdStrike's \textit{2026 Global Threat Report} highlighted the need for a Microsoft Common Vulnerabilities and Exposures (CVE) patch in late October 2025. Prior to its fix, attackers could gain Remote Code Execution (RCE) privileges for certain servers. This is dangerous etc. This highlights need... even a company like Microsoft must stay dilligent. In turn, we also configured dependabots and dependabot alerts which are github's built-in package and vulnerability checker to ensure we do not fall victim to exploitations in older versions of software. Sometimes these newer versions are actually more dangerous and so we configured this process to opan pull-request with the new version and then it lies on the developer to make the change. Exercising appropriate control. We configured these workflows to run every time any push was made to the feature branch or main branch. See a full list... % insert table of workflows []

We went a step further and configured repository branch and pull-request rules:
e.g.,     - Rulesets: Protect Releases to target v* tags, restricting updates and deletions, blocking force pushed and requiring status checks to pass
    - Main branch protetcion rule: Require status checks to pass before merging and Do not allow bypassing the above settings
    - GitHub Actions have read and write workflow permissions and may also create and approve pull requests
% insert table of rules/configurations
For a PR to be be successfully merged, the test-related jobs within the CI workflow must pass acting as passing status checks. We also used a template for the PR which broke down the change to main, see \ref{fig:pr_ex} for full template.
- Pull Requests
    - Were assigned to projects, had multiple labels, closing issue tags and assignees
    - Must pass mandatory github actions jobs before merging
    - Auto-closed issues with merged linked Pull requests

Following issue and milestone deadlines, we planned an official stable release of full functionality for the end of milestone 4.

% Show workflow of process: test (commit), develop & test (commit) []


Like our branches and commits, releases following a formal specification.
- GitHub Actions
    - dependabot for uv, pre-commit, nuget and npm
    - enabled workflow\_dispatch for all workflows
    - continuous integration (CI) workflow for dotnet formatting and unit and integration tests
    - release drafter workflow on pushes to main
    - create release tag on main
- Releases and Tags: Semantic Versioning \citep{SemanticVersioning}
    - Purpose of release, link to agile and sommerville and project management
    - Uses a release dynamic template that categorises labels and commits under different titles: Breaking, Bug Fixes, Maintenance, Documentation, and Dependency Updates
    - The version resolver operates by label name:
        - major: 'release'
        - minor: 'feat'
        - patch: 'experiment', 'telemetry', 'fix', 'bug', 'chore', 'config', 'research', 'docs', 'dependencies'
        - default: patch

System Validation (Testing):
    * *Unit Testing:* Validation of the `Diagnostics` class and `TrialTask` bitmask logic.
    * *Integration Testing:* Utilizing the XR Device Simulator to inject known kinematic values to verify telemetry accuracy without human input.

\subsection{Research Management and Approach}
\label{}


\section{Apparatus and Interaction Design}
\label{}


This section details the actual product the participants will use.

\subsection{Hardware and Software Architecture}
\label{}

The Stack: Varjo XR-4, Ultraleap SDK, Varjo XR Plugin.
Component Architecture: Provide a UML component diagram illustrating the decoupling of the `InteractionOrchestrator`, `BaseInteractionProvider`, the specific input providers, and the `TelemetryLogger`.

As for the software architecture itself, we developed a decoupled Object-oriented solution for the core features.

\begin{center}
    \includegraphics[width=1\linewidth]{images/architecture_design/uml_component_detailed.png}
    \captionof{figure}{UML Component Diagram showing}
    \label{fig:uml_detailed}
\end{center}

As show in figure \ref{fig:uml_detailed} above, the solution design is composed of three clear categories: the interaction logic, the experimental logic and the generic diagnostic logging.

\subsection{Interaction Design and Finite State Machine}
\label{sec:fsm_design}

As established in Section~\ref{sec:dfsm_theory}, safety-critical interactive
systems must operate under formally defined, deterministic transition logic.
Accordingly, the interaction framework was designed as a Deterministic Finite
State Machine (DFSM), ensuring that every hardware event --- from either the
Controller Tracking or Hand Tracking provider --- produces a single,
unambiguous state transition.

The DFSM governs all interactions with the 3D liver model. Four interaction
states were defined to isolate the distinct kinematic phases of the docking task:

\begin{itemize}
    \item \textbf{IDLE ($q_0$):} The resting state. No transformations are
    applied to the model.
    \item \textbf{CLUTCHING ($q_1$):} The spatial lock state. Model
    coordinates are frozen to allow wrist repositioning without displacing
    the liver.
    \item \textbf{TRANSFORMING ($q_2$):} The monomanual active state.
    Translation and rotation deltas from the primary hand or controller are
    applied continuously.
    \item \textbf{SCALING ($q_3$):} The bimanual active state. Uniform
    scaling is calculated relative to a locked spatial pivot point, preventing
    mesh distortion.
\end{itemize}

Nine discrete hardware events constitute the input alphabet $\Sigma$, representing the full range of interaction primitives available across both modalities. These events are defined at the hardware abstraction level, ensuring that the FSM logic remains modality-agnostic: the same transition function governs both Controller Tracking and Hand Tracking inputs. A full specification of the transition function $\delta$ and the formal computation proof are provided in Section~\ref{sec:fsm_definition}.


% % % % % % % % % % % % % % % % % % % %
% ACTION-MODALITY COMPARISON
% % % % % % % % % % % % % % % % % % % %
\begin{table}[htbp]
    \centering
    \begin{tabularx}{\textwidth}{@{} l X X @{}}
        \toprule
        \textbf{Action} & \textbf{Controller-Tracking Modality} & \textbf{Hand-Tracking Modality} \\
        \midrule
        Grab      & Grip button actuation           & Index-thumb pinch \\ \addlinespace
        Translate & Controller positional vector    & Pinch positional vector \\ \addlinespace
        Rotate    & Controller quaternion rotation  & Hand quaternion rotation \\ \addlinespace
        Scale     & Thumbstick Y-axis deflection    & Bimanual pinch distance delta \\
        \bottomrule
    \end{tabularx}
    \raggedright
    \footnotesize{\textit{Note:} Interaction mappings are defined from a high-level systems-engineering perspective, only specifying the mathematical data types.}
    \caption{Comparison of Interaction Modality Measures for Mesh Manipulation}
    \label{tbl:modality_comparison}
\end{table}

% Change []
Table \ref{tbl:modality_comparison} omits specific telemetry conditions required to perform certain actions (e.g. \texttt{pinchThreshold < 0.3}) for the sake of brevity. For instructions on action-modality usage, refer to table \ref{tbl:modality_user_guide}.

\section{Experimental Methodology}
\label{}

Include PRISMA of databases/research flow diagram

This section outlines the human element, leaning heavily on the Testbed framework established in your literature review.

\subsection{Research Paradigm and Approach}
\label{}

To comprehensively evaluate the viability of Natural User Interfaces (NUI) in clinical spatial computing, this study adopts a mixed-methods research paradigm. Evaluating human-computer interaction requires balancing the objective realities of hardware physics with the subjective cognitive psychology of the user. Therefore, the approach triangulates quantitative kinematic telemetry (e.g., spatial error and inefficiency ratios) with qualitative and ordinal user feedback (e.g., NASA-RTLX and System Usability Scale).

Furthermore, evaluating spatial interfaces within highly complex, application-specific environments—such as a graphically dense surgical simulation—introduces significant confounding variables that threaten internal validity. To ensure the empirical data gathered during the comparative trials is mathematically sound, the research approach adheres strictly to the Testbed Evaluation methodology established by Bowman et al. (1999). This framework mandates the decomposition of complex procedures into isolated, highly controlled spatial sub-tasks. By evaluating the liver docking procedure within a sterile virtual testbed, the independent variable (input modality) can be strictly manipulated while dependent metrics are captured without the cognitive interference of secondary surgical elements.

\subsection{Experimental Design and Protocol}
\label{}

Study Type: Pilot crossover feasibility study.
Condition Order: Justify the fixed order (Controller $\rightarrow$ Hand-tracking). Address the potential learning effect, explaining that hardware calibration constraints and the necessity of establishing a baseline require this sequence.
The Subtasks: Detail the escalating complexity (Pure translation $\rightarrow$ Pure rotation $\rightarrow$ 6-DoF $\rightarrow$ Full scale).


% % % % % % % % % % % % % % % % % % % %
% CONSORT FLOW DIAGRAM
% % % % % % % % % % % % % % % % % % % %
\begin{figure}[htbp]
\centering
\begin{tikzpicture}[
    node distance = 0.6cm,
    box/.style = {rectangle, draw, rounded corners,
                  minimum width=7cm, minimum height=1.2cm,
                  text centered, align=center,
                  font=\small, fill=white},
    smallbox/.style = {rectangle, draw, rounded corners,
                       minimum width=3.2cm, minimum height=1.0cm,
                       text centered, align=center,
                       font=\footnotesize, fill=white},
    arrow/.style = {-{Stealth}, thick},
]

% Enrolment
\node[box] (assessed)
    {Assessed for eligibility ($n = 8$)};

\node[box, below=of assessed] (excluded)
    {\textbf{Excluded} ($n = 0$)\\[2pt]
     {\footnotesize No participants failed inclusion criteria}};

\node[box, below=of excluded] (enrolled)
    {\textbf{Enrolled} ($n = 8$)};

% Allocation
\node[box, below=1.0cm of enrolled] (cond1)
    {\textbf{Condition 1: Controller Tracking}\\[2pt]
     Allocated and received ($n = 8$)};

\node[box, below=0.8cm of cond1] (cond2)
    {\textbf{Condition 2: Hand Tracking}\\[2pt]
     Allocated and received ($n = 8$)};

% Follow-up
\node[box, below=0.8cm of cond2] (followup)
    {\textbf{Follow-up}\\[2pt]
     Discontinued: 0\quad Protocol deviations: 0};

% Analysis
\node[box, below=0.8cm of followup] (analysed)
    {\textbf{Analysed} ($n = 5$)\\[2pt]
     {\footnotesize Excluded from analysis ($n = 3$):}\\[1pt]
     {\footnotesize Post-hoc response bias identification}};

% Arrows
\draw[arrow] (assessed)  -- (excluded);
\draw[arrow] (excluded)  -- (enrolled);
\draw[arrow] (enrolled)  -- (cond1)
    node[midway, right, font=\footnotesize] {Fixed order crossover};
\draw[arrow] (cond1)     -- (cond2);
\draw[arrow] (cond2)     -- (followup);
\draw[arrow] (followup)  -- (analysed);

% Stage labels (left margin)
\node[left=0.4cm of assessed, font=\small\bfseries] {Enrolment};
\node[left=0.4cm of cond1,    font=\small\bfseries] {Allocation};
\node[left=0.4cm of followup, font=\small\bfseries] {Follow-up};
\node[left=0.4cm of analysed, font=\small\bfseries] {Analysis};

\end{tikzpicture}
\caption{CONSORT Pilot and Feasibility Trial Flow Diagram showing participant
enrolment, allocation to crossover conditions, follow-up, and analysis \citep{Eldridge2016CONSORTTrials}.
The fixed-order crossover design administered both conditions to all enrolled
participants ($n = 8$); three participants were excluded post-hoc from analysis
(see Section~\ref{sec:exclusion_criteria}).}
\label{fig:consort}
\end{figure}


\subsection{Participant Recruitment and Characterisation}
\label{}

Demographics: Table capturing Age, Gender, Handedness, Prior VR Experience, and Gaming Frequency.
Criteria: Convenience university sample, requiring normal/corrected vision and an absence of severe motion sickness susceptibility.


% % % % % % % % % % % % % % % % % % % %
% PARTICIPANT CHARACTERISTICS
% % % % % % % % % % % % % % % % % % % %
\begin{table}[htbp]
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
    \quad None              & 2 (25.0\%) \\
    \quad Novice (1--5 hours) & 4 (50.0\%) \\
    \quad Experienced ($>$5 hours) & 2 (25.0\%) \\
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
\footnotesize{\textit{Note:} SD = Standard Deviation; VR = Virtual Reality; XR = Extended Reality.}
\caption{Baseline Characteristics and Demographics of Study Participants ($n=8$)}
\label{tbl:participant_characteristics}
\end{table}


\subsubsection{Participant Exclusion Criteria}
\label{sec:exclusion_criteria}

Prior to the experiment, we defined the following exclusion criteria:
\begin{itemize}
    \item Straight-lining: the participant gave identical responses to all items on one or both questionnaires, suggesting inattentive responding
    \item Protocol deviation: the participant did not follow the task instruction correctly as observed by the researcher
    \item Equipment failure: tracking loss events exceeded reasonable interference with the participant's telemetry data
\end{itemize}

Notably, exclusion on the grounds of equipment failure is a recognised practice in VR human factors research, where hardware reliability cannot always be guaranteed within a single-session within-subjects design \citep{Bowman2001TestbedTechniques}.

We opted to exclude rather than impute because the missing data arose from a hardware process entirely independent of participant behaviour. As defined by \citeauthor{Sterne2009MultiplePitfalls}, this satisfies the missing-not-at-random (MNAR) condition under which imputation would itself introduce bias.


\section{Evaluation and Statistical Analysis}
\label{}

This final section defines what data is collected and how it will be processed to answer your research question.

\begin{table}[htbp]
    \centering
    \begin{tabularx}{\textwidth}{@{} l >{\hsize=0.9\hsize}X >{\hsize=1.1\hsize}X @{}}
        \toprule
        \textbf{Evaluation Instrument} & \textbf{Raw Item Data Type} & \textbf{Aggregated Metric Treatment} \\
        \midrule
        \textbf{RTLX (Cognitive Load)} & Discrete Ordinal \newline (1--20 integer scales) & Quantitative Interval \newline (Calculated total/average score) \\
        \addlinespace
        \textbf{SUS (Usability)}       & Categorical Ordinal \newline (5-point Likert scales) & Quantitative Interval \newline (Calculated 0--100 system score) \\
        \addlinespace
        \textbf{Open Feedback}         & Qualitative Unstructured \newline (Free-text responses) & Categorical Nominal \newline (Post-thematic analysis tags) \\
        \bottomrule
    \end{tabularx}
    \caption{Classification of Data Types Collected During User Evaluation}
    \label{tbl:form_data_types}
\end{table}

\subsection{Objective Performance Metrics (Telemetry)}
\label{}

% * *Link to Literature:* Explicitly justify these metrics using Fitts' Law and Bowman's Testbed Evaluation framework.
% Temporal: Task Completion Time (TCT) logged via `Time.realtimeSinceStartup`.
% Spatial Error: Euclidean distance for position; `Quaternion.Angle` for rotation (explicitly noting the prevention of Gimbal Lock).
% Inefficiency Ratios: Actual path/rotation traveled versus the mathematical minimum.
% Ergonomic: Clutch count (number of grab releases) and Grip variance (standard deviation of pinch strength).

\subsection{Subjective Metrics}
\label{}

Workload: Raw NASA-TLX (RTLX) administered post-task to evaluate mental, physical, and temporal demands.
Usability: System Usability Scale (SUS) administered post-condition.
Qualitative: Open feedback prompt addressing preference, fatigue, and gesture effectiveness.

\subsection{Statistical Analysis Plan}
\label{}

Descriptive: Means and standard deviations for all metrics.
Inferential (Parametric vs. Non-Parametric): Paired sample t-tests for normally distributed continuous data (e.g., TCT); Wilcoxon signed-rank for non-normal distributions.
Interaction Effects: The Aligned Rank Transform (ART) ANOVA to analyze interaction effects (Condition $\times$ Task) on the ordinal RTLX and SUS data.
Validity Check: Testing for carry-over effects (period $\times$ treatment interaction) due to the fixed-order design.

% EXTRA
% - Descriptive statistics: Means, standard deviations.
% - Inferential statistics: Paired sample t‑tests (for normally distributed data) or Wilcoxon signed‑rank (non‑normal). Compare TCT, inefficiency ratios, clutch count.
% - Non‑parametric factorial analysis: Aligned Rank Transform (ART) for interaction effects (Condition × Task) on RTLX and SUS data (Wobbrock et al., 2011).
% - Carry‑over effect check: Test for period × treatment interaction.

\section{TO-DO}
- Configuration
    - dependabot
    - Pull request, Feature request and Bug request issue template files

- Talk about Protoyping a simple solution, done with kinematic manipulator script.
% Does this go in methodology or in implementation? []

- Bash scripting


- Milestones:
    - Milestone 1: Foundation \& Tracking Configuration
      - Status: Closed | Due: March 28, 2026
      - Initialising the development environment, securing version control, and validating raw hardware data streams. This - milestone ensures the architectural foundation and hardware coordinate spaces are stable before introducing 3D models and custom interaction logic.
      - Key Deliverables: Dual-layer version control and large-file tracking initialisation.
    - Milestone 2: Environment \& Kinematic Model Setup
      - Status: Closed | Due: April 5, 2026
      - Establishing the controlled experimental environment and configuring the physics-free 3D anatomical models. This - milestone focuses on creating a distraction-free spatial arena, configuring visually distinct interaction models, and ensuring high-fidelity visual embodiment for the user.
      - Key Deliverables:
      -     Construction of a high-performance, distraction-free spatial environment.
      -     Implementation of a static, translucent target model for spatial docking.
    - Milestone 3: Spatial Transformations \& Kinematic Framework
      - Status: Closed | Due: April 10, 2026
      - Engineering a modular interaction architecture to handle complex 3D manipulation. This phase decouples raw input detection from the underlying transformation mathematics, ensuring a scientifically valid, 1:1 comparative testing environment between optical hand-tracking and traditional 6-DoF controllers.
      - Key Deliverables:
      -     Deployment of an extensible finite state machine for interaction
    - Milestone 4: Telemetry, Orchestration \& Final Release
      - Status: Open | Due: April 15, 2026
      - Integrating the high-frequency metrics engine and the automated trial progression system. This phase finalises the experimental methodology, ensuring the precise, objective extraction of Euclidean and angular error data without requiring manual researcher intervention during the trial.
      - Key Deliverables:
      -     Real-time, multidimensional performance metrics engine.
      -     Automated, state-driven trial orchestrator with spatial dwell-time validation.
      -     World-space instructional UI for participant guidance.
      -     Persistent, formatted CSV data export pipeline.
      -     Final, tagged system release.
- Sprints (tied to milestones)
