## Final Refined Dissertation Structure

Based on your rough plan, the literature vault, the marking rubric, and the detailed categorization provided, here is your **final, polished, rubric‑aligned dissertation structure**.

This structure merges:
- Your original chapter ideas (Introduction, Methodology, Implementation, Results, Discussion)
- The thematic literature review from the vault (2.1–2.4)
- The missing Implementation and Validation chapters
- The checklist of diagrams, metrics, and analyses
- The CONSORT framework and self‑appraisal requirements

---

# Replacing Joystick Control: A Hand‑Gesture Based Navigation System for 3D Anatomy Manipulation in Virtual Reality

## Front Matter
- **Abstract** (300 words: problem, method, key results, conclusion)
- **Table of Contents**
- **Table of Acronyms** (DoF, FSM, HCI, NUI, RTLX, SUS, ART, TCT, CE, CAF, HMD, XRIT, etc.)
- **List of Figures** (UML, FSM diagram, DoF matrix, Bland‑Altman plots, box plots, heatmaps, labelled hand/controller images)
- **List of Tables** (participant characteristics, comparative results, SUS/RTLX scores)

---

## Chapter 1: Introduction

**Purpose:** Establish the medical need, identify the research gap, and state your aims.

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

---

## Chapter 2: Literature Review

**Purpose:** Provide a systematic, critical, and funnel‑shaped review of existing research, from broad HCI theory down to specific hardware limitations and evaluation methods.

### 2.1 Foundational 3D Interaction & HCI Taxonomy
- **2.1.1 The Shift from 2D WIMP to 3D NUI**
  - *Vault:* **[048. Bachmann (2018)]** – defines the Leap Motion as the academic standard.
- **2.1.2 Core Interaction Metaphors**
  - *Vault:* **[049. Li (2019)]** – classifies interactions into Selection, Manipulation, Navigation.
- **2.1.3 The Testbed Evaluation Framework**
  - *Vault:* **[052. Bowman (1999)]** – establishes the methodology of isolating independent variables.

### 2.2 The Psychology of Virtual Embodiment
- **2.2.1 Defining the Sense of Embodiment (SoE)**
  - *Vault:* **[061. Kilteni (2012)]** – three pillars: self‑location, agency, ownership.
- **2.2.2 The Uncanny Valley of Interaction**
  - *Vault:* **[061. Argelaguet (2016)]** – realistic hands increase ownership but hurt agency when glitches occur.

### 2.3 Biomechanics, Fatigue, and Ergonomics
- **2.3.1 The Gorilla Arm Effect and Consumed Endurance**
  - *Vault:* **[059. Hincapié‑Ramos (2014)]** – introduces the CE metric.
- **2.3.2 Cumulative Arm Fatigue (CAF) and Individual Differences**
  - *Vault:* **[060. Jang (2017)]** – personalised fatigue modelling.
- **2.3.3 Compensatory Postures Under Fatigue**
  - *Vault:* **[046. Yang (2019)]** – how dropping elbows changes hand‑camera angle.

### 2.4 Hardware Realities: Controllers vs. Optical Tracking
- **2.4.1 Historical Superiority of Controllers**
  - *Vault:* **[053. Caggianese (2018)]** , **[055. Allgaier (2022)]** – controllers win in precision.
- **2.4.2 Modern Equivalence in Medical Contexts**
  - *Vault:* **[053. Khundam (2021)]** – no statistical difference in intubation task.
- **2.4.3 Sensor Fusion and Multi‑View Solutions**
  - *Vault:* **[044. Gil‑Martín (2024)]** – dual‑camera arrays, **[045. Cho (2026)]** – AEKF sensor fusion.

### 2.5 Multi‑Modal Interfaces and UI Compensation
- **2.5.1 Taxonomy of Selection Techniques**
  - *Vault:* **[051. Argelaguet (2013)]** – virtual hand vs. raycasting, Heisenberg effect.
- **2.5.2 Gaze‑Assisted and Hybrid Techniques**
  - *Vault:* **[047. Sidenmark (2020)]** – outline pursuits for occluded objects; **[062. Pfeuffer (2017)]** – gaze + pinch.

