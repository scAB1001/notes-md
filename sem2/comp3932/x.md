## \chapter{Introduction and Background Research}
\label{chapter1}

<A brief introduction suitable for a non-specialist, {\em i.e.} without using technical terms or jargon, as far as possible. This may be similar/the same as that in the 'Outline and Plan' document. The remainder of this chapter will normally cover everything to be assessed under the `Background Research` criterion in the mark scheme.>

% (Focus on the "Paragraph Model": Introduce point → Give theory → Provide cited evidence → Evaluate significance to the project.)

% You can cite chapters by using '\ref{chapter1}'


Purpose: Establish the medical need, identify the research gap, and state your aims.

\section{Context: The Medical Need for 3D Spatial Computing}
\label{}
- Danger, complexifty, cost, efficiency, time, skill in modern surgery.
- 2D input for 3D models: Why CT/MRI slices on flat screens cause cognitive friction (the “dimensional mismatch”).
- Gaps in learning: Novices struggle to mentally reconstruct 3D anatomy from 2D slices; experts rely on years of mental compensation.
- Vault integration: Cite [056. IMHOTEP (2022)] to prove that complex liver surgery requires immersive 3D visualisation.

\section{The Problem with Current VR Controllers}
\label{}
- VR offers 3D visualisation, but joystick controllers still impose abstract mapping.
- Introduce concepts: mapping dissonance, mediated interaction, cognitive translation cost.
- Vault integration: Cite [053. Caggianese (2018)] and [055. Allgaier (2022)] to show that controllers historically outperform hands for precision, but that gap is narrowing.

\section{Natural User Interfaces (NUI) and Optical Hand‑Tracking as a Solution}
\label{}
- Define isomorphic (1:1) mapping – using innate motor skills.
- Introduce Ultraleap / Leap Motion as the enabling hardware.
- State the research question: Does hand‑gesture navigation reduce cognitive load and improve usability compared to traditional VR controllers for 6‑DoF liver docking tasks?

\section{Project Aim and Objectives (SMART)}
\label{}
- Aim: To develop and evaluate a hand‑gesture based interaction system for intuitive 3D anatomical model manipulation in VR, addressing the limitations of joystick‑controlled interfaces.
- Objectives:
  1. Design and implement a modular Finite State Machine (FSM) for 6‑DoF manipulation (grab, translate, rotate, scale).
  2. Integrate optical hand‑tracking (Ultraleap) and VR controllers (Varjo) as interchangeable input providers.
  3. Develop a telemetry pipeline to log objective metrics (TCT, positional/rotational error, inefficiency ratios, clutch count).
  4. Conduct a within‑subjects pilot study (N=10‑20) comparing both input methods across four tasks of increasing DoF complexity.
  5. Analyse subjective workload (NASA‑RTLX) and usability (SUS) alongside objective metrics using appropriate statistical tests (paired t‑tests, ART ANOVA).

\section{Literature Review}
\label{}

\subsection{Foundational 3D Interaction \& HCI Taxonomy}
\label{}

\subsubsection{The Shift from 2D WIMP to 3D NUI}
\label{}
  - Vault: [048. Bachmann (2018)] – defines the Leap Motion as the academic standard.

\subsubsection{Core Interaction Metaphors}
\label{}
  - Vault: [049. Li (2019)] – classifies interactions into Selection, Manipulation, Navigation.

\subsubsection{The Testbed Evaluation Framework}
\label{}
  - Vault: [051.5. Bowman (1999)] – establishes the methodology of isolating independent variables.

\subsection{The Psychology of Virtual Embodiment}
\label{}

\subsubsection{Defining the Sense of Embodiment (SoE)}
\label{}
  - Vault: [061. Kilteni (2012)] – three pillars: self‑location, agency, ownership.

\subsubsection{The Uncanny Valley of Interaction}
\label{}
  - Vault: [061. Argelaguet (2016)] – realistic hands increase ownership but hurt agency when glitches occur.

\subsection{Biomechanics, Fatigue, and Ergonomics}
\label{}

\subsubsection{The Gorilla Arm Effect and Consumed Endurance}
\label{}
  - Vault: [059. Hincapié‑Ramos (2014)] – introduces the CE metric.

\subsubsection{Cumulative Arm Fatigue (CAF) and Individual Differences}
\label{}
  - Vault: [060. Jang (2017)] – personalised fatigue modelling.

