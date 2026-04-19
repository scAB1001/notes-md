##
  \chapter{Introduction and Background Research}
  \label{chapter1}

  <A brief introduction suitable for a non-specialist, {\em i.e.} without using technical terms or jargon, as far as possible. This may be similar/the same as that in the 'Outline and Plan' document. The remainder of this chapter will normally cover everything to be assessed under the `Background Research` criterion in the mark scheme.>

  % (Focus on the "Paragraph Model": Introduce point → Give theory → Provide cited evidence → Evaluate significance to the project.)
  % You can cite chapters by using '\ref{chapter1}'

  \textbf{Purpose:} Establish the medical need, identify the research gap, and state your aims.

  \section{Context: The Medical Need for 3D Spatial Computing}
  \label{}
  \textbf{Aim:} Establish the clinical severity and cognitive demands of surgery to justify the mandatory requirement for 3D spatial computing in medical training.
  - Danger, complexity, cost, efficiency, time, skill in modern surgery.
  - Historical Clinical Trajectory: Trace the evolution of medical imaging from early 1990s 2D MRI/CT slices to modern volumetric rendering to prove this is a decades-long clinical pursuit (Vault [001-010]).
  - 2D input for 3D models: Why CT/MRI slices on flat screens cause cognitive friction (the “dimensional mismatch”).
  - Cognitive Load: Mention that the mental translation of 2D to 3D induces heavy cognitive load and mental exhaustion, citing [011. Cognitive Load in Aerospace and Medical Spatial Tasks (2016)].
  - Gaps in learning: Novices struggle to mentally reconstruct 3D anatomy from 2D slices; experts rely on years of mental compensation.
  - Vault integration: Cite [056. IMHOTEP (2022)] to prove that complex liver surgery requires immersive 3D visualisation.

  \section{The Problem with Current VR Controllers}
  \label{}
  \textbf{Aim:} Detail why standard VR controllers, despite enabling 3D environments, fail to bridge the interaction gap due to their abstract, indirect mapping.
  - VR offers 3D visualisation, but joystick controllers still impose abstract mapping.
  - Introduce concepts: mapping dissonance, mediated interaction, cognitive translation cost.
  - Vault integration: Cite [053. Caggianese (2018)] and [055. Allgaier (2022)] to show that controllers historically outperform hands for precision, but that gap is narrowing.

  \section{Natural User Interfaces (NUI) and Optical Hand‑Tracking as a Solution}
  \label{}
  \textbf{Aim:} Introduce optical hand-tracking as the logical technological leap for achieving frictionless, isomorphic interaction in surgical simulations.
  - Define isomorphic (1:1) mapping – using innate motor skills.
  - Introduce Ultraleap / Leap Motion as the enabling hardware.
  - State the research question: Does hand‑gesture navigation reduce cognitive load and improve usability compared to traditional VR controllers for 6‑DoF liver docking tasks?

  \section{Project Aim and Objectives (SMART)}
  \label{}
  \textbf{Aim:} Define the specific, measurable, and testable goals of the project alongside the rigorous methodologies used to achieve them.
  - Aim: To develop and evaluate a hand‑gesture based interaction system for intuitive 3D anatomical model manipulation in VR, addressing the limitations of joystick‑controlled interfaces.
  - Objectives:
    1. Design and implement a modular Finite State Machine (FSM) for 6‑DoF manipulation (grab, translate, rotate, scale).
    2. Integrate optical hand‑tracking (Ultraleap) and VR controllers (Varjo) as interchangeable input providers.
    3. Develop a telemetry pipeline to log objective metrics, specifically Task Completion Time (TCT), spatial/rotational deviation using the **Hausdorff distance**, inefficiency ratios, and clutch counts.
    4. Conduct a within‑subjects pilot study (N=10‑20) comparing both input methods across four tasks of increasing DoF complexity, explicitly implementing counter-balancing to mitigate the **carry-over effect**.
    5. Analyse subjective workload (NASA‑RTLX) and usability (SUS) alongside objective metrics using appropriate statistical tests (paired t‑tests, ART ANOVA).

  \section{Literature Review}
  \label{}
  \textbf{Aim:} Critically evaluate the existing body of multidisciplinary literature to build a theoretical foundation and mathematically expose the research gap.

  \subsection{Foundational 3D Interaction \& HCI Taxonomy}
  \label{}
  \textbf{Aim:} Establish the historical context, standard terminology, and measurement frameworks for 3D human-computer interaction.

  \subsubsection{The Historical Evolution of 3D Interfaces}
  \label{}
  \textbf{Aim:} Briefly map the early evolution of 3D interfaces prior to modern optical sensors to demonstrate the depth of the HCI field.
  - Vault: [012-020] – Tracing the shift away from early desktop peripherals toward early Natural User Interfaces.

  \subsubsection{The Shift from 2D WIMP to 3D NUI}
  \label{}
  \textbf{Aim:} Define the modern paradigm of spatial interaction and the hardware that catalyzed it.
  - Vault: [048. Bachmann (2018)] – defines the Leap Motion as the academic standard for markerless tracking.

  \subsubsection{Core Interaction Metaphors}
  \label{}
  \textbf{Aim:} Provide the academic taxonomy required to precisely describe the mechanics of the surgical simulator.
  - Vault: [049. Li (2019)] – classifies spatial interactions into Selection, Manipulation, Navigation.

  \subsubsection{Standardising Pointing Evaluation \& Fitts' Law}
  \label{}
  \textbf{Aim:} Establish the mathematical physics that govern target acquisition and task completion timers.
  - Vault: [057. Soukoreff (2004)] – introduces Fitts' Law and the ISO 9241-9 standard as the mandatory calculation for measuring movement time and device throughput.

  \subsubsection{The Testbed Evaluation Framework}
  \label{}
  \textbf{Aim:} Justify the structural design of the user study by referencing foundational experimental methodologies.
  - Vault: [052. Bowman (1999)] – establishes the methodology of isolating independent variables and task decomposition rather than evaluating a generic "game."

  \subsection{The Psychology of Virtual Embodiment}
  \label{}
  \textbf{Aim:} Analyze how the human brain accepts and connects with virtual avatars, focusing on visual and motor synchrony.

  \subsubsection{Early Immersion and Proprioception Models}
  \label{}
  \textbf{Aim:} Acknowledge the foundational psychological studies that defined human spatial projection into digital spaces.
  - Vault: [021-030] – Early psychological frameworks evaluating presence and proprioceptive feedback.

  \subsubsection{Defining the Sense of Embodiment (SoE)}
  \label{}
  \textbf{Aim:} Define the exact psychological parameters that determine whether a user feels "immersed" in the simulation.
  - Vault: [061. Kilteni (2012)] – breaks embodiment into three measurable pillars: self‑location, agency, and ownership.

  \subsubsection{The Uncanny Valley of Interaction}
  \label{}
  \textbf{Aim:} Defend the aesthetic and visual design choices of the virtual hands used in the simulation.
  - Vault: [061. Argelaguet (2016)] – proves that highly realistic hands increase ownership but hurt agency (and induce frustration) when kinematic glitches occur.

  \subsection{Biomechanics, Fatigue, and Ergonomics}
  \label{}
  \textbf{Aim:} Mathematically and physiologically quantify the physical strain imposed by mid-air VR interactions.

  \subsubsection{Occupational Biomechanics and RSI Baseline}
  \label{}
  \textbf{Aim:} Ground the VR-specific fatigue metrics in traditional medical science.
  - Vault: [031-039] – Referencing foundational occupational models for Repetitive Strain Injury (RSI) and muscle exhaustion.

  \subsubsection{The Gorilla Arm Effect and Consumed Endurance}
  \label{}
  \textbf{Aim:} Introduce the objective algorithms used to measure the rapid onset of mid-air shoulder fatigue.
  - Vault: [059. Hincapié‑Ramos (2014)] – introduces the Consumed Endurance (CE) metric.

  \subsubsection{Cumulative Arm Fatigue (CAF) and Individual Differences}
  \label{}
  \textbf{Aim:} Provide the literature required to mathematically justify high variance/standard deviations in subjective user fatigue scores.
  - Vault: [060. Jang (2017)] – introduces personalised fatigue modelling, proving that inter-individual strength dictates perceived exertion.

  \subsubsection{Compensatory Postures Under Fatigue}
  \label{}
  \textbf{Aim:} Explain the physiological domino effect where physical exhaustion actively ruins hardware tracking.
  - Vault: [046. Yang (2019)] – details how users adopt compensatory kinematics (e.g., dropping elbows), which inherently changes the hand‑camera angle and breaks optical tracking.

  \subsection{Hardware Realities: Controllers vs. Optical Tracking}
  \label{}
  \textbf{Aim:} Objectively compare the physical capabilities, limitations, and mathematical realities of the tested input hardware.

  \subsubsection{Sensor Noise and Tracking Drift}
  \label{}
  \textbf{Aim:} Define the inherent flaws in spatial tracking systems that cause user frustration.
  - Explicitly discuss **Drift** (IMU drift in controllers vs. Optical occlusion in cameras) as a core hardware limitation.

  \subsubsection{Gimbal Lock and Quaternion Mathematics}
  \label{}
  \textbf{Aim:} Defend the software engineering math required to smooth volatile hardware inputs.
  - Vault: [040. Quaternion Mathematics (1998)] – explain why tracking complex 6-DoF wrist rotation is mathematically volatile without Quaternions to prevent Gimbal Lock.

  \subsubsection{Historical Superiority of Controllers}
  \label{}
  \textbf{Aim:} Present the "Devil's Advocate" perspective to ensure academic objectivity.
  - Vault: [053. Caggianese (2018)] , [055. Allgaier (2022)] – proves controllers historically win in sub-millimeter precision tasks due to haptic grounding.

  \subsubsection{Modern Equivalence in Medical Contexts}
  \label{}
  \textbf{Aim:} Provide the modern counter-argument that justifies testing optical tracking for clinical workflows.
  - Vault: [053. Khundam (2021)] – reveals no statistical difference in interaction time for modern inside-out tracking during an intubation task.

  \subsubsection{Sensor Fusion and Multi‑View Solutions}
  \label{}
  \textbf{Aim:} Outline the bleeding-edge hardware architectures currently being developed to solve optical limitations.
  - Vault: [044. Gil‑Martín (2024)] – dual‑camera arrays; [045. Cho (2026)] – AEKF sensor fusion.

  \subsection{Multi‑Modal Interfaces and UI Compensation}
  \label{}
  \textbf{Aim:} Explore software-based interaction techniques designed to bypass the physical limitations of VR hardware.

  \subsubsection{Early UI Compensations and Probabilistic Intent}
  \label{}
  \textbf{Aim:} Trace the historical development of software solutions for noisy sensor data.
  - Vault: [041-043] – Discuss probabilistic intent classification and spatial landing windows as precursors to modern gaze-assist.

  \subsubsection{Taxonomy of Selection Techniques}
  \label{}
  \textbf{Aim:} Explain how the choice of UI metaphor directly impacts spatial accuracy.
  - Vault: [051. Argelaguet (2013)] – details virtual hand vs. raycasting metaphors, and defines the **Heisenberg effect** (where the act of selecting alters the target's coordinates).

  \subsubsection{Gaze‑Assisted and Hybrid Techniques}
  \label{}
  \textbf{Aim:} Highlight multi-modal UI designs that eliminate the Gorilla arm effect by decoupling the eyes from the hands.
  - Vault: [047. Sidenmark (2020)] – outline pursuits for occluded objects; [062. Pfeuffer (2017)] – gaze + pinch interaction.

  \subsection{Clinical Applications and Medical VR}
  \label{}
  \textbf{Aim:} Ground the HCI research back into its real-world medical application, proving its relevance to collaborative clinical workflows.
  - Vault: [054. Chheang (2021)] – collaborative liver surgery planning; [056. Kenngott (2022)] – IMHOTEP multi-disciplinary system.

  \subsection{Summary of Gaps and Contribution}
  \label{}
  \textbf{Aim:} Explicitly state the novel contribution of this project by highlighting what the literature has failed to address.
  - Explicit statement: No prior study has compared controller vs. hand‑tracking for 6‑DoF liver docking using high‑precision Varjo XR‑4 hardware with combined objective telemetry (Hausdorff), RTLX, SUS, and ART statistical analysis.

  \section{Report Structure}
  \label{}
  \textbf{Aim:} Provide a clear, precise roadmap of the remaining chapters in the dissertation.
  - Brief paragraph outlining Chapters 2–6.
  - Specific Roadmap: Detail what subsequent chapters contain using precise language.
  - Avoid generic summaries. (e.g., "Chapter 2 justifies the system architecture and gesture-mapping methodology. Chapter 3 details the C\# implementation of the telemetry logger. Chapter 4 evaluates the comparative NASA-TLX and spatial inefficiency results...").