### 2.6 Clinical Applications and Medical VR
- *Vault:* **[054. Chheang (2021)]** – collaborative liver surgery planning; **[056. Kenngott (2022)]** – IMHOTEP system.

### 2.7 Summary of Gaps and Contribution
- Explicit statement: *No prior study has compared controller vs. hand‑tracking for 6‑DoF liver docking using high‑precision Varjo XR‑4 hardware with combined objective telemetry, RTLX, SUS, and ART statistical analysis.*

---

## Chapter 3: Methodology

**Purpose:** Justify every design choice, describe the experimental protocol, define metrics, and outline the statistical plan.

### 3.1 Experimental Design
- **Type:** Pilot crossover feasibility study (fixed order: Controller → Hand‑tracking).
- **Rationale for fixed order:** Hardware calibration constraints; acknowledge potential learning effect.
- **Tasks:** Four levels of increasing DoF complexity:
  1. Pure translation (3‑DoF)
  2. Pure rotation (3‑DoF)
  3. 6‑DoF (translation + rotation)
  4. Full scale (6‑DoF + scaling)
- **CONSORT flow diagram** (enrolment, allocation, follow‑up, analysis).

### 3.2 Participant Recruitment and Characterisation
- **Eligibility criteria:** No prior medical training, no motion sickness, normal/corrected vision.
- **Recruitment:** Convenience sample from university.
- **Sample size:** N = 10‑20 (feasibility, not powered for significance).
- **Table of baseline characteristics:** Age, gender, handedness, prior VR experience, gaming frequency.

### 3.3 Hardware and Software Architecture
- **VR headset:** Varjo XR‑4.
- **Hand‑tracking:** Ultraleap (Leap Motion Controller 2).
- **Controllers:** Varjo VR controllers.
- **Software:** Unity 2022 LTS, HDRP, Ultraleap SDK, Varjo XR Plugin.
- **UML component diagram** (InteractionOrchestrator, BaseInteractionProvider, providers, TelemetryLogger).

### 3.4 Interaction Design – Finite State Machine (FSM)
- **Deterministic FSM diagram** (IDLE → TRANSFORMING → SCALING → CLUTCHED).
- **Gesture mapping table** (Controller vs. Hand):
  - Grab: Grip button (0.5+ threshold) vs. index‑thumb pinch (0.85+ strength)
  - Translate: Controller position vs. pinch position
  - Rotate: Controller rotation vs. hand rotation
  - Scale: Thumbstick Y‑axis vs. bimanual pinch distance delta
  - Reset: Menu button vs. two‑handed expand gesture
- **DoF matrix table** showing which degrees are active per task.

### 3.5 Performance Metrics (Objective)
- **Task Completion Time (TCT):** `Time.realtimeSinceStartup`.
- **Positional error:** Euclidean distance between liver and target.
- **Rotational error:** `Quaternion.Angle(current, target)` – avoids gimbal lock.
- **Path inefficiency:** Actual distance traveled / straight‑line distance.
- **Rotational inefficiency:** Total degrees rotated / minimum required rotation.
- **Clutch count:** Number of grab releases before completion.
- **Grip variance:** Standard deviation of pinch strength during grab.
- **Hausdorff distance** (optional, for volumetric error).
- *Justify all metrics with citations:* Fitts’ law (Soukoreff & MacKenzie, 2004), testbed approach (Bowman, 1999).

### 3.6 Subjective Metrics
- **Raw NASA‑TLX (RTLX):** 6 sub‑scales (mental, physical, temporal demand; performance; effort; frustration). Administered after each task.
- **System Usability Scale (SUS):** 10‑item questionnaire after each condition.
- **Open feedback form:** Three prompt questions (preference, fatigue, gesture effectiveness).

### 3.7 Statistical Analysis Plan
- **Descriptive statistics:** Means, standard deviations.
- **Inferential statistics:** Paired sample t‑tests (for normally distributed data) or Wilcoxon signed‑rank (non‑normal). Compare TCT, inefficiency ratios, clutch count.
- **Non‑parametric factorial analysis:** **Aligned Rank Transform (ART)** for interaction effects (Condition × Task) on RTLX and SUS data (Wobbrock et al., 2011).
- **Carry‑over effect check:** Test for period × treatment interaction.