\subsubsection{Compensatory Postures Under Fatigue}
\label{}
  - Vault: [046. Yang (2019)] – how dropping elbows changes hand‑camera angle.

\subsection{Hardware Realities: Controllers vs. Optical Tracking}
\label{}

\subsubsection{Historical Superiority of Controllers}
\label{}
  - Vault: [053. Caggianese (2018)] , [055. Allgaier (2022)] – controllers win in precision.

\subsubsection{Modern Equivalence in Medical Contexts}
\label{}
  - Vault: [053. Khundam (2021)] – no statistical difference in intubation task.

\subsubsection{Sensor Fusion and Multi‑View Solutions}
\label{}
  - Vault: [044. Gil‑Martín (2024)] – dual‑camera arrays, [045. Cho (2026)] – AEKF sensor fusion.

\subsection{Multi‑Modal Interfaces and UI Compensation}
\label{}

\subsubsection{Taxonomy of Selection Techniques}
\label{}
  - Vault: [051. Argelaguet (2013)] – virtual hand vs. raycasting, Heisenberg effect.

\subsubsection{Gaze‑Assisted and Hybrid Techniques}
\label{}
  - Vault: [047. Sidenmark (2020)] – outline pursuits for occluded objects; [061.5. Pfeuffer (2017)] – gaze + pinch.

\subsection{Clinical Applications and Medical VR}
\label{}
- Vault: [054. Chheang (2021)] – collaborative liver surgery planning; [056. Kenngott (2022)] – IMHOTEP system.

\subsection{Summary of Gaps and Contribution}
\label{}
- Explicit statement: No prior study has compared controller vs. hand‑tracking for 6‑DoF liver docking using high‑precision Varjo XR‑4 hardware with combined objective telemetry, RTLX, SUS, and ART statistical analysis.


\section{Report Structure}
\label{}
- Brief paragraph outlining Chapters 2–6.
- Specific Roadmap: Detail what subsequent chapters contain using precise language.
- Avoid generic summaries. (e.g., "Chapter 2 justifies the system architecture and gesture-mapping methodology. Chapter 3 details the C\# implementation of the telemetry logger. Chapter 4 evaluates the comparative NASA-TLX and spatial inefficiency results...").


## \chapter{Methodology}
\label{chapter2}

Purpose: Justify every design choice, describe the experimental protocol, define metrics, and outline the statistical plan.

\section{Experimental Design}
\label{}
- Type: Pilot crossover feasibility study (fixed order: Controller → Hand‑tracking).
- Rationale for fixed order: Hardware calibration constraints; acknowledge potential learning effect.
- Tasks: Four levels of increasing DoF complexity:
  1. Pure translation (3‑DoF)
  2. Pure rotation (3‑DoF)
  3. 6‑DoF (translation + rotation)
  4. Full scale (6‑DoF + scaling)
- CONSORT flow diagram (enrolment, allocation, follow‑up, analysis).

\section{Participant Recruitment and Characterisation}
\label{}
- Eligibility criteria: No prior medical training, no motion sickness, normal/corrected vision.
- Recruitment: Convenience sample from university.
- Sample size: N = 10‑20 (feasibility, not powered for significance).
- Table of baseline characteristics: Age, gender, handedness, prior VR experience, gaming frequency.

\section{Hardware and Software Architecture}
\label{}
- VR headset: Varjo XR‑4.
- Hand‑tracking: Ultraleap (Leap Motion Controller 2).
- Controllers: Varjo VR controllers.
- Software: Unity 2022 LTS, HDRP, Ultraleap SDK, Varjo XR Plugin.
- UML component diagram (InteractionOrchestrator, BaseInteractionProvider, providers, TelemetryLogger).

\section{Interaction Design – Finite State Machine (FSM)}
\label{}
- Deterministic FSM diagram (IDLE → TRANSFORMING → SCALING → CLUTCHED).
- Gesture mapping table (Controller vs. Hand):
  - Grab: Grip button (0.5+ threshold) vs. index‑thumb pinch (0.85+ strength)
  - Translate: Controller position vs. pinch position
  - Rotate: Controller rotation vs. hand rotation
  - Scale: Thumbstick Y‑axis vs. bimanual pinch distance delta
  - Reset: Menu button vs. two‑handed expand gesture
- DoF matrix table showing which degrees are active per task.

