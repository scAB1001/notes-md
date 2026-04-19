My project title: Replacing Joystick Control: A Hand-Gesture Based Navigation System for 3D Anatomy Manipulation in Virtual Reality

The ideas for my dissertation chapters:

Contents
1 Introduction and Background Research
1.1 Context
1.2 Introduction
1.3 Project Aim and Objectives
1.4 Literature review
1.4.1 Traditional VR Interaction Paradigms
1.4.2 Limitations of Indirect Hardware Interfaces
1.4.3 Natural User Interfaces NUI and Optical Hand-Tracking
1.4.4 Challenges in Optical Tracking and Ergonomics
1.4.5 High-Fidelity Medical Rendering Technologies
1.5 Critical Analysis of Existing Solutions
1.5.1 Existing Solution 1
1.5.2 Existing Solution 2
1.6 Report Structure
2 Methodology
2.1 A section
2.1.1 A sub-section
2.2 Another section
3 Implementation and Validation
3.1 A section
3.1.1 A sub-section
3.2 Another section
4 Results, Evaluation and Discussion
4.1 Evaluation
4.2 Conclusions
4.3 Ideas for future work
References
Appendices
A Self-appraisal
A.1 Critical self-evaluation
A.2 Personal reflection and lessons learned
A.3 Legal, social, ethical and professional issues
A.3.1 Legal issues
A.3.2 Social issues
A.3.3 Ethical issues
A.3.4 Professional issues
B External Material
C Ethics Documentation 1
C.0.1 User Testing Ethics
C.0.2 User Testing Consent
C.0.3 Post-task Question

---
Chapter 2: Literature Review (Background & Related Work)

2.1 3D Interaction & Object Manipulation in VR
2.2 Hand Tracking & Gesture Interaction
2.3 Controller vs. Hand-Tracking Comparisons
2.4 Medical/Surgical Applications of VR
Chapter 3: Methodology (Study Design & Metrics)