---

## Chapter 4: Implementation and System Architecture

**Purpose:** Demonstrate technical complexity and engineering rigour. Highly visual.

### 4.1 Hardware Setup
- **Labelled image of Varjo VR controller** (buttons, thumbstick, grip).
- **Labelled image of human hand** (thumb, index, middle, etc.) showing tracked landmarks.
- **DoF matrix table** (repeated from 3.4 for clarity).

### 4.2 Software Architecture
- **UML class diagram** for the FSM and provider hierarchy.
- Explanation of the **hardware abstraction layer** (`BaseInteractionProvider`).

### 4.3 Gesture Recognition Engine
- **Deterministic FSM diagram** with state transition conditions.
- Implementation details: pinch threshold, grip threshold, Coyote time (grace period).
- Code snippet (in appendix) for state machine logic.

### 4.4 Kinematic Mathematics
- **Quaternion rotations** to avoid gimbal lock (cite Fang et al., 1998).
- **Delta calculation** for position and rotation.
- **Scale‑around‑pivot** algorithm for bimanual scaling.

### 4.5 Telemetry and Data Logging
- **Data pipeline diagram** (sensors → Unity → CSV → analysis).
- Logging frequency (20 Hz), CSV format, and post‑processing.

### 4.6 User Interface and Visual Feedback
- **Soft visual constraints** (landing windows, colour change on alignment).
- Ghost target and solid liver rendering.

---

## Chapter 5: Validation

**Purpose:** Prove that the system works correctly through systematic testing.

### 5.1 Unit Testing
- Tests for `Diagnostics` class (conditional logging, colour coding).
- Tests for `TrialTask` bitmask logic.
- Tests for FSM state transitions without hardware.

### 5.2 Integration Testing
- Using **XR Device Simulator** to simulate controller/hand inputs.
- Verification of telemetry accuracy (inject known movements, compare logged values).

### 5.3 Pilot Study (N=5)
- Dry run to identify issues (tracking loss, UI clarity).
- Adjustments made (Coyote time, threshold tuning, demo scene).

### 5.4 Main User Study (N=10‑20)
- Execution of protocol described in Chapter 3.
- Data collection and export.

---

## Chapter 6: Results, Evaluation and Discussion

**Purpose:** Present the data objectively, then interpret it using the literature.

### 6.1 Results

#### 6.1.1 Participant Demographics and Flow
- **Table of baseline characteristics**.
- **CONSORT flow diagram** (reference to Chapter 3).

#### 6.1.2 Objective Performance Metrics
- **Box plots** comparing TCT between Controller and Hand for each task.
- **Bar charts** of mean positional error, rotational error, path inefficiency, rotational inefficiency.
- **Heatmap** of clutch count across tasks and conditions.
- **Line graphs** showing learning curve (TCT over trial order).
- **Paired t‑test results** (or Wilcoxon) for TCT and inefficiency ratios.

#### 6.1.3 Subjective Metrics (RTLX and SUS)
- **Bar charts** of mean RTLX sub‑scale scores.
- **SUS scores** (mean and SD) for each condition.
- **Bland‑Altman plots** to show agreement between objective error and subjective performance rating.

#### 6.1.4 Qualitative Feedback
- **Thematic analysis** of open feedback (preference, fatigue, gesture issues).

### 6.2 Discussion

#### 6.2.1 Interpretation of Results
- Compare findings to literature: Khundam (2021), Luong (2023), Allgaier (2022).
- **Fatigue and ergonomics:** Relate clutch count and RTLX physical demand to CE (Hincapié‑Ramos) and CAF (Jang).
- **Cognitive load:** Higher mental demand in hand‑tracking? Link to lack of haptics (Buckingham, 2021) and visual compensation (Tang et al., 2024).
- **Controller advantages:** Binary certainty, haptic grounding, no occlusion.

#### 6.2.2 Limitations
- Fixed order (learning effect) – acknowledged.
- Small sample size – not powered; treat as pilot.
- Optical occlusion and jitter – cite Mueller (2017), Gil‑Martín (2024).
- Lack of blinding (researcher administered tasks).