\section{Performance Metrics (Objective)}
\label{}
- Task Completion Time (TCT): `Time.realtimeSinceStartup`.
- Positional error: Euclidean distance between liver and target.
- Rotational error: `Quaternion.Angle(current, target)` – avoids gimbal lock.
- Path inefficiency: Actual distance traveled / straight‑line distance.
- Rotational inefficiency: Total degrees rotated / minimum required rotation.
- Clutch count: Number of grab releases before completion.
- Grip variance: Standard deviation of pinch strength during grab.
- Hausdorff distance (optional, for volumetric error).
- Justify all metrics with citations: Fitts’ law (Soukoreff \& MacKenzie, 2004), testbed approach (Bowman, 1999).

\section{Subjective Metrics}
\label{}
- Raw NASA‑TLX (RTLX): 6 sub‑scales (mental, physical, temporal demand; performance; effort; frustration). Administered after each task.
- System Usability Scale (SUS): 10‑item questionnaire after each condition.
- Open feedback form: Three prompt questions (preference, fatigue, gesture effectiveness).

\section{Statistical Analysis Plan}
\label{}
- Descriptive statistics: Means, standard deviations.
- Inferential statistics: Paired sample t‑tests (for normally distributed data) or Wilcoxon signed‑rank (non‑normal). Compare TCT, inefficiency ratios, clutch count.
- Non‑parametric factorial analysis: Aligned Rank Transform (ART) for interaction effects (Condition × Task) on RTLX and SUS data (Wobbrock et al., 2011).
- Carry‑over effect check: Test for period × treatment interaction.

## \chapter{Implementation and System Architecture}
\label{chapter3}

Purpose: Demonstrate technical complexity and engineering rigour. Highly visual.

\section{Hardware Setup}
\label{}
- Labelled image of Varjo VR controller (buttons, thumbstick, grip).
- Labelled image of human hand (thumb, index, middle, etc.) showing tracked landmarks.
- DoF matrix table (repeated from 3.4 for clarity).

\section{Software Architecture}
\label{}
- UML class diagram for the FSM and provider hierarchy.
- Explanation of the hardware abstraction layer (`BaseInteractionProvider`).

\section{Gesture Recognition Engine}
\label{}
- Deterministic FSM diagram with state transition conditions.
- Implementation details: pinch threshold, grip threshold, Coyote time (grace period).
- Code snippet (in appendix) for state machine logic.

\section{Kinematic Mathematics}
\label{}
- Quaternion rotations to avoid gimbal lock (cite Fang et al., 1998).
- Delta calculation for position and rotation.
- Scale‑around‑pivot algorithm for bimanual scaling.

\section{Telemetry and Data Logging}
\label{}
- Data pipeline diagram (sensors → Unity → CSV → analysis).
- Logging frequency (20 Hz), CSV format, and post‑processing.

\section{User Interface and Visual Feedback}
\label{}
- Soft visual constraints (landing windows, colour change on alignment).
- Ghost target and solid liver rendering.

## \chapter{Validation}
\label{chapter4}

Purpose: Prove that the system works correctly through systematic testing.

\section{Unit Testing}
\label{}
- Tests for `Diagnostics` class (conditional logging, colour coding).
- Tests for `TrialTask` bitmask logic.
- Tests for FSM state transitions without hardware.

\section{Integration Testing}
\label{}
- Using XR Device Simulator to simulate controller/hand inputs.
- Verification of telemetry accuracy (inject known movements, compare logged values).

\section{Pilot Study (N=5)}
\label{}
- Dry run to identify issues (tracking loss, UI clarity).
- Adjustments made (Coyote time, threshold tuning, demo scene).

\section{Main User Study (N=10‑20)}
\label{}
- Execution of protocol described in Chapter 3.
- Data collection and export.

## \chapter{Results, Evaluation and Discussion}
\label{chapter4}

Purpose: Present the data objectively, then interpret it using the literature.

\section{Results}
\label{}


\subsection{Participant Demographics and Flow}
\label{}
- Table of baseline characteristics.
- CONSORT flow diagram (reference to Chapter 3).


\subsection{Objective Performance Metrics}
\label{}
- Box plots comparing TCT between Controller and Hand for each task.
- Bar charts of mean positional error, rotational error, path inefficiency, rotational inefficiency.
- Heatmap of clutch count across tasks and conditions.
- Line graphs showing learning curve (TCT over trial order).
- Paired t‑test results (or Wilcoxon) for TCT and inefficiency ratios.