3.1 Usability & Workload Measurement (SUS, NASA-TLX)
3.2 Performance Metrics (Fitts' Law, Task Completion)
3.3 Statistical Methods (ART - Aligned Rank Transform)
Chapter 4: Results & Discussion (Related Empirical Findings)

4.1 Fatigue & Exertion in Mid-Air Interaction
4.2 Embodiment & Presence
4.3 Pointing & Selection Techniques

Summary by Chapter

Chapter
2.1 3D Interaction & Object Manipulation
2.2 Hand Tracking & Gesture Interaction
2.3 Controller vs. Hand-Tracking Comparisons
2.4 Medical/Surgical VR Applications
3.1 Usability & Workload (SUS, TLX)
3.2 Performance Metrics (Fitts' Law)
3.3 Statistical Methods (ART)
4.1 Fatigue & Exertion
4.2 Embodiment & Presence
4.3 Pointing & Selection

# Checklist:

## Diagrams and Data Representation

- UML for code and scripts
- Deterministic FSM for gestures
- ART (ANOVA) for telemetry
- Results and Comparative tables
- Controller and Hand schema showing the Degrees of Freedom in a matrix table
- CONSORT flow diagram for the participant and procedure/test flow and checklist
- Character study of participants with relevant factors measured like gamer, experience with VR, medical/surgical experience, etc.
- SUS and RTLX scores represented
- T-test scores
- Testbed approach of metrics
    - Taxonomy of techniques
    - Task decomposition
- Table of acronyms
- Bland-Altman plots for agreement between quantitative measurement methods
- Box plots, heatmaps, line grahs, bar charts, etc.
- Bone hand labelled image
- Varjo VR controller labelled image

## Metrics and Calculations
- Justify all metrics
- Fitt's law
- Heisenberg effect
- Carry-over effect
- Drift
- Gimbal Lock
- Hausdorff distance
- performance timers
- pair sample T tests fot TCT and both conditions

## Medical need
- Danger, Complexity, Cost, efficiency, time and skill
- 2D input for 3D model/view
- Gaps in learning
-

The complete categorization of all 69 resources maps the literature from foundational clinical requirements down to exact statistical methodologies. The structure follows a funnel approach, isolating the medical context before evaluating human factors, hardware systems, and experimental design.

### Phase 1: Clinical Efficacy and Spatial Visualization
This section establishes the medical requirement for 3D visualization, proving that 2D screens fail to provide the spatial awareness necessary for hepatic surgery.

* **001-010. Various Early Clinical Trials and Medical Imaging Reviews (1995-2015)**
    * **Explanation:** These foundational papers establish the baseline medical requirement for 3D spatial computing in operating theaters, detailing the transition from MRI/CT slices to volumetric rendering.
    * **Cross-Reference:** Relates to *Cognitive Psychology*, regarding the mental effort required to translate 2D scans into 3D mental models.
* **011. "Cognitive Load in Aerospace and Medical Spatial Tasks", 2016**
    * **Explanation:** Evaluates how the human brain processes dense spatial data, proving that true 3D environments lower mental exhaustion compared to flat displays.
    * **Cross-Reference:** Relates to *Scientific Methodology*, utilizing NASA-TLX.
* **054. "A collaborative virtual reality environment for liver surgery planning", 2021**
    * **Explanation:** Introduces networked multi-user environments, showing that surgical VR is moving from isolated training to collaborative communication.
    * **Cross-Reference:** Serves as a direct proposal for *Future Work*.
* **056. "IMHOTEP: cross-professional evaluation of a three-dimensional virtual reality system...", 2022**
    * **Explanation:** Proves that the anatomical density of the liver requires 3D visualization, validating the choice of anatomy for the simulator across different medical professionals.

### Phase 2: Human-Computer Interaction Paradigms
This section defines the standard terminology for how humans interact with spatial systems, moving away from desktop peripherals.

* **012-020. Evolution of 3D Interfaces and Near-Field Manipulation (2000-2015)**
    * **Explanation:** Charts the shift away from WIMP (Windows, Icons, Menus, Pointers) interfaces toward early Natural User Interfaces (NUI).
* **048. "Review of Three-Dimensional Human-Computer Interaction with Focus on the Leap Motion Controller", 2018**
    * **Explanation:** Provides the historical anchor for HCI theory, establishing the Leap Motion as the academic standard for markerless hand-tracking.
* **049. "Gesture interaction in virtual reality", 2019**
    * **Explanation:** Provides the fundamental HCI taxonomy, allowing the academic classification of VR mechanics into "Selection," "Manipulation," and "Navigation".

### Phase 3: The Psychology of Embodiment
This section explores the cognitive acceptance of the avatar and the psychological phenomena that occur when tracking systems fail.

* **021-030. Studies on Immersion, Presence, and Proprioception (2005-2015)**
    * **Explanation:** Early psychological models evaluating how humans project their spatial awareness into digital environments.
* **061. "The Sense of Embodiment in Virtual Reality", 2012**
    * **Explanation:** The foundational psychology paper. Explicitly defines "Embodiment" into three distinct pillars: Self-Location, Agency, and Body Ownership.
* **061. "The role of interaction in virtual embodiment: Effects of the virtual hand representation", 2016**
    * **Explanation:** Bridges psychology and UI design by proving the uncanny valley of interaction—showing that highly realistic hands increase Ownership but hurt Agency if kinematic glitches occur.
    * **Cross-Reference:** Relates directly to *UI/UX Solutions*.

### Phase 4: Ergonomics and Biomechanical Strain
This section mathematically defines the physiological strain of mid-air movement.

* **031-039. Occupational Biomechanics and Repetitive Strain Injury Models (1990-2010)**
    * **Explanation:** Establishes the baseline medical definitions for muscle exhaustion and upper-limb endurance.
* **046. "Effects of different fatigue locations on upper body kinematics...", 2019**
    * **Explanation:** Explains how humans react to fatigue, proving that as shoulders tire, users adopt compensatory postures to maintain accuracy.
* **059. "Consumed Endurance: A Metric to Quantify Arm Fatigue of Mid-Air Interactions", 2014**
    * **Explanation:** Introduces the mathematical Consumed Endurance (CE) metric to objectively measure how fast a user's arm tires during unsupported mid-air interaction.
* **060. "Modeling Cumulative Arm Fatigue in Mid-Air Interaction...", 2017**
    * **Explanation:** Expands on CE by introducing personalized Cumulative Arm Fatigue (CAF), proving that inter-individual strength differences cause massive variances in subjective exhaustion.
    * **Cross-Reference:** Relates to *Statistical Analysis* when evaluating subjective variance.

### Phase 5: Hardware Realities and Sensor Mathematics
This section compares specific hardware modalities and details the mathematical limitations of optical tracking.

* **040. "Fundamentals of Quaternion Mathematics in 3D Rotations", 1998**
    * **Explanation:** The mathematical foundation for Gimbal Lock prevention and 6-DoF spatial orientation smoothing within Unity.
* **053. "The Vive Controllers vs. Leap Motion for interactions in Virtual Environments", 2018**
    * **Explanation:** Proves that for rigorous 6-DoF spatial manipulation, users historically prefer physical controllers over optical tracking due to haptic feedback.
* **055. "A comparison of input devices for precise interaction tasks in VR-based surgical planning...", 2022**
    * **Explanation:** Evaluates power grips against precision grips in a liver-surgery context, proving that bare hands struggle with sub-millimeter precision without physical resistance.
* **053. "A Comparative Study of Interaction Time and Usability...", 2021**
    * **Explanation:** Proves that modern inside-out optical tracking has achieved statistical parity with physical controllers regarding interaction time in medical contexts.
* **044. "Dual Leap Motion Controller 2: A Robust Dataset for Multi-view Hand Pose Recognition", 2024**
    * **Explanation:** Proves that single-camera optical occlusion is solvable using dual-camera arrays and multi-view machine learning datasets.
* **045. "Force Feedback-Based Adaptive Sensor Fusion Algorithm...", 2026**
    * **Explanation:** Proves that enterprise clinical VR requires fusing optical cameras, IMUs, and force sensors via Adaptive Extended Kalman Filters to achieve true sub-millimeter precision.

### Phase 6: Multi-Modal Interfaces and UI Solutions
This section explores software-based interface fixes designed to bypass hardware constraints.

* **041-043. Development of Target Acquisition UI and Probabilistic Intent Classification (2010-2016)**
    * **Explanation:** Details early software solutions to compensate for noisy sensor data, including spatial landing windows.
* **051. "A survey of 3D object selection techniques for virtual environments", 2013**
    * **Explanation:** Establishes the taxonomy of UI fixes, categorizing interfaces into Virtual Hand (near-field) versus Virtual Pointer (raycasting) metaphors.
* **047. "Outline Pursuits: Gaze-assisted Selection of Occluded Objects in Virtual Reality", 2020**
    * **Explanation:** Proves that when target objects are physically hidden, multi-modal eye-tracking can bypass hand-tracking failures.
* **062. "Gaze + pinch interaction in virtual reality", 2017**
    * **Explanation:** The multi-modal synergy model. Merges eye-tracking for targeting with hand-tracking for pinching to bypass the biomechanical strain of extended reaches.
    * **Cross-Reference:** Relates to *Ergonomics*, acting as the software solution to Consumed Endurance.

### Phase 7: Scientific Evaluation and Statistical Methodology
This section provides the strict academic frameworks used to build the Unity testbed and run non-parametric statistics.

* **052. "Testbed Evaluation of Virtual Environment Interaction Techniques", 1999**
    * **Explanation:** The structural blueprint for the experimental design. Formalizes the isolation of distinct interaction variables rather than evaluating an entire application globally.
* **057. "Towards a standard for pointing device evaluation, perspectives on 27 years of Fitts' law...", 2004**
    * **Explanation:** The mathematical standard for calculating interface efficiency, utilizing ISO 9241-9 guidelines to evaluate target acquisition speed and spatial difficulty.
* **058. "The Aligned Rank Transform for Nonparametric Factorial Analyses", 2011**
    * **Explanation:** Provides the exact mathematical justification for running ANOVAs on subjective, ordinal Likert scale data derived from NASA-TLX or System Usability Scale questionnaires.


### 1.1 Context: The Medical Need for 3D Spatial Computing
- **Danger, complexity, cost, efficiency, time, skill** in modern surgery.
- **2D input for 3D models:** Why CT/MRI slices on flat screens cause cognitive friction (the “dimensional mismatch”).
- **Gaps in learning:** Novices struggle to mentally reconstruct 3D anatomy from 2D slices; experts rely on years of mental compensation.
- *Vault integration:* Cite **[056. IMHOTEP (2022)]** to prove that complex liver surgery requires immersive 3D visualisation.

### 1.2 The Problem with Current VR Controllers
- VR offers 3D visualisation, but **joystick controllers still impose abstract mapping**.
- Introduce concepts: **mapping dissonance**, **mediated interaction**, **cognitive translation cost**.
- *Vault integration:* Cite **[053. Caggianese (2018)]** and **[055. Allgaier (2022)]** to show that controllers historically outperform hands for precision, but that gap is narrowing.

### 1.3 Natural User Interfaces (NUI) and Optical Hand‑Tracking as a Solution
- Define **isomorphic (1:1) mapping** – using innate motor skills.
- Introduce **Ultraleap / Leap Motion** as the enabling hardware.
- State the **research question**: *Does hand‑gesture navigation reduce cognitive load and improve usability compared to traditional VR controllers for 6‑DoF liver docking tasks?*

### 1.4 Project Aim and Objectives (SMART)
- **Aim:** To develop and evaluate a hand‑gesture based interaction system for intuitive 3D anatomical model manipulation in VR, addressing the limitations of joystick‑controlled interfaces.
- **Objectives:**
  1. Design and implement a modular Finite State Machine (FSM) for 6‑DoF manipulation (grab, translate, rotate, scale).
  2. Integrate optical hand‑tracking (Ultraleap) and VR controllers (Varjo) as interchangeable input providers.
  3. Develop a telemetry pipeline to log objective metrics (TCT, positional/rotational error, inefficiency ratios, clutch count).
  4. Conduct a within‑subjects pilot study (N=10‑20) comparing both input methods across four tasks of increasing DoF complexity.
  5. Analyse subjective workload (NASA‑RTLX) and usability (SUS) alongside objective metrics using appropriate statistical tests (paired t‑tests, ART ANOVA).

### 1.5 Report Structure
- Brief paragraph outlining Chapters 2–6.

\section{Literature review}

\subsection{Foundational 3D Interaction & HCI Taxonomy}


\subsection{Limitations of Indirect Hardware Interfaces}


\subsection{Natural User Interfaces NUI and Optical Hand-Tracking}

\subsection{Challenges in Optical Tracking and Ergonomics}


\subsection{High-Fidelity Medical Rendering Technologies}


\section{Critical Analysis of Existing Solutions}
The "Gap Analysis"—comparing existing medical VR tools and proving why your specific gesture-to-action mapping framework is a necessary development.
Evaluate Previous Work: Do not merely list previous papers; critically compare their methodologies. For example, note if a study demonstrated improved completion times but failed to use asymmetrical anatomical models, or if it utilized low-fidelity standalone headsets that compromise clinical precision.


\section{Report Structure}
Specific Roadmap: Detail what subsequent chapters contain using precise language. Avoid generic summaries. (e.g., "Chapter 2 justifies the system architecture and gesture-mapping methodology. Chapter 3 details the C\# implementation of the telemetry logger. Chapter 4 evaluates the comparative NASA-TLX and spatial inefficiency results...").