#### 6.2.3 Relation to Aims and Objectives
- Explicitly state whether each objective was met.

### 6.3 Conclusions
- **Summary of findings:** Hand‑tracking is viable and preferred for embodiment, but controllers remain more accurate for fine manipulation.
- **Final verdict:** Hand‑gesture navigation reduces cognitive friction for gross manipulation, but current optical limitations hinder sub‑millimetre precision.

### 6.4 Future Work
- **Sensor fusion** (multi‑camera arrays, IMU gloves) – cite Gil‑Martín (2024), Cho (2026).
- **Gaze‑assisted selection** for occluded anatomy – cite Sidenmark (2020), Pfeuffer (2017).
- **Haptic feedback integration** (ultrasonic or vibrotactile).
- **Multi‑user collaborative planning** – cite Chheang (2021).
- **Larger RCT with balanced crossover design.**

---

## References

- List of **73+ references** in consistent citation style (e.g., APA 7th). Include DOIs where available.

---

## Appendices

### Appendix A: Self‑appraisal (10% of mark)
- **A.1 Critical self‑evaluation:** What went well, what went wrong, how you adapted.
- **A.2 Personal reflection and lessons learned:** Technical skills, project management, communication.
- **A.3 Legal, Social, Ethical, Professional Issues (LSEPI):**
  - **A.3.1 Legal:** Data protection (GDPR), software licences.
  - **A.3.2 Social:** Accessibility, impact on surgical training.
  - **A.3.3 Ethical:** Informed consent, motion sickness screening, right to withdraw, ethics approval.
  - **A.3.4 Professional:** Code of conduct, reproducibility, open science.

### Appendix B: External Material
- **B.1** Gantt chart / project timeline.
- **B.2** Full code repository (link or relevant snippets).
- **B.3** Raw telemetry CSV samples.

### Appendix C: Ethics Documentation
- **C.1** Ethics approval letter (if obtained).
- **C.2** Participant information sheet.
- **C.3** Informed consent form.
- **C.4** Raw NASA‑TLX questionnaire.
- **C.5** System Usability Scale (SUS) questionnaire.
- **C.6** Post‑task open feedback form.

---

## Checklist of Required Elements – Where Each Appears

| Element                                      | Location                                  |
| -------------------------------------------- | ----------------------------------------- |
| UML for code and scripts                     | §3.3 (architecture), §4.2 (class diagram) |
| Deterministic FSM for gestures               | §3.4, §4.3 (state diagram)                |
| ART (ANOVA) for telemetry                    | §3.7                                      |
| Results and comparative tables               | §6.1                                      |
| Controller & Hand DoF matrix table           | §3.4, §4.1                                |
| CONSORT flow diagram                         | §3.1                                      |
| Participant characterisation table           | §3.2                                      |
| SUS and RTLX scores (bar charts)             | §6.1.3                                    |
| Paired sample t‑test results                 | §6.1.2                                    |
| Taxonomy of techniques & task decomposition  | §2.1.2, §3.1                              |
| Table of acronyms                            | Front Matter                              |
| Bland‑Altman plots                           | §6.1.3                                    |
| Box plots, heatmaps, line graphs, bar charts | §6.1.2, §6.1.3                            |
| Labelled bone hand image                     | §4.1                                      |
| Labelled Varjo controller image              | §4.1                                      |
| Justification of all metrics                 | §3.5                                      |
| Fitts’ law                                   | §2.1.3, §3.5                              |
| Heisenberg effect                            | §2.5.1                                    |
| Carry‑over effect                            | §3.1, §3.7                                |
| Drift                                        | §2.4.3, §4.2.2                            |
| Gimbal lock                                  | §2.1.1, §4.4                              |
| Hausdorff distance                           | §3.5 (optional)                           |
| Performance timers                           | §3.5                                      |
| Medical need (danger, cost, time, skill)     | §1.1                                      |
| 2D input for 3D models                       | §1.1                                      |
| Gaps in learning                             | §1.1                                      |

---

This structure **fully integrates** your rough plan, the literature vault, the marking rubric, and all checklist items. It is **ready for execution** at the highest academic standard.