\subsection{Subjective Metrics (RTLX and SUS)}
\label{}
- Bar charts of mean RTLX sub‑scale scores.
- SUS scores (mean and SD) for each condition.
- Bland‑Altman plots to show agreement between objective error and subjective performance rating.


\subsection{Qualitative Feedback}
\label{}
- Thematic analysis of open feedback (preference, fatigue, gesture issues).

\section{Discussion}
\label{}


\subsection{Interpretation of Results}
\label{}
- Compare findings to literature: Khundam (2021), Luong (2023), Allgaier (2022).
- Fatigue and ergonomics: Relate clutch count and RTLX physical demand to CE (Hincapié‑Ramos) and CAF (Jang).
- Cognitive load: Higher mental demand in hand‑tracking? Link to lack of haptics (Buckingham, 2021) and visual compensation (Tang et al., 2024).
- Controller advantages: Binary certainty, haptic grounding, no occlusion.


\subsection{Limitations}
\label{}
- Fixed order (learning effect) – acknowledged.
- Small sample size – not powered; treat as pilot.
- Optical occlusion and jitter – cite Mueller (2017), Gil‑Martín (2024).
- Lack of blinding (researcher administered tasks).


\subsection{Relation to Aims and Objectives}
\label{}
- Explicitly state whether each objective was met.

\section{Conclusions}
\label{}
- Summary of findings: Hand‑tracking is viable and preferred for embodiment, but controllers remain more accurate for fine manipulation.
- Final verdict: Hand‑gesture navigation reduces cognitive friction for gross manipulation, but current optical limitations hinder sub‑millimetre precision.

\section{Future Work}
\label{}
- Sensor fusion (multi‑camera arrays, IMU gloves) – cite Gil‑Martín (2024), Cho (2026).
- Gaze‑assisted selection for occluded anatomy – cite Sidenmark (2020), Pfeuffer (2017).
- Haptic feedback integration (ultrasonic or vibrotactile).
- Multi‑user collaborative planning – cite Chheang (2021).
- Larger RCT with balanced crossover design.

# References

- List of 73+ references in consistent citation style (e.g., APA 7th). Include DOIs where available.

# Appendices

## \chapter{Self‑appraisal (10% of mark)}
\begin{appendices}

% (10\% of mark)
\chapter{Self‑appraisal}
\label{}

<This appendix should contain everything covered by the 'self-appraisal' criterion in the mark scheme. Although there is no length limit for this section, 2---4 pages will normally be sufficient. The format of this section is not prescribed, but you may like to organise your discussion into the following sections and subsections.>

\section{Critical self‑evaluation}
\label{}

What went well, what went wrong, how you adapted.

\section{Personal reflection and lessons learned}
\label{}

Technical skills, project management, communication.

\section{Legal, Social, Ethical, Professional Issues}
\label{}

<Refer to each of these issues in turn. If one or more is not relevant to your project, you should still explain {\em why} you think it was not relevant.> - (LSEPI)

\subsection{Legal Issues}
\label{}

Data protection (GDPR), software licences.

\subsection{Social Issues}
\label{}

Accessibility, impact on surgical training.

\subsection{Ethical Issuess}
\label{}

Informed consent, motion sickness screening, right to withdraw, ethics approval.

\subsection{Professional Issue}
\label{}

Code of conduct, reproducibility, open science.

%
% Any other appendices you wish to use should come after "Self-appraisal". You can have as many appendices as you like.
%
\chapter{External Material}
\label{}
<This appendix should provide a brief record of materials used in the solution that are not the student's own work. Such materials might be pieces of codes made available from a research group/company or from the internet, datasets prepared by external users or any preliminary materials/drafts/notes provided by a supervisor. It should be clear what was used as ready-made components and what was developed as part of the project. This appendix should be included even if no external materials were used, in which case a statement to that effect is all that is required.>


\section{Gantt chart / project timeline.}
\label{}


\section{Full code repository (link or relevant snippets).}
\label{}


\section{Raw telemetry CSV samples.}
\label{}


\chapter{Ethics Documentation}
\label{}

\section{Ethics approval letter (if obtained).}
\label{}

\section{Participant information sheet.}
\label{}

\section{Informed consent form.}
\label{}

\section{Raw NASA‑TLX questionnaire.}
\label{}

\section{System Usability Scale (SUS) questionnaire.}
\label{}

\section{Post‑task open feedback form.}
\label{}

\end{appendices